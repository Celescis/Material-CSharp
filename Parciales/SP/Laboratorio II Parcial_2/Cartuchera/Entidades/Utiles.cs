using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Utiles
    {
        public string marca;
        public double precio;

        public abstract bool PrecioCuidados { get; }

        public Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;

        }

        protected virtual string UtilesToString()
        {
            return "Marca: " + marca + "\nPrecio: " + precio;
        }

        public override string ToString()
        {
            return UtilesToString();
        }

    }
}
