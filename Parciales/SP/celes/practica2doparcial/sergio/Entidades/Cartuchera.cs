using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        //Crear, en class library, la clase Cartuchera<T> -> restringir para que sólo lo pueda usar Utiles 
        //o clases que deriven de Utiles.
        //atributos: capacidad:int y elementos:List<T> (TODOS protegidos)        
        //Propiedades:
        //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
        //PrecioTotal:(sólo lectura) retorna el precio total de la cartuchera (la suma de los precios de sus elementos).
        //Constructor
        //Cartuchera(), Cartuchera(int); 
        //El constructor por default es el único que se encargará de inicializar la lista.
        //Métodos:
        //ToString: Mostrará en formato de tipo string: 
        //el tipo de cartuchera, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
        //de todos los elementos contenidos en la misma. Reutilizar código.
        //Sobrecarga de operadores:
        //(+) Será el encargado de agregar elementos a la cartuchera, 
        //siempre y cuando no supere la capacidad máxima de la misma.

        protected int capacidad;
        protected List<T> elementos;
        public delegate void EventoPrecio(object sender, EventArgs e);
        public EventoPrecio PrecioSuperado;

        public List<T> Elementos { get { return this.elementos; } }

        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (T item in elementos)
                {
                    total += item.precio;
                }

                return total;
            }
        }

        public Cartuchera()
        {
            elementos = new List<T>();
        }

        public Cartuchera(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendFormat("Cartuchera de {0}\nCapacidad: {1}\nCantidad de elementos {2}\nPrecio total {3}\nLista de elementos:\n",
                typeof(T).Name, this.capacidad, this.elementos.Count, this.PrecioTotal); 
            foreach (Utiles item in this.elementos)
            {
                st.AppendLine(item.ToString());
            }

            return st.ToString();
        }

        public static Cartuchera<T> operator +(Cartuchera<T> l, T u)
        {
            if (l.elementos.Count < l.capacidad && l != null)
            {
                l.elementos.Add(u);
            }
            else if (l.elementos.Count >= l.capacidad)
            {
                throw new CartucheraLlenaException();
            }

            if (l.PrecioTotal > 85 && l.PrecioSuperado != null)
            {
                l.PrecioSuperado.Invoke(l, EventArgs.Empty);
            }

            return l;
        }
    }
}
