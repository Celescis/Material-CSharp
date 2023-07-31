using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JugadorAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static JugadorAccesoDatos()
        {
            connectionString = @"Data Source=DESKTOP-Q90H3PF;Database=WikiCrafteoDB;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }
        public static DataTable LeerConsulta()
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_ObtenerTodos", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dt);

                cmd.ExecuteReader();

                return dt;
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

        public static void BorrarConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_BorrarJugador", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_JUGADOR", player.Id);
                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);

                cmd.ExecuteNonQuery();
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

        public static void GuardarJugadorConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarJugador", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_JUGADOR", player.Id);
                cmd.Parameters.AddWithValue("USUARIO", player.Usuario);
                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);

                cmd.ExecuteNonQuery();
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

        public static void GuardarCuboConsulta(Jugador player, Cubo cubo)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarCubo", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);
                cmd.Parameters.AddWithValue("CCANTIDAD", cubo.Cantidad);
                cmd.Parameters.AddWithValue("CMATERIAL", cubo.Tipo.ToString());
                cmd.Parameters.AddWithValue("TIPO", 0);
                cmd.Parameters.AddWithValue("DESCRIPCION", "");

                cmd.ExecuteNonQuery();
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

        public static void GuardarHerramientaConsulta(Jugador player, Herramienta tool)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_GuardarHerramienta", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);
                cmd.Parameters.AddWithValue("HCANTIDAD", tool.Cantidad);
                cmd.Parameters.AddWithValue("HMATERIAL", tool.Tipo.ToString());
                cmd.Parameters.AddWithValue("TIPO", 1);
                cmd.Parameters.AddWithValue("DESCRIPCION", tool.TipoHerramienta.ToString());

                cmd.ExecuteNonQuery();
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
        public static void EditarInventarioConsulta(Jugador player)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("consulta_EditarInventario", command.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ID_INVENTARIO", player.Inventario.ID);
                cmd.Parameters.AddWithValue("CAPACIDAD", player.Inventario.Capacidad);

                cmd.ExecuteNonQuery(); 
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

        public static void EditarJugador(Jugador jugadorEdit)
        {
            try
            {
                command.Parameters.Clear();

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "UPDATE Jugadores SET USUARIO = @USUARIO WHERE ID_JUGADOR = @ID";
                command.Parameters.AddWithValue("@USUARIO", jugadorEdit.Usuario);
                command.Parameters.AddWithValue("@ID", jugadorEdit.Id);

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
