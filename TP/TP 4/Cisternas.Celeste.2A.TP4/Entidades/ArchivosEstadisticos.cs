using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class ArchivosEstadisticos
    {
        static readonly string pathBase;
        
        static ArchivosEstadisticos()
        {
            pathBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Informes WikiCrafteo\";
        }
        public static bool ImprimirPorcentaje(this Wiki lista, int boton, string seleccion)
        {
            bool isOk = true;
            double porcentaje = 0;
            string tipo = "";
            string nombre = "";

            switch (boton)
            {
                case 1:
                    porcentaje = lista.PorcentajeConInventarioLleno();
                    tipo = "LLENO";
                    nombre = @"Porcentaje Inventario lleno";
                    break;
                case 2:
                    porcentaje = lista.PorcentajeDeDiamanteEnInventarios();
                    tipo = "DE DIAMANTE";
                    nombre = @"Porcentaje Inventario de diamantes";
                    break;
                case 3:
                    porcentaje = lista.PorcentajeDePiedraEnInventarios();
                    tipo = "DE PIEDRA";
                    nombre = @"Porcentaje Inventario de piedra";
                    break;
                case 4:
                    porcentaje = lista.PorcentajeDeMaderaEnInventarios();
                    tipo = "DE MADERA";
                    nombre = @"Porcentaje Inventario de madera";
                    break;
            }

            string dato = $"{DateTime.Now}\nPORCENTAJE DE JUGADORES CON INVENTARIO {tipo} ACTUALMENTE: {porcentaje}%";
            string pathArchivo = pathBase;

            if (!Directory.Exists(pathArchivo))
            {
                Directory.CreateDirectory(pathArchivo);
            }

            try
            {
                switch (seleccion)
                {
                    case "Txt":
                        pathArchivo += nombre + ".txt";
                        using (StreamWriter sw = new StreamWriter(pathArchivo, true))
                        {
                            sw.Write(dato);
                        }
                        break;
                    case "Xml":
                        pathArchivo += nombre + ".xml";
                        using (XmlTextWriter writer = new XmlTextWriter(pathArchivo , Encoding.UTF8))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(string));
                            
                            serializer.Serialize(writer, dato);
                        }
                        break;
                    case "Json":
                        pathArchivo += nombre +".json";
                        JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                        jsonSerializerOptions.WriteIndented = true;

                        string json = JsonSerializer.Serialize<string>(dato, jsonSerializerOptions);

                        File.WriteAllText(pathArchivo , json);
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isOk = false;
            }

            return isOk;
        }
    }
}
