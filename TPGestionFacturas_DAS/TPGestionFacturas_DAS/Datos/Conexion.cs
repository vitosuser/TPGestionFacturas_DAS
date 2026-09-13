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
                    NumeroProducto INT NOT NULL,
                    Nombre NVARCHAR(80) NOT NULL,
                    Precio DECIMAL(18,2) NOT NULL,
                    Activo BIT NOT NULL
                )
            END

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Facturas')
            BEGIN
                CREATE TABLE Facturas (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    NumeroFactura INT NOT NULL,
                    Fecha DATE NOT NULL,
                    ClienteNombre NVARCHAR(80) NOT NULL,
                    ClienteDocumento NVARCHAR(20) NOT NULL,
                    Total DECIMAL(18,2) NOT NULL,
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

            using SqlCommand hayProductos = new SqlCommand("SELECT COUNT(*) FROM Productos", conexion);
            int cantidad = (int)hayProductos.ExecuteScalar();
            if (cantidad > 0)
            {
                return;
            }

            using SqlCommand seed = new SqlCommand(
                """
            INSERT INTO Productos (NumeroProducto, Nombre, Precio, Activo) VALUES
            (1, N'Mouse', 100.00, 1),
            (2, N'Teclado', 200.00, 1),
            (3, N'Monitor', 300.00, 1)
            """,
                conexion);
            seed.ExecuteNonQuery();
        }
            
    }
}
