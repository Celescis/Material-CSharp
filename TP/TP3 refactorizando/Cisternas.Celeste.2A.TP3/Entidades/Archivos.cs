using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Entidades
{
    public class Archivos
    {
        /// <summary>
        /// Guarda la lista de jugadores con su inventario en un archivo txt  
        /// </summary>
        /// <param name="archivo">archivo a guardar</param>
        /// <param name="dato">datos a guardar</param>
        /// <returns>true si se guardo sino false</returns>
        static public bool GuardarTxt(string archivo, Wiki jugadores)
        {
            bool isOk = false;
            List<Jugador> lista = jugadores.Jugadores;
            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    foreach (Jugador item in lista)
                    {
                        sb.Clear();

                        foreach (Elemento e in item.Inventario.ListaElementos)
                        {
                            if (e is Cubo)
                            {
                                sb.Append($"/C/{e.Cantidad},{e.Tipo},{((Cubo)e).DurezaPropiedad};");
                            }
                            else
                            {
                                sb.Append($"/H/{e.Cantidad},{e.Tipo},{((Herramienta)e).TipoHerramienta},{((Herramienta)e).Durabilidad};");
                            }
                        }

                        sb.Append($"/J/{item.Id}, {item.Usuario}, {item.Inventario.Capacidad}");
                        writer.WriteLine(sb.ToString());
                    }

                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isOk;
        }
        /// <summary>
        /// Lee un archivo txt y guarda los datos en una lista de jugadores
        /// </summary>
        /// <param name="archivo">archivo a gleer</param>
        /// <param name="texto">datos a guardar</param>
        /// <returns>true si se leyo sino false</returns>
        static public bool LeerTxt(string archivo, out Wiki jugadores)
        {
            bool isOk = false;
            jugadores = new Wiki();
            List<Jugador> lista = new List<Jugador>();
            Cubo cubo;
            Herramienta tool;
            string linea;
            string[] datos;
            string[] array;
            string borrar;

            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    while (!reader.EndOfStream)
                    {
                        linea = reader.ReadLine();
                        array = linea.Split(';');
                        Inventario inv = new Inventario();
                        foreach (string item in array)
                        {
                            if (item.Contains("/C/"))
                            {
                                borrar = item.Remove(0, 3);
                                datos = borrar.Split(',');
                                int.TryParse(datos[0], out int cantidad);
                                int.TryParse(datos[2], out int dureza);
                                cubo = new Cubo(Cubo.DevuelveEnumM(datos[1]), dureza, cantidad);
                                inv.ListaElementos.Add(cubo);
                            }

                            if (item.Contains("/H/"))
                            {
                                borrar = item.Remove(0, 3);
                                datos = borrar.Split(',');
                                int.TryParse(datos[0], out int cantidad);
                                int.TryParse(datos[3], out int durabilidad);
                                tool = new(Herramienta.DevuelveEnumH(datos[2]), Herramienta.DevuelveEnumM(datos[1]), cantidad, durabilidad);
                                inv.ListaElementos.Add(tool);
                                
                            }

                            if (item.Contains("/J/"))
                            {
                                borrar = item.Remove(0, 3);
                                datos = borrar.Split(',');
                                int.TryParse(datos[0], out int id);
                                int.TryParse(datos[2], out int capacidad);
                                inv.Capacidad = capacidad;
                                lista.Add(new Jugador(id,datos[1],inv));
                            }
                        }
                    }
                    jugadores.Jugadores = lista;
                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isOk;
        }

        public static bool GuardarXml(string archivo, Wiki wiki)
        {
            bool isOk = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Wiki));

                    serializer.Serialize(writer, wiki);
                    isOk = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return isOk;
        }

        /// <summary>
        /// Leer archivo serializado xml de jugadores
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static Wiki LeerXml(string archivo)
        {
            Wiki lista;
            try
            {
                using (XmlTextReader writer = new XmlTextReader(archivo))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Wiki));

                    lista = (Wiki)deserializer.Deserialize(writer);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }


}

