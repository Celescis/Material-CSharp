using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRSP
{
    ///AlumnoADO (hereda de Alumno)
    ///Atributos (estáticos)
    ///conexion : string
    ///connection : SqlConnection
    ///command : SqlCommand
    ///Constructor de clase que inicialice todos sus atributos
    ///Constructor que recibe un objeto de tipo Alumno cómo parámetro
    ///Métodos de instancia (públicos):
    ///ObtenerTodos() : List<Alumno> 
    ///Agregar() : bool
    ///Modificar() : bool -> se modifica a partir del dni
    ///Eliminar() : bool -> se elimina a partir del dni
    public class AlumnoADO : Alumno
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        Alumno auxAlumno;

        static AlumnoADO()
        {
            connectionString = @"Data Source=DESKTOP-Q90H3PF;Database=utn_fra_alumnos;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public AlumnoADO(Alumno alumno) : base(alumno.Nota, alumno.Nombre, alumno.Apellido, alumno.Dni)
        {
            this.auxAlumno = alumno;
        }
        public static List<Alumno> ObtenerTodos()
        {
            List<Alumno> lista = new List<Alumno>();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "SELECT * FROM alumnos";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    lista.Add(new Alumno(double.Parse(dataReader["nota"].ToString()), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), int.Parse(dataReader["dni"].ToString())));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return lista;
        }

        public bool Agregar()
        {
            bool isOk = false;
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"INSERT INTO alumnos (nombre, apellido, dni, nota) VALUES (@nombre , @apellido, @dni, @nota)";
                command.Parameters.AddWithValue("@nombre", this.auxAlumno.Nombre);
                command.Parameters.AddWithValue("@apellido", this.auxAlumno.Apellido);
                command.Parameters.AddWithValue("@dni", this.auxAlumno.Dni);
                command.Parameters.AddWithValue("@nota", this.auxAlumno.Nota);

                command.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isOk;
        }

        public bool Modificar()
        {
            bool isOk = false;
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"UPDATE alumnos SET nombre = @nombre , apellido = @apellido , nota = @nota WHERE dni = @dni";
                command.Parameters.AddWithValue("@nombre", this.auxAlumno.Nombre);
                command.Parameters.AddWithValue("@apellido", this.auxAlumno.Apellido);
                command.Parameters.AddWithValue("@dni", this.auxAlumno.Dni);
                command.Parameters.AddWithValue("@nota", this.auxAlumno.Nota);

                command.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isOk;
        }

        public bool Eliminar()
        {
            bool isOk = false;
            try
            {
                command.Parameters.Clear();

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = $"DELETE FROM alumnos WHERE dni = @dni";
                command.Parameters.AddWithValue("@nombre", this.auxAlumno.Nombre);
                command.Parameters.AddWithValue("@apellido", this.auxAlumno.Apellido);
                command.Parameters.AddWithValue("@dni", this.auxAlumno.Dni);
                command.Parameters.AddWithValue("@nota", this.auxAlumno.Nota);

                command.ExecuteNonQuery();
                isOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isOk;
        }

    }
}
