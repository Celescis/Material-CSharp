using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        int _capacidadMaxima;
        List<T> _lista;

        //CONSTRUCTOR
        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        //METODOS
        int GetIndice(T a)
        {
            int index = -1;

            foreach (T b in this._lista)
            {
                if(b.Equals(a))
                {
                    index = this._lista.IndexOf(a);
                    break;
                }
            }

            return index;
        }

        public bool Agregar(T a)
        {
            return this+a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this._capacidadMaxima}");
            sb.AppendLine($"Listado de {typeof(T).Name}");//PARA PONER EL NOMBRE DEL TIPO
            foreach(T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        //SOBRECARGA
        public static bool operator + (Deposito<T> d,T a)
        {
            bool isOk= false;

            if(d._capacidadMaxima>d._lista.Count())
            {
                d._lista.Add(a);
                isOk = true;
            }

            return isOk;
        }
        public static bool operator - (Deposito<T> d, T a)
        {
            bool isOk = false;
            int indice = d.GetIndice(a);

            if (indice!=-1)
            {
                d._lista.RemoveAt(indice);
                isOk = true;
            }

            return isOk;
        }
    }
}
