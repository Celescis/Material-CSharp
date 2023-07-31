using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        protected int capacidad;
        protected List<T> elementos;
        public delegate void EventoPrecio(object sender, EventArgs e);
        public event EventoPrecio precioSuperado;//mismo nombre de delegado que de evento
        public List<T> Elementos
        {
            get
            {
                return this.elementos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (T item in elementos)
                {
                    total += item.precio;//todos heredan precio
                }
                return total;
            }
        }

        private Cartuchera()
        {
            this.elementos = new List<T>();
        }
        public Cartuchera(int cantidad)
            : this()
        {
            this.capacidad = cantidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {typeof(T).Name}");
            sb.AppendLine($"Capacidad: {this.capacidad}");
            sb.AppendLine($"Cantidad de elementos: {this.elementos.Count}");
            sb.AppendLine($"Precio total: {this.PrecioTotal}");
            sb.AppendLine("Listado de elementos:\n");
            foreach (T item in this.elementos)
            {
                sb.AppendLine(item.ToString());
                sb.AppendLine("__________________________________");
            }
            return sb.ToString();
        }
        //Agregar un elemento a la cartuchera de útiles, al superar la cantidad máxima, 
        //lanzará un CartucheraLlenaException (diseñarla), cuyo mensaje explicará lo sucedido.

        //Si el precio total de la cartuchera supera los 85 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cartuchera. 
        //Adaptar la sobrecarga del operador +, para que lance el evento, según lo solicitado.
        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera, T util)
        {
            Cartuchera<T> catu = new Cartuchera<T>();
            catu = cartuchera;
            double total = util.precio + cartuchera.PrecioTotal;

            if (catu.elementos.Count < catu.capacidad)
            {
                catu.elementos.Add(util);
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            if (total > 85)
            {
                PrecioSuperadoEventArgs precioAlcanzado = new PrecioSuperadoEventArgs();
                precioAlcanzado.PrecioAlcanzado = total;
                if(cartuchera.precioSuperado!=null)
                {
                    cartuchera.precioSuperado(cartuchera, precioAlcanzado);//evento en clase caruchera asi que es cartuchera., se provoco aca
                }
            }
            return catu;
        }

        public class PrecioSuperadoEventArgs : EventArgs
        {
            public double PrecioAlcanzado { get; set; }
        }
    }
}
