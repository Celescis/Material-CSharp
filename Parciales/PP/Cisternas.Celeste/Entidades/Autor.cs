using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        #region ATRIBUTOS
        string apellido;
        string nombre;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido=apellido;
        }
        #endregion CONSTRUCTOR

        #region SOBRECARGA
        public static bool operator ==(Autor a, Autor b)
        {
            return (a.nombre == b.nombre && a.apellido == b.apellido);
        }
        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
        public static implicit operator string(Autor a)
        {
            return a.nombre+" - "+a.apellido;
        }
        #endregion SOBRECARGA
    }
}
