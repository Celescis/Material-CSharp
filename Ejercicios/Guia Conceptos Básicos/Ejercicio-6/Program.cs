using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            //6.Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
            //también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).
            int anoUno;
            int anoDos;

            Console.WriteLine("Ingrese el inicio del rango de años: ");

            while (!int.TryParse(Console.ReadLine(), out anoUno) || anoUno < 1000)//primer año mayor a 1000
            {
                Console.WriteLine("Error, reingrese el año a analizar: ");
            }

            Console.WriteLine("Ingrese el fin del rango de años: ");

            while (!int.TryParse(Console.ReadLine(), out anoDos) || anoDos < 1000 || anoDos<=anoUno)//segundo año mayor al primer año
            {
                Console.WriteLine("Error, reingrese el año a analizar: ");
            }

            Console.WriteLine("Es bisiesto: ");

            for(int i= anoUno-1;i<=anoDos;i++)
            {
                if(i % 400 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                else
                {
                    if (i % 100 != 0 && i % 4 == 0)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
