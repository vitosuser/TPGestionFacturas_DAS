using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TPGestionFacturas_DAS.Datos
{
    internal static class Conexion
    {
        public const string CadenaConexion =
            @"Server=(localdb)\mssqllocaldb;Database=TPGestionFacturas_DAS;Integrated Security=true;TrustServerCertificate=true;";

        public static SqlConnection Crear()
        {
            return new SqlConnection(CadenaConexion);
        }

        public static void AsegurarBaseDeDatos()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(CadenaConexion);
            string nombreBase = builder.InitialCatalog;
            builder.InitialCatalog = "master";

            using (SqlConnection master = new SqlConnection(builder.ConnectionString))
            {
                master.Open();
                using SqlCommand crearBase = new SqlCommand(
                    $"IF DB_ID('{nombreBase}') IS NULL CREATE DATABASE [{nombreBase}]",
                    master);
                crearBase.ExecuteNonQuery();
            }

            using SqlConnection conexion = Crear();
            conexion.Open();

            using SqlCommand crearTablas = new SqlCommand(
                """
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Productos')
            BEGIN
                CREATE TABLE Productos (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    NumeroProducto NVARCHAR(30) NOT NULL UNIQUE,
                    Nombre NVARCHAR(80) NOT NULL,
                    Precio DECIMAL(18,2) NOT NULL,
                    Activo BIT NOT NULL
                )
            END

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Facturas')
            BEGIN
                CREATE TABLE Facturas (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    NumeroFactura INT NOT NULL UNIQUE,
                    Fecha DATE NOT NULL,
                    ClienteNombre NVARCHAR(80) NOT NULL,
                    ClienteDocumento NVARCHAR(20) NOT NULL,
                    Estado NVARCHAR(20) NOT NULL CONSTRAINT DF_Facturas_Estado DEFAULT 'Emitida',
                    Total DECIMAL(18,2) NOT NULL
                )
            END

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FacturasDetalles')
            BEGIN
                CREATE TABLE FacturasDetalles (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    FacturaId INT NOT NULL,
                    ProductoId INT NOT NULL,
                    Cantidad INT NOT NULL,
                    PrecioUnitario DECIMAL(18,2) NOT NULL,
                    Subtotal DECIMAL(18,2) NOT NULL,
                    CONSTRAINT FK_FacturasDetalles_Facturas FOREIGN KEY (FacturaId) REFERENCES Facturas(Id),
                    CONSTRAINT FK_FacturasDetalles_Productos FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
                )
            END
            """,
                conexion);
            crearTablas.ExecuteNonQuery();

            using (SqlCommand migraciones = new SqlCommand(
                """
                IF NOT EXISTS (SELECT * FROM sys.columns WHERE name = 'Estado' AND object_id = OBJECT_ID('Facturas'))
                    ALTER TABLE Facturas ADD Estado NVARCHAR(20) NOT NULL CONSTRAINT DF_Facturas_Estado DEFAULT 'Emitida';

                IF NOT EXISTS (
                    SELECT 1
                    FROM sys.indexes i
                    INNER JOIN sys.index_columns ic ON ic.object_id = i.object_id AND ic.index_id = i.index_id
                    INNER JOIN sys.columns c ON c.object_id = ic.object_id AND c.column_id = ic.column_id
                    WHERE i.object_id = OBJECT_ID('Facturas') AND i.is_unique = 1 AND c.name = 'NumeroFactura')
                    ALTER TABLE Facturas ADD CONSTRAINT UQ_Facturas_NumeroFactura UNIQUE (NumeroFactura);

                IF NOT EXISTS (
                    SELECT 1
                    FROM sys.indexes i
                    INNER JOIN sys.index_columns ic ON ic.object_id = i.object_id AND ic.index_id = i.index_id
                    INNER JOIN sys.columns c ON c.object_id = ic.object_id AND c.column_id = ic.column_id
                    WHERE i.object_id = OBJECT_ID('Productos') AND i.is_unique = 1 AND c.name = 'NumeroProducto')
                    ALTER TABLE Productos ADD CONSTRAINT UQ_Productos_NumeroProducto UNIQUE (NumeroProducto);
                """,
                conexion))
            {
                migraciones.ExecuteNonQuery();
            }

            using SqlCommand hayProductos = new SqlCommand("SELECT COUNT(*) FROM Productos", conexion);
            int cantidad = (int)hayProductos.ExecuteScalar();
            if (cantidad > 0)
            {
                return;
            }

            using SqlCommand seed = new SqlCommand(
                """
            INSERT INTO Productos (NumeroProducto, Nombre, Precio, Activo) VALUES
            (N'P001', N'Mouse', 100.00, 1),
            (N'P002', N'Teclado', 200.00, 1),
            (N'P003', N'Monitor', 300.00, 1)
            """,
                conexion);
            seed.ExecuteNonQuery();
        }
            
    }
}
