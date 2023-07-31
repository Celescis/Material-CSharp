using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Manzana:Fruta
    {

        public string distribuidora;

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }

        }

        public string Tipo
        {
            get
            {
                return "Manzana";
            }

        }

        public Manzana()
        {

        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(color, peso)
        {
            this.distribuidora = distribuidora;

        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + " Distribuidora: " + this.distribuidora;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

    }
}
