using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor: Persona
    {
        #region Atributos
        protected double sueldo;
        #endregion


        #region Constructor
        public Profesor(string nombre, string apellido, int dni, double sueldo)
            : base(nombre, apellido, dni)
        {
            this.sueldo = sueldo;
        }
        #endregion


        #region Métodos
        public string MostrarProfesor()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Sueldo:" + this.sueldo.ToString());
            sb.AppendLine("");

            return sb.ToString();
        }
        #endregion


    }
}
