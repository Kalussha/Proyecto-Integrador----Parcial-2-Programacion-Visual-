using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Proyecto_Unidad_1_Programacion_Visual
{
    public class CocheDAO
    {
        // M�todo para insertar un nuevo coche (ALTA)
        public static bool InsertarCoche(Coche coche)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO coches (placa, marca, modelo, anio, tipo) 
                                   VALUES (@placa, @marca, @modelo, @anio, @tipo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@placa", coche.Placa);
                        cmd.Parameters.AddWithValue("@marca", coche.Marca);
                        cmd.Parameters.AddWithValue("@modelo", coche.Modelo);
                        cmd.Parameters.AddWithValue("@anio", coche.Anio);
                        cmd.Parameters.AddWithValue("@tipo", coche.Tipo);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry
                {
                    throw new Exception("La placa ya existe en la base de datos.");
                }
                throw new Exception("Error al insertar: " + ex.Message);
            }
        }

        // M�todo para consultar un coche por placa (CONSULTAR)
        public static Coche ConsultarCochePorPlaca(string placa)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM coches WHERE placa = @placa";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@placa", placa);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Coche
                                {
                                    Id = reader.GetInt32("id"),
                                    Placa = reader.GetString("placa"),
                                    Marca = reader.GetString("marca"),
                                    Modelo = reader.GetString("modelo"),
                                    Anio = reader.GetInt32("anio"),
                                    Tipo = reader.GetString("tipo")
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar: " + ex.Message);
            }
        }

        // M�todo para consultar todos los coches
        public static List<Coche> ConsultarTodosLosCoches()
        {
            List<Coche> coches = new List<Coche>();
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM coches ORDER BY id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                coches.Add(new Coche
                                {
                                    Id = reader.GetInt32("id"),
                                    Placa = reader.GetString("placa"),
                                    Marca = reader.GetString("marca"),
                                    Modelo = reader.GetString("modelo"),
                                    Anio = reader.GetInt32("anio"),
                                    Tipo = reader.GetString("tipo")
                                });
                            }
                        }
                    }
                }
                return coches;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar todos los coches: " + ex.Message);
            }
        }

        // M�todo para actualizar un coche (CAMBIOS)
        public static bool ActualizarCoche(Coche coche)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE coches 
                                   SET marca = @marca, modelo = @modelo, anio = @anio, tipo = @tipo 
                                   WHERE placa = @placa";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@placa", coche.Placa);
                        cmd.Parameters.AddWithValue("@marca", coche.Marca);
                        cmd.Parameters.AddWithValue("@modelo", coche.Modelo);
                        cmd.Parameters.AddWithValue("@anio", coche.Anio);
                        cmd.Parameters.AddWithValue("@tipo", coche.Tipo);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message);
            }
        }

        // M�todo para eliminar un coche (BAJA)
        public static bool EliminarCoche(string placa)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM coches WHERE placa = @placa";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@placa", placa);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message);
            }
        }
    }
}
