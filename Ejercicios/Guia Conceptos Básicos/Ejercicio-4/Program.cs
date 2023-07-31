using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";

            // 4.Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            //(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            //Nota: Utilizar estructuras repetitivas y selectivas.
            int i = 0;
            int perfecto = 0;
            int suma;

            do
            {
                i++;//incremento el numero a analizar
                suma = 0;//reinicio la suma
                for(int j=1; j<i ;j++)//divisores
                {
                    if (i % j == 0)
                    {
                        suma += j;
                    }
                }
                if (suma == i)//si la suma de divisores es igual al numero 
                {
                    Console.WriteLine("El numero {0} es un numero perfecto",i);
                    perfecto++;
                }

            } while (perfecto!=4);

            Console.ReadKey();

        }
    }
}
