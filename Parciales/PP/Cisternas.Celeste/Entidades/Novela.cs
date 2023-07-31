using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela:Libro
    {
        #region ATRIBUTOS
        public EGenero genero;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Novela(string titulo, float precio, Autor autor, EGenero genero):base(precio,titulo,autor)
        {
            this.genero = genero;
        }
        #endregion CONSTRUCTOR

        #region METODOS
        public override bool Equals(object obj)
        {
            Novela novela = obj as Novela;

            return novela is not null && novela == this;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)((Libro)this));
            sb.AppendLine($"GENERO: {this.genero}");

            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Novela a, Novela b)
        {
            return ((Libro)a == b && a.genero == b.genero);
        }
        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }
        public static implicit operator Single(Novela n)
        {
            return n.precio;
        }
        #endregion SOBRECARGA
    }
}
