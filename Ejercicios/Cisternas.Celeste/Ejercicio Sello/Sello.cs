using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Sello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            
            return ArmarFormatoMensaje(Sello.mensaje);
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
        }
        private static string ArmarFormatoMensaje(string mensaje)
        {
            string linea="";

            for (int i = 0; i < mensaje.Length+2; i++)
            {
                linea = linea.Insert(i, "*");
            }
            mensaje = mensaje.Insert(0, "*");
            mensaje = mensaje.Insert(mensaje.Length, "*");
            Console.WriteLine(linea);
            Console.WriteLine(mensaje);
            Console.WriteLine(linea);
            return mensaje;
        }
    }
}
