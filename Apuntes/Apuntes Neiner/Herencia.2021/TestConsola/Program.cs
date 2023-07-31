using System;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
           Escuela escuela = new Escuela(4);

           Profesor p = new Profesor("Hugo", "Lopez", 23042019, 20000);

           Alumno a = new Alumno("Juan", "Perez", 34213423, 7, 7, 10);

           Alumno a2 = new Alumno("Rodrigo", "Mendez", 28532034, 4, 6, 10);

           Alumno a3 = new Alumno("Emanuel", "Gutierrez", 32098123);

            escuela += p;
            escuela += a;
            escuela += a2;
            escuela += a3;

            Console.WriteLine(escuela.MostrarEscuela());

            Console.ReadKey();
        }
    }
}
