using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            /* 3. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */

            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {


                for (int i = numero - 1; i > 0; i--)
                {
                    bool isOk = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isOk = false;
                            break;
                        }
                    }

                    if (isOk)
                    {
                        Console.WriteLine("Los numeros primos antes de {0} son: {1}", numero, i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
