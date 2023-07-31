using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class CasaDeMusica
    {
        #region ATRIBUTOS
        private List<Instrumento> lista;
        private int cantidadMaxima;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public CasaDeMusica()
        {
            this.lista = new List<Instrumento>();
        }
        public CasaDeMusica(int cantidadMaxima)
        {
            this.cantidadMaxima = cantidadMaxima;
        }
        #endregion CONSTRUCTOR

        #region METODO
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Instrumento instrumento in lista)
            {
                sb.AppendLine(instrumento.Mostrar());
            }

            return sb.ToString();
        }
        #endregion METODO

        #region SOBRECARGA
        public static bool operator == (CasaDeMusica cm, Instrumento i)
        {
            //return cm.lista.Contains(i);
            bool isOk = false;

            foreach  (Instrumento j in cm.lista)
            {
                if(j==i)
                {
                    isOk = true;
                }
            }

            return isOk;
        }
        public static bool operator != (CasaDeMusica cm, Instrumento i)
        {
            return !(cm==i);
        }
        public static CasaDeMusica operator + (CasaDeMusica cm, Instrumento i)
        {
            if(cm!=i && cm.cantidadMaxima<cm.lista.Count)
            {
                cm.lista.Add(i);
            }

            return cm;
        }
        public static CasaDeMusica operator - (CasaDeMusica cm, Instrumento i)
        {
            if(cm==i)
            {
                cm.lista.RemoveAt(cm.lista.IndexOf(i));
            }
            return cm;
        }

        #endregion SOBRECARGA
    }
}
