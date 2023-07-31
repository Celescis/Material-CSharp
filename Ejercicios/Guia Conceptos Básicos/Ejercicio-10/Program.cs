using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            //10.partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            //una pirámide como la siguiente:
            //    *
            //   ***
            //  *****
            // *******
            //*********
            //nota: utilizar estructuras repetitivas y selectivas.
            int numero;
            string sello="*";
            string final="**";

            Console.WriteLine("Ingrese un numero positivo: ");
            while(!int.TryParse(Console.ReadLine(),out numero) || numero<=0)
            {
                Console.WriteLine("Error, ingrese un numero positivo: ");
            }

            for(int i=0;i<numero;i++)
            {
                for(int j=0;j<(numero-i);j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("{0}", sello);
                sello = sello.Insert(i, final);

            }
            Console.ReadKey();
        }
    }
}
