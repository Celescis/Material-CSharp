using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2021
{
    public sealed class Nieta: Hija
    {
        private Padre padre;


        public Nieta(DateTime t,int e,string c,double d,Padre p):base(t,e,c,d)
        {
            this.padre = p;
        }

        public void Algo()
        {
            
        }

        public void MostrarNieta()
        {
            base.Mostrar();
            Console.WriteLine("Atributo padre: " + this.padre);

        }
    }
}
