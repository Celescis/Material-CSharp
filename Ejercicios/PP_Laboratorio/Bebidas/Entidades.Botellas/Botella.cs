using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public abstract class Botella
    {
        #region ATRIBUTOS
        protected int capacidad;
        protected int contenido;
        protected string marca;
        protected double precio;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public double PorcentajeContenido
        //porcentaje actual del contenido de la botella
        {
            get
            {
                return (double)((this.contenido * 100) / this.capacidad);//revisar si funciona bien
            }
        }
        public abstract double Ganancia
        {
            get; //la ganancia de la botella
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Botella(string marca, double precio) : this(marca, precio,1000)
        {
        }
        public Botella(string marca, double precio, int capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
        }
        /*
        public Botella(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = 1000;
            this.contenido = 1000;
        }
        public Botella(string marca, double precio, int capacidad) : this(marca, precio)
        {
            this.capacidad = capacidad;
        }
        */
        #endregion CONSTRUCTORES

        #region METODOS
        //metodos abstractos no llevan cuerpo
        protected abstract void ServirMedida();//descuenta del contenido de la botella una unidad de medida.
        private static string ObtenerDatos(Botella b)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Marca: {b.marca}\nContenido: {b.contenido}\nCapacidad: {b.capacidad}\nPrecio: {b.precio}");

            return sb.ToString();
        }
        public override string ToString()//polimorfismo con metodo estatico obtener datos
        {
            return Botella.ObtenerDatos(this);
        }
        #endregion METODOS

        #region SOBRECARGA
        public static explicit operator String (Botella b)
        {
            return b.marca;
        }
        public static bool operator == (Botella b1, Botella b2)
        {
            bool isOk = false;
            
            if(b1.marca == b2.marca && b1.capacidad == b2.capacidad)
            {
                isOk = true;
            }
            return isOk;
        }
        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }
        // Decremento.Saca de la botella que recibe como parámetro una unidad de medida. Reutilizar código.
        public static Botella operator --(Botella b)
        {
            b.ServirMedida();//revisar
            return b;
        }
        #endregion SOBRECARGA
    }
}
