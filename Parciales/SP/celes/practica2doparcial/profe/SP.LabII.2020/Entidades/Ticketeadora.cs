using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{        //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
         //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
         //Se deben acumular los mensajes. 
         //El archivo se guardará con el nombre 'tickets.log' en la carpeta 'Mis documentos' del cliente.
         //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
         //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano 
         //indicando si se pudo escribir o no.
    public class Ticketeadora<T> where T : Utiles//nenecsito decirle que es T
    {
        public static bool ImprimirTicket(Cartuchera<T> t)//paso cartuchera<T> xq es la que tiene PrecioTotal//static xq dice que es de clase
        {
            bool rtn= true;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                using (StreamWriter sw = new StreamWriter(path + @"\tickets.log", true))
                {
                    sw.WriteLine($"{DateTime.Now}");
                    sw.WriteLine($"{t.PrecioTotal}");
                }

            }
            catch (Exception)
            {
                rtn=false;
            }


            return rtn;
        }
    }
}
