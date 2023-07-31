using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Sello
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola Mundo";
            Sello.Imprimir();

            Sello.mensaje = "Hola Mundo con color";
            Sello.color = ConsoleColor.Magenta;
            Sello.ImprimirEnColor();
            Sello.Imprimir();

            Console.ReadKey();
        }
    }
}

