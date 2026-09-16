# TP Gestión de Facturas (DAS)

Aplicación de escritorio **Windows Forms (.NET 8)** para emitir y consultar facturas, con persistencia en **SQL Server** mediante **ADO.NET en modo conectado** (`SqlConnection`, `SqlCommand`, `SqlDataReader`, `SqlTransaction`).

## Requisitos

- .NET SDK 8 o superior.
- SQL Server LocalDB instalado y el servicio `MSSQLLocalDB` disponible.
- Visual Studio 2022 (opcional) o `dotnet` CLI.

## Base de datos

No hace falta crear la base a mano: al iniciar la aplicación se ejecuta `Conexion.AsegurarBaseDeDatos()`, que:

1. crea la base `TPGestionFacturas_DAS` si no existe;
2. crea las tablas `Productos`, `Facturas` y `FacturasDetalles` (con PK, FK, `NOT NULL` y `UNIQUE`);
3. aplica migraciones idempotentes (columna `Estado` y restricciones `UNIQUE`);
4. inserta productos de ejemplo (Mouse, Teclado, Monitor) si la tabla está vacía.

Para crear la base manualmente sin ejecutar la app:

```powershell
sqllocaldb start MSSQLLocalDB
dotnet run --project .\TPGestionFacturas_DAS\TPGestionFacturas_DAS\TPGestionFacturas_DAS.csproj
```

### Cadena de conexión

Definida en `Datos/Conexion.cs`:

```
Server=(localdb)\mssqllocaldb;Database=TPGestionFacturas_DAS;Integrated Security=true;TrustServerCertificate=true;
```

Para usar otra instancia, edite `Conexion.CadenaConexion`.

## Cómo ejecutar

```powershell
dotnet run --project .\TPGestionFacturas_DAS\TPGestionFacturas_DAS\TPGestionFacturas_DAS.csproj
```

o abra `TPGestionFacturas_DAS\TPGestionFacturas_DAS.slnx` en Visual Studio y presione **F5**.

## Funcionalidad

- **Productos (ABM):** alta, modificación, baja lógica (`Activo = 0`) y baja física solo si el producto no está referenciado en ninguna factura. Búsqueda por código o nombre. Validación de código único, nombre no vacío y precio ≥ 0.
- **Nueva factura (maestro–detalle):** fecha por defecto hoy, datos del cliente, selección de producto activo, cantidad, precio vigente y subtotal. Rechaza productos duplicados. Recalcula el total en pantalla. Graba cabecera y detalle en **una sola transacción**. Copia `PrecioUnitario` y `Subtotal` a cada línea.
- **Consulta de facturas:** filtro por rango de fechas y/o texto de cliente, visualización de cabecera y detalle en modo solo lectura y **anulación por estado** (`Anulada`), sin permitir anular dos veces.
- **Informe:** por producto, cantidad facturada y monto en un período (grilla).

## Estructura del proyecto

```
TPGestionFacturas_DAS/
├── Form1.cs              UI: eventos y flujo de pantalla
├── Form1.Designer.cs     Controles (4 pestañas)
├── Program.cs            Arranque: prepara la base y abre el formulario
├── Datos/
│   ├── Conexion.cs       Cadena de conexión, creación de esquema y seed
│   ├── ProductoDao.cs    Acceso a datos de productos
│   └── FacturaDao.cs     Acceso a datos de facturas (transacción)
└── Entidades/
    ├── Producto.cs
    ├── Factura.cs
    └── FacturaDetalle.cs
```

## Decisiones de diseño

- **El precio vive en el detalle:** al facturar se copia `Producto.Precio` a `FacturaDetalle.PrecioUnitario`. Cambiar el precio del producto no altera facturas ya emitidas.
- **Cabecera + detalle en transacción:** `FacturaDao.Insertar` abre un `SqlTransaction`; si falla cualquier `INSERT`, se hace rollback y no quedan facturas huérfanas.
- **Doble validación:** la UI valida antes de guardar y la base de datos refuerza con `UNIQUE`/`FK`/`NOT NULL`.
- **Número de factura:** correlativo controlado por la aplicación con `SELECT ISNULL(MAX(NumeroFactura),0)+1 ... WITH (UPDLOCK, HOLDLOCK)`, protegido además por restricción `UNIQUE`.
- **Sin `SqlDataAdapter`/`DataSet`/`DataTable` ni ORMs:** todo el acceso es conectado con parámetros (`@Nombre`), nunca concatenando valores del usuario.

