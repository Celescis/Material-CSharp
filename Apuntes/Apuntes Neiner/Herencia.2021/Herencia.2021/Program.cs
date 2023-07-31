using System;

namespace Herencia._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Padre p = new Padre(2, "padre", 2.3);

            Hija h1 = new Hija(DateTime.Now,2,"hija",3.4);

            Nieta n = new Nieta(DateTime.Now, 4, "nieta", 5.5,p);

            

            h1.Mostrar();
            Console.WriteLine("");
            n.MostrarNieta();
         

            Console.ReadKey();
        }
    }
}
