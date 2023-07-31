using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {


            Entidades.Programa programa = new Entidades.Programa();
            string[] test = { "", "" };
            programa.Main(test); // HACE FALTA CAMBIAR A PUBLIC EL METODO MAIN DE PROGRAM
            Console.ReadKey();



        }
    }
}
