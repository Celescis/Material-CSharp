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

        public abstract bool PreciosCuidados { get; }

        public Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public Utiles() { }

        protected virtual string UtilesToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendFormat("Marca: {0}\nPrecio: {1}", this.marca, this.precio);

            return st.ToString();
        }

        public override string ToString()
        {
            return this.UtilesToString();

        }
    }
}
