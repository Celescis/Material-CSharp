using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        protected int capacidad;
        protected List<T> elementos;

        public delegate void DelegadoEventoPrecio(object sender, EventArgs e);
        public event DelegadoEventoPrecio EventoPrecio;

        public List<T> Elementos { get { return this.elementos; } }

        public double PrecioTotal
        {
            get
            {
                double precioTotal = 0;
                foreach (T item in this.Elementos)
                {
                    precioTotal += item.precio;

                }
                return precioTotal;
            }
        }

        public Cartuchera()
        {
            this.elementos = new List<T>();
        }

        public Cartuchera(int capacidadCartu) : this()
        {
            this.capacidad = capacidadCartu;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Tipo: " + typeof(T).Name);
            cadena.AppendLine("Capacidad: " + this.capacidad);
            cadena.AppendLine("Cantidad total: " + this.elementos.Count);
            cadena.AppendLine("Precio Total: " + this.PrecioTotal);
            cadena.AppendLine("\nLista de utiles: ");

            foreach (T item in this.elementos)
            {
                cadena.AppendLine(item.ToString()+ "\n");
                
            }
            return cadena.ToString();
        }

        public static Cartuchera<T> operator +(Cartuchera<T> c, T u)
        {
            if (c.capacidad > c.Elementos.Count)
            {
                c.Elementos.Add(u);
                if (c is Cartuchera<Goma>)
                {
                    if (c.PrecioTotal > 85)
                    {
                        c.EventoPrecio(c, new EventArgs());
                    }
                }
            }
            else
            {
                throw new CartucheraLlenaException();

            }

            return c;
        }
    }
}

