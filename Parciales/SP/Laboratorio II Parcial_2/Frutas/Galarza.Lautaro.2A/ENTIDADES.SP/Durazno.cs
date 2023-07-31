using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Durazno:Fruta
    {
        protected int _cantPelusa;

        public string Nombre
        {
            get
            {
                return "Durazno";
            }

        }



        public int CantidadPelusa
        {
            get
            {
                return this._cantPelusa;
            }
            set
            {
                this._cantPelusa = value;
            }

        }


        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Durazno()
        {

        }

        public Durazno(string color, double peso, int cantPelusa) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        protected override string FrutaToString()
        {
            return "Nombre: " + this.Nombre + base.FrutaToString() + " Cantidad de pelusa: " + this._cantPelusa;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

    }
}
