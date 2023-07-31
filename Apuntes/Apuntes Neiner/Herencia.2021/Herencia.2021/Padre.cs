using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2021
{
     public class Padre 
    {
        public int entero;
        protected string cadena;
        private double doble;


        /*
        public Padre()
        {
        
        }*/

        public Padre(int e, string c, double d)
        {
            this.entero = e;
            this.cadena = c;
            this.doble = d;
        }



    }
}
