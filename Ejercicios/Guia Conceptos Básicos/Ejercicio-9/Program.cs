using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";
            //9.Escribir un programa que imprima por pantalla una pirámide como
            //la siguiente:
            //            *
            //            ***
            //            *****
            //            *******
            //            *********
            //            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            //ejemplo anterior la altura ingresada fue de 5.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            int numero;
            string filas="*";

            Console.WriteLine("Ingrese un numero entero positivo: ");
            while(!int.TryParse(Console.ReadLine(),out numero) || numero < 0)
            {
                Console.WriteLine("Error, debe ingresar un numero entero positivo: ");
            }

            for (int i = 0; i < numero ; i++)
            {
                Console.WriteLine("{0}",filas);//me añade el salto de linea con *
                filas = filas.Insert(i, "**");
            }

            Console.ReadKey();
        }
    }
}
