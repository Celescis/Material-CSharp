using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        //Métodos: ObtenerListaPlaneta() :List<Planeta>
        //AgregarPlaneta(planeta:Planeta):bool
        //ModificarPlaneta(planeta:Planeta):bool
        //EliminarPlaneta(id:Int):bool
    public class AccesoDatos
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static AccesoDatos()
        {
            cadena_conexion = @"Data Source=PC-ASROCK;Database=Astros;Trusted_Connection=True;";
        }
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        public List<Planeta> ObtenerListaPlaneta()
        {
            List<Planeta> lista = new List<Planeta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM planetas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Planeta item = new Planeta();

                    item.id = (int)lector["id"];
                    item.nombre = lector[1].ToString();
                    item.satelites = lector.GetInt32(2);
                    item.gravedad = float.Parse(lector[3].ToString());

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        public bool AgregarPlaneta(Planeta planeta)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO planetas (nombre, satelites, gravedad) VALUES(";
                sql = sql + "'" + planeta.nombre + "'," + planeta.satelites.ToString() + "," + planeta.gravedad.ToString() + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarDato(Planeta planeta)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", planeta.id);
                this.comando.Parameters.AddWithValue("@nombre", planeta.nombre);
                this.comando.Parameters.AddWithValue("@satelites", planeta.satelites);
                this.comando.Parameters.AddWithValue("@gravedad", planeta.gravedad);

                string sql = "UPDATE planetas ";
                sql += "SET nombre = @nombre, satelites = @satelites, gravedad = @gravedad ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }

        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM planetas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }
    }
}
