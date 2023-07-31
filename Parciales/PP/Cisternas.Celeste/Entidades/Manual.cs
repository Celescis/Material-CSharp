using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        #region ATRIBUTOS
        public ETipo tipo;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo):base(titulo,apellido,nombre,precio)
        {
            this.tipo = tipo;
        }
        #endregion CONSTRUCTOR

        #region METODOS
        public override bool Equals(object obj)
        {
            Manual manual = obj as Manual;

            return manual is not null && manual == this;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)((Libro)this));
            sb.AppendLine($"TIPO: {this.tipo}");

            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Manual a, Manual b)
        {
            return ((Libro)a==b && a.tipo==b.tipo);
        }
        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }
        #endregion SOBRECARGA
    }
}
