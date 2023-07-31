using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";
            int numero;
            double cubo;
            double cuadrado;
            /* 2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
             * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!"
             * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
             */
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
            }
            else
            {
                cubo = Math.Pow(numero, 3);
                cuadrado = Math.Pow(numero, 2);
                Console.WriteLine("El numero al cuadrado es {0} y al cubo es {1}", cuadrado, cubo);
            }
            Console.ReadKey();
        }
    }
}
