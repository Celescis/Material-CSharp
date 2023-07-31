using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {

        static string nombreArchivo3 = "ToString.log";
        static string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string rutaArchivo3 = Path.Combine(applicationData, nombreArchivo3);

        public static void MiManejador(Usuario usuario, EventArgs e)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo3, true))
                {
                    sw.Write("Este es el ");
                    sw.WriteLine("encabezado para el archivo.");
                    sw.WriteLine("-----------------------------");

                    sw.Write("LA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(usuario);
                    Console.WriteLine("affsgeegg");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {

           string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = "Personas.xml";
           string nombreArchivo2 = "Usuarios.json";

            string rutaArchivo = Path.Combine(applicationData, nombreArchivo);
            string rutaArchivo2 = Path.Combine(applicationData, nombreArchivo2);


            
            Generica<Persona, int> personas = new Generica<Persona, int>(14);
            Generica<Persona, int> personas2;

            personas.Agregar(new Persona(123123));
            personas.Agregar(new Persona(123111));
            personas.Agregar(new Persona(12222123));
            personas.Agregar(new Persona(12399913));

            Console.WriteLine(personas);

            //if (personas.Serializar(rutaArchivo))
            //{
            //    Console.WriteLine("El archivo se encuentra en el escritorio");
            //}

            //Console.WriteLine(personas.ValidarSiExisteArchivo(rutaArchivo));

            //personas.Deserializar(rutaArchivo, out personas2);
            //foreach (var item in personas2.Lista)
            //{
            //    Console.WriteLine(item);
            //}

            List<Usuario> usuarios = new List<Usuario>();

            Usuario usuario1 = new Usuario("ines", 21);
            Usuario usuario2 = new Usuario("pepe", 31);
            Usuario usuario3 = new Usuario("jorge", 51);
            Usuario usuario4 = new Usuario("ana", 11);
            Usuario usuario5 = new Usuario("adaasds", 123);

          //  Usuario.Create(usuario5);

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
            usuarios.Add(usuario4);



            //foreach (Usuario item in usuarios)
            //{
            //    Usuario.Create(item);
            //}

            //List<Usuario> usuarios2 = Usuario.ReadAll();


            //foreach (Usuario item in usuarios2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(usuario1.Serializar(rutaArchivo2));
            usuario1.ToStringInvocado += Program.MiManejador;

            usuario1.ToString();

            //List<Usuario> usuarios1 = Extension.ObtenerTodos(usuarios);

            //List<Usuario> usuarios1 = usuario1.ObtenerTodos();
            //foreach (Usuario item in usuarios1)
            //{
            //    Console.WriteLine(item);
            //}



            // RECUPERA LA INFORMACION DE OTRO HILO Y LA MUESTRA
            Task task = Task.Run(() => usuario1.RecuperarInfo(rutaArchivo3));
            task.Wait();
        }
    }
}
