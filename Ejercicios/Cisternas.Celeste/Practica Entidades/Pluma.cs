using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pluma
    {
        #region Atributos
        private string marca;
        private Tinta tinta;
        private int cantidad;
        #endregion Atributos

        #region Constructores
        public Pluma() : this("Sin Marca", null, 1)//por defecto
        { }
        public Pluma(string m) : this(m, null, 1)
        { }
        public Pluma(Tinta t) : this("Sin Marca", t, 1)
        { }
        public Pluma(int c) : this("Sin Marca", null, c)
        { }
        public Pluma(string m, Tinta t) : this(m, t, 0)
        { }
        public Pluma(Tinta t, int c) : this("Sin Marca", t, c)
        { }
        public Pluma(string m, int c) : this(m, null, c)
        { }
        public Pluma(string m, Tinta t, int c)
        {
            this.marca = m;
            this.tinta = t;
            this.cantidad = c;
        }
        #endregion Constructores
        private string Mostrar()
        {
            return "hola";
        }
        #region Sobrecarga de operadores
        public static bool operator == (Pluma p1,Tinta t1)
        {
            bool rta;
            if(p1.tinta==t1)
            {
                rta = true;
            }
            else
            {
                rta = false;
            }
            return rta;
        }
        public static bool operator != (Pluma p1, Tinta t1)
        {
            return !(p1 == t1);
        }
        public static Pluma operator ++ (Pluma p1, Tinta t1)
        {
            Pluma rta=p1;
            if(p1.tinta==t1)
            {
                rta.cantidad=p1.cantidad++;
            }
            return rta;
        }
        public static Pluma operator -- (Pluma p1, Tinta t1)
        {
            Pluma rta = p1;
            if (p1.tinta == t1)
            {
                rta.cantidad = p1.cantidad++;
            }
            return rta;
        }
        #endregion Sobrecarga de operadores
        public static implicit operator string (Pluma p1)
        {
            return "hola";
        }

        //            implicit (Pluma):string //se relaciona con mostrar
    }
}
