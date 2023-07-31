using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Instrumento
    {
        #region ATRIBUTO
        protected int codigo;
        protected string marca;
        #endregion ATRIBUTO

        #region CONSTRUCTOR
        public Instrumento(int codigo, string marca)
        {
            this.codigo = codigo;
            this.marca = marca;
        }
        public Instrumento(int codigo, string marca, EClasificacion eClasificacion) : this(codigo, marca)
        {
            this.Clasificacion = eClasificacion;
        }
        #endregion CONSTRUCTOR
        //averiguar xq get; y set; en propiedad
        #region PROPIEDAD
        protected EClasificacion Clasificacion
        {
            get;
            set;
        }
        #endregion PROPIEDAD
        #region METODO
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {this.codigo}\nMarca: {this.marca}\nClasificacion: {this.Clasificacion}");
            
            return sb.ToString();
        }
        #endregion METODO
        #region SOBRECARGA
        public static bool operator == (Instrumento i1, Instrumento i2)
        {
            return i1 == i2;
        }
        public static bool operator !=(Instrumento i1, Instrumento i2)
        {
            return !(i1==i2);
        }
        #endregion SOBRECARGA
    }
}
