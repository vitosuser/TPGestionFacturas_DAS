using Microsoft.Data.SqlClient;
using TPGestionFacturas_DAS.Datos;

namespace TPGestionFacturas_DAS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                Conexion.AsegurarBaseDeDatos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "No se pudo conectar con SQL Server (LocalDB) ni preparar la base de datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Verifique que el servicio SQL Server LocalDB esté disponible." +
                    Environment.NewLine + Environment.NewLine +
                    ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1());
        }
    }
}
