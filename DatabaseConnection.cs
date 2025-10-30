using MySql.Data.MySqlClient;
using System;

namespace Proyecto_Unidad_1_Programacion_Visual
{
    public class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=8875421390";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        // Método para probar la conexión
        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
