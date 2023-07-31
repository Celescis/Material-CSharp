using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    //4.- Crear la bd bd-modelo-sp y ejecutar el script, luego realizar un crud en la entidad correspondiente.
    //    USE[bd - modelo - sp]
    //    GO
    //CREATE TABLE[dbo].[usuario]
    //    (
    //[id][int] IDENTITY(1,1) NOT NULL,
    //[nombre] [varchar] (100) NOT NULL,
    //[edad] [int]
    //    NOT NULL
    //) ON[PRIMARY]
    //GO
    public class Usuario : ISerializarJSON
    {
        //ATRIBUTOS
        int id;
        string nombre;
        int edad;

        //CONSTRUCTOR
        public Usuario(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public Usuario(int id, string nombre, int edad) : this(nombre,edad)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public bool DeserializarJson(string path, out Usuario user)
        {
            bool isOk = false;
            string archivo = path + @"\ExportadoJson";

            try
            {
                archivo += @"Informe " + DateTime.Now.ToString("HH_mm_ss") + ".json";

                string jsonString = File.ReadAllText(archivo);

                user = JsonSerializer.Deserialize<Usuario>(jsonString);

                isOk = true;
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error al querer exportar el archivo");
                throw ex;
            }

            return isOk;
        }

        public bool SerializarJson(string path)
        {
            bool isOk = false;
            string archivo = path + @"\ExportadoJson";
            try
            {
                if (!Directory.Exists(archivo))
                {
                    Directory.CreateDirectory(archivo);
                }

                archivo += @"Informe " + DateTime.Now.ToString("HH_mm_ss") + ".json";

                JsonSerializerOptions opciones = new JsonSerializerOptions();

                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(this, opciones);

                File.WriteAllText(archivo, jsonString);

                isOk = true;

            }
            catch (Exception)
            {
                Exception ex = new Exception("Error al querer exportar el archivo");
                throw ex;
            }

            return isOk;
        }

    }
}
