using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        int _capacidadMaxima;
        List<Cocina> _lista;

        //CONSTRUCTOR
        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        //SOBRECARGA
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool isOk = false;
            int index = d.GetIndice(c);

            if(index!=-1)
            {
                d._lista.RemoveAt(index);
                isOk = true;
            }
            

            return isOk;
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool isOk = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                isOk = true;
            }
            return isOk;
        }
        //METODOS
        public bool Agregar(Cocina c)
        {
            return this + c;
        }
        public bool Remover(Cocina c)
        {
            return this - c;
        }

        private int GetIndice(Cocina c)
        {
            int indice = -1;
            foreach (Cocina item in this._lista)
            {
                if(item == c)
                {
                    indice = this._lista.IndexOf(item);
                    break;
                }
            }
            return indice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad máxima: {this._capacidadMaxima}");
            sb.AppendLine("Listado de Cocinas");
            foreach (Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

    }
}
