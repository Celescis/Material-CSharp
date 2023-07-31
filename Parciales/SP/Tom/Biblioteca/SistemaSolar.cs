using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar<T> where T : Planeta
    {
        public List<T> lista;
        private int capacidad;

        public SistemaSolar()
        {
            this.lista = new List<T>();
        }

        public SistemaSolar(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        //protected int Capacidad { get => capacidad; set => capacidad = value; }

        public bool Agregar(T planeta)
        {
            if(this.lista.Count < this.capacidad)
            {
                this.lista.Add(planeta);
                return true;
            }
            else
            {       
                throw new NoHayLugarException();
            }
        }
    }
}
