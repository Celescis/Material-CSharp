using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escuela
    {
        #region Atributos
        private List<Persona> personas;
        private int capacidad;
        #endregion


        #region Constructores
        public Escuela()
        {
            this.personas = new List<Persona>();
            this.capacidad = 5;
        }

        public Escuela(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion


        #region Sobrecargas
        public static bool operator ==(Escuela e, Persona p)
        {
            foreach (Persona item in e.personas)
            {
                if (item == p)
                    return true;

            }

            return false;
        }

        public static bool operator !=(Escuela e, Persona p)
        {
            return !(e == p);
        }

        public static Escuela operator +(Escuela e, Persona p)
        {
            if (e.personas.Count < e.capacidad)
            {
                if (e != p)
                    e.personas.Add(p);
            }
            else
            {
                Console.WriteLine("No se pueden agregar mas!\n");
            }


            return e;
        }
        #endregion


        #region Métodos

        public string MostrarEscuela()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de personas: " + this.personas.Count);
            sb.AppendLine("");

            foreach (Persona item in this.personas)
            {
                if (item is Alumno)
                    sb.AppendLine(((Alumno)item).MostrarAlumno());

                if (item is Profesor)
                    sb.AppendLine(((Profesor)item).MostrarProfesor());

            }

            return sb.ToString();
        }



        #endregion








        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
