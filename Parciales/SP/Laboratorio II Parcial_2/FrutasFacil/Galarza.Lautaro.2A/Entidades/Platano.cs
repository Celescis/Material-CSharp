using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Platano:Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
                
        }

        public string Tipo
        {
            get
            {
                return "Platano";
            }
         
        }

        public Platano()
        {

        }

        public Platano(float peso,ConsoleColor color, string pais):base(color,peso)
        {
            this.paisOrigen = pais;

        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + " Pais: " + this.paisOrigen;
        }

        public override string ToString()
        {
            return this.FrutaToString(); 
        }




    }
}
