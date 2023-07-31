using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Ticketeadora<T> where T : Utiles
    {
        //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
        //Se deben acumular los mensajes. 
        //El archivo se guardará con el nombre 'tickets.log' en la carpeta 'Mis documentos' del cliente.
        //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
        //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano 
        //indicando si se pudo escribir o no.

        public static bool ImprimirTicket(Cartuchera<T> car)
        {
            bool rta = true;

            string path = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\tickets.log";

            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter f = new StreamWriter(path, false))
                    {
                        f.Write("Fecha: ");
                        f.WriteLine(System.DateTime.Now);
                        f.Write("Precio Total: ");
                        f.WriteLine(car.PrecioTotal);
                        f.WriteLine("---------------------------------");
                    }
                }
                catch
                {
                    rta = false;
                }
            }
            else
            {
                try
                {
                    using (StreamWriter f = new StreamWriter(path, true))
                    {
                        f.Write("Fecha: ");
                        f.WriteLine(System.DateTime.Now);
                        f.Write("Precio Total: ");
                        f.WriteLine(car.PrecioTotal);
                        f.WriteLine("---------------------------------");
                    }
                }
                catch
                {
                    rta = false;
                }

            }


            return rta;
        }
    }
}
