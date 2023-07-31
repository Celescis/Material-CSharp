using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2021
{
    public class Hija : Padre
    {
        public DateTime tiempo;
        protected string cadenita;

        public Hija(DateTime t, int e, string c, double d):base(e,c,d)
        {
            this.tiempo = t;
        }

        public void Mostrar()
        {
            Console.WriteLine("Entero: " + base.entero);
            Console.WriteLine("Cadena: " + base.cadena);
            Console.WriteLine("Double: no es accesible desde la derivada");
            Console.WriteLine("DateTime derivada: " + this.tiempo);
        }

        protected void Falla(Padre p)
        {
            //falla
            //p.cadena = "hola";
            
        }


    }
}
