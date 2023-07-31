using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        #region Atributos
        protected List<int> notas;
        #endregion


        #region Constructores
        public Alumno(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.notas = new List<int>();
        }

        public Alumno(string nombre, string apellido, int dni, int n1, int n2, int n3)
                    : this(nombre, apellido, dni)
        {
            this.notas.Add(n1);
            this.notas.Add(n2);
            this.notas.Add(n3);
        }
        #endregion


        #region Propiedades
        public double Promedio
        {
            get
            {
                double cont = 0;
                int acum = 0;

                if (this.notas.Count > 0)
                {
                    foreach (int item in this.notas)
                    {
                        cont++;
                        acum += item;

                    }
                    return acum / cont;
                }
                return 1;
            }

        }
        #endregion


        #region Métodos
        public string MostrarAlumno()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Promedio:" + this.Promedio.ToString());
            sb.AppendLine("");
            
            return sb.ToString();
        }
        #endregion


    }
}
