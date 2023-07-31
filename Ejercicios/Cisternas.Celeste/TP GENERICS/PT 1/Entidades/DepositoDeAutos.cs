using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DepositoDeAutos
    {
        int _capacidadMaxima;
        List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Auto a)
        {
            int contador = 0;
            int index=-1;
            foreach(Auto item in this._lista)
            {
                if(item == a)
                {
                    index = contador; //this._lista.IndexOf(a);//si quiero usar indexof tengo que sobreescribir el equals
                    break;
                }
                contador++;
                //else
                //{
                //    contador++;
                //}
            }
            return index;
        }

        #region SOBRECARGA
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool isOk = false;
            if(d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                isOk = true;
            }
            return isOk;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool isOk = false;
            int index = d.GetIndice(a);

            if(index!=-1)
            {
                d._lista.RemoveAt(index);
                isOk = true;
            }
            return isOk;
        }
        #endregion SOBRECARGA

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad Max: {this._capacidadMaxima}");
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
