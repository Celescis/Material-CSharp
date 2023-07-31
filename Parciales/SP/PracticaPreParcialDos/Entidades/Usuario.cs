using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
   //Delegado
   public delegate void InvocarToSring(Usuario sender, EventArgs e);

   public class Usuario : ISerializarJson
    {   
        //Declaracion de evento ( es igual a la firma del delegado )
        public event InvocarToSring ToStringInvocado;

        //Atributos de usuario
        int id;
        string nombre;
        int edad;

        //Atributos de conexion
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        
        public Usuario()
        {

        }

        //Constructor que se usara para leer y guardar ademas el ID
        public Usuario(int id, string nombre, int edad): this(nombre, edad)
        {
            this.id = id;

        }

        //Constructor que se usara para crear usuarios
        public Usuario(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Constructor static que permite formar una conexion con la base de datos
        static Usuario()
        {
            command = new SqlCommand();
            connectionString = "Server = .; Database=bd-modelo-sp ; Trusted_Connection=true";
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }


        //READ en la base de datos
        public static List<Usuario> ReadAll()
        {

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM usuario";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    usuarios.Add(new Usuario(Convert.ToInt32(sqlDataReader["id"]),
                                             sqlDataReader["nombre"].ToString(),
                                             Convert.ToInt32(sqlDataReader["edad"])));
                }

                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer leer");
                throw ex;
            }
            finally
            {

                connection.Close();

            }

            return usuarios;

        }

        //CREATE en la base de datos
        public static void Create(Usuario usuario)
        {

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO usuario (nombre, edad) VALUES (@nombre, @edad)";
                command.Parameters.AddWithValue("@nombre", usuario.nombre);
                command.Parameters.AddWithValue("@edad", usuario.edad);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer eliminar");
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        //DELETE en la base de datos
        public static void Delete(int id)
        {

            try
            {
                command.Parameters.Clear(); 
                connection.Open();
                command.CommandText = $"DELETE FROM usuario WHERE id = {id}";
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer eliminar");
                throw ex;
            }
            finally
            {

                connection.Close();
            }

        }

        //UPDATE en la base de datos
        public static void Update(Usuario usuario)
        {

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE usuario SET nombre = @nombre, edad= @edad WHERE id = {usuario.Id}";
                command.Parameters.AddWithValue("@nombre", usuario.nombre);
                command.Parameters.AddWithValue("@edad", usuario.edad);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer modificar");
                throw ex;
            }
            finally
            {

                connection.Close();
            }

        }

        //Invocacion del evento cuando se usa el ToString
        public override string ToString()
        {
           
            this.ToStringInvocado.Invoke(this, EventArgs.Empty);

            return "Id: " + this.id + " nombre: " + this.nombre +  " edad: " + this.edad; 
        }

        //Serializa en formato JSON
        public bool Serializar(string path)
        {
            bool retorno = false;

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                string json = JsonSerializer.Serialize(this);
                streamWriter.Write(json);
                retorno = true;
            }
            return retorno;
        }

        //Deserealiza en formato JSON
        public bool Deserializar(string path, out Usuario datos)
        {
            bool retorno = false;

            using (StreamReader streamReader = new StreamReader(path))
            {
                string json = streamReader.ReadToEnd();
                datos = JsonSerializer.Deserialize<Usuario>(json);
                retorno = true;
            }
            return retorno;
        }

        //Recupera la informacion del .log y lo muestra en HILO SECUNDARIO (mirar program)
        public void RecuperarInfo(string rutaArchivo3)
        {
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo3))
                {
                    String linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
