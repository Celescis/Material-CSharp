using System;
using System.Text;

namespace LaLiberiaPP
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor { get; }
        public virtual bool HayStock
        {
            get
            {
             if(stock > 0 && importe > 0)
                {
                    return true;
                }
             else
                {
                    return false;
                }
            }
        }

        public float Importe
        {
            get
            {
                return importe;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            string esColor = EsColor ? "SI" : "NO";

          //sb.AppendFormat("Nombre: {0}{1}", nombre, Environment.NewLine);
            sb.AppendLine($"Nombre: {nombre}{Environment.NewLine}");
            sb.Append($"Stock: {Stock.ToString()}{Environment.NewLine}");
            sb.Append($"Es color: {esColor}{Environment.NewLine}");
            sb.AppendLine($"Valor: ${Importe}");

            return sb.ToString();
        }

        public Publicacion(string nombre):this(nombre, 0, 0)
        {
        }

        public Publicacion(string nombre, int stock):this(nombre, stock, 0)
        {
        }

        public Publicacion(string nombre, int stock, float importe)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.importe = importe;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
