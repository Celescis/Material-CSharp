using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            //7.Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
            //calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema
            //con DateTime.Now).
            //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.

            DateTime fecha;
            DateTime ahora = DateTime.Now;
            TimeSpan vivido;

            Console.WriteLine("Ingrese fecha de nacimiento (dia-mes-año): ");

            while(!DateTime.TryParse(Console.ReadLine(),out fecha))
            {
                Console.WriteLine("Error ingrese una fecha correcta (dia-mes-año): ");
            }

            vivido = ahora - fecha;

            Console.WriteLine("Cantidad de dias vividos: {0}",vivido.Days);
            Console.ReadKey();
        }
    }
}
