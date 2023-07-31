using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ENTIDADES.SP
{
    public static class Extensora
    {
        public static bool EliminarFruta(this Cajon<Manzana> c, int id)
        {
            bool retorno = false;

            try
            {

                using (SqlConnection sqlConexion = new SqlConnection(Properties.Settings.Default.conexion))
                {
                    sqlConexion.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM frutas WHERE id = @id ";//le digo que voy a borrar una persona donde se encuentren estos datos
                    comando.Parameters.AddWithValue("@id", id);
                    int filas = comando.ExecuteNonQuery();

                    if (filas != 0)
                    {
                        retorno = true;
                    }


                }
            }
            catch (Exception e)
            {
                throw e;
            }


            return retorno;

        }

    }
}
