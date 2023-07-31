using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Persona
    {

        public Persona()
        {

        }



        public Persona(int edad)
        {
            this.Edad = edad;
        }

        public int Edad { get; set; }


        public override string ToString()
        {
            return "Edad: " + this.Edad; 
        }


    }
}
