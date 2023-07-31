using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        //CONSTRUCTOR
        static UsuarioAccesoDatos()
        {
            connectionString = @"Data Source=DESKTOP-Q90H3PF;Database=bd-modelo-sp;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                command.CommandText = "SELECT * FROM usuarios";
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    lista.Add(new Usuario(int.Parse(dataReader["id"].ToString()), dataReader["nombre"].ToString(), int.Parse(dataReader["edad"].ToString())));
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Editar(Usuario userEdit)
        {
            try
            {
                command.Parameters.Clear();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "UPDATE usuario SET nombre = @nombre , edad = @edad WHERE id = @id";
                command.Parameters.AddWithValue("@nombre", userEdit.Nombre);
                command.Parameters.AddWithValue("@edad", userEdit.Edad);
                command.Parameters.AddWithValue("@id", userEdit.Id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Metodo que borra un jugador de la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"DELETE FROM usuario WHERE id = @id";
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Metodo que guarda un jugador en la base de datos
        /// </summary>
        /// <param name="jugador"></param>
        public static void Guardar(Usuario user)
        {
            try
            {
                command.Parameters.Clear();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"INSERT INTO usuario (id, nombre, edad) VALUES (@nombre , @edad)";
                command.Parameters.AddWithValue("@nombre", user.Nombre);
                command.Parameters.AddWithValue("@edad", user.Edad);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

