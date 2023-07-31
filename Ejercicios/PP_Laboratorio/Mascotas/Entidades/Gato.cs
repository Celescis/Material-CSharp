using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region CONSTRUCTOR
        public Gato(string nombre, string raza):base(nombre, raza)
        {}
        #endregion CONSTRUCTOR
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"gato - {base.DatosCompletos()}");

            return sb.ToString();//revisar si usa la sobrecarga 
        }
        #region SOBRECARGA
        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((Mascota)g1==g2);
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1==g2);
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
        //        Gato g = (Gato)obj;
        //        return this == g;
        //    }
        //}
        public override bool Equals (object obj)
        {
            bool isOk = false;
            if(obj is Gato)
            {
                isOk = (Gato)obj==this;
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
