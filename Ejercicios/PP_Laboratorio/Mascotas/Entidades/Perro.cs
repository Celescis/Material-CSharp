using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region ATRIBUTOS
        int edad;
        bool esAlfa;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Perro(string nombre, string raza):this(nombre,raza,0,false)
        {
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion CONSTRUCTOR

        #region METODOS
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            if(this.esAlfa)
            {
                sb.Append($"perro - {base.DatosCompletos()}, alfa de la manada, edad {this.edad}");
            }
            else
            {
                sb.Append($"perro - {base.DatosCompletos()}, edad {this.edad}");
            }
            return sb.ToString();
        }

        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool isOk = false;

            if(p1 == (Mascota)p2 && p1.edad == p2.edad)
            {
                isOk = true;
            }
            return isOk;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }
        #endregion SOBRECARGA

        #region SOBREESCRIBIR
        //public override bool Equals(object obj)
        //{
        //    if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        Perro p = (Perro)obj;
        //        return this == p;
        //    }
        //}
        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Perro)
            {
                isOk = (Perro)obj == this;
            }

            return isOk;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion SOBREESCRIBIR
    }
}
