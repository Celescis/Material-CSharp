using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Celes";
            alumno1.apellido = "Cisternas";
            alumno1.legajo = 100;

            alumno2.nombre = "July";
            alumno2.apellido = "Nieva";
            alumno2.legajo = 101;

            alumno3.nombre = "Maty";
            alumno3.apellido = "Prutscher";
            alumno3.legajo = 102;

            alumno1.Estudiar(4,4);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());

            alumno2.Estudiar(2,7);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());

            alumno3.Estudiar(1, 1);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();

        }

    }
}
