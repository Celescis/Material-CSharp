using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int dni;
        #endregion

        #region Constructor
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Dni: " + this.dni.ToString());

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        #endregion














        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
