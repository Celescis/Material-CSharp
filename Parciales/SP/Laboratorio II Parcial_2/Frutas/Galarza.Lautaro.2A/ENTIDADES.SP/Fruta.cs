using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }



        public string Color
        {
            get
            {
                return this._color;
            }

            set
            {
                this._color = value;
            }

        }

        public double Peso
        {
            get
            {
                return this._peso;
            }

            set
            {
                this._peso = value;
            }

        }




        public Fruta()
        {

        }

        public Fruta(string color, double precio)
        {
            this._color = color;
            this._peso = precio;
        }

        protected virtual string FrutaToString()
        {
            string carozo = "-No tiene Carozo-";

            if (TieneCarozo)
            {
                carozo = "-Tiene Carozo-";
            }

            return " Color: " + this._color + " Peso: " + this._peso + carozo;
        }
    }
}
