using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";

            //5.un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
            //dos grupos de números, cuyas sumas son iguales.
            //el primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) 
            //cuyas sumas son ambas iguales a 15.el segundo centro numérico es el 35, el cual separa la lista(1 a
            //49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
            //se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
            //usuario ingrese por consola.
            //nota: utilizar estructuras repetitivas y selectivas

            int numero;
            bool centro;
            int sumaUno;
            int sumaDos;
            Console.WriteLine("Ingrese un numero mayor a 0: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 0)
            {
                Console.WriteLine("Error, ingrese un numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());
            }

            do
            {
                centro = false;
                sumaUno = 0;
                for(int i=1;i<=numero;i++)
                {
                    sumaUno += i;
                    sumaDos = 0;
                    for (int j=i+2;j<=numero;j++)
                    {
                        sumaDos += j;
                        if(sumaUno==sumaDos)
                        {
                            Console.WriteLine("El numero centro es: {0}",i+1);//El siguiente numero al i es el centro
                            centro = true;
                            break;
                        }
                    }
                }
            } while (!centro);

            Console.ReadKey();

        }
    }
}
