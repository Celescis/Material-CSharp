using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region ATRIBUTOS
        string nombre;
        string raza;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.nombre} - {this.raza}");
            return sb.ToString();
        }
        protected abstract string Ficha();
        #endregion METODOS

        #region CONSTRUCTOR
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion CONSTRUCTOR

        #region SOBRECARGA
        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return (m1.Nombre == m2.Nombre && m1.Raza == m2.Raza);
        }
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion SOBRECARGA
    }
}
