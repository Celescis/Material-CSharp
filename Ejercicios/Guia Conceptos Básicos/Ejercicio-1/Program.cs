using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int numero5;
            int max;
            int min;
            Single promedio;

            /*1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

            Console.WriteLine("Ingrese 5 numeros: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());
            numero5 = int.Parse(Console.ReadLine());

            //MAXIMO
            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4 && numero1 > numero5)
            {
                max = numero1;
            }
            else if (numero2 > numero3 && numero2 > numero4 && numero2 > numero5)
            {
                max = numero2;
            }
            else if (numero3 > numero4 && numero3 > numero5)
            {
                max = numero3;
            }
            else if (numero4 > numero5)
            {
                max = numero4;
            }
            else
            {
                max = numero5;
            }

            //MINIMO
            if (numero1 < numero2 && numero1 < numero3 && numero1 < numero4 && numero1 < numero5)
            {
                min = numero1;
            }
            else if (numero2 < numero3 && numero2 < numero4 && numero2 < numero5)
            {
                min = numero2;
            }
            else if (numero3 < numero4 && numero3 < numero5)
            {
                min = numero3;
            }
            else if (numero4 < numero5)
            {
                min = numero4;
            }
            else
            {
                min = numero5;
            }
            promedio = ((Single)(numero1 + numero2 + numero3 + numero4 + numero5)) / 5;
            Console.WriteLine("El valor maximo es {0}, el valor minimo es {1}, el promedio de los 5 numeros es {2:N2}", max, min, promedio);//falta formato promedio
            Console.ReadKey();
        }
    }
}
