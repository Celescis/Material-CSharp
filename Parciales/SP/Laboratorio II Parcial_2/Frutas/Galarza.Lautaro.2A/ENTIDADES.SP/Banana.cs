using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Banana :Fruta
    {
        protected string _paisOrigen;

        public string Nombre
        {
            get
            {
                return "Banana";
            }


        }

        public string PaisOrigen
        {
            get
            {
                return this._paisOrigen;
            }

            set
            {
                this._paisOrigen = value;
            }

        }


        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public Banana()
        {

        }

        public Banana(string color, double peso, string pais) : base(color, peso)
        {
            this._paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            return "Nombre: " + this.Nombre + base.FrutaToString() + " Pais de origen: " + this._paisOrigen;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
