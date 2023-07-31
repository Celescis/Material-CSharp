using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRSP
{
    ///Crear en un proyecto de tipo class library (EntidadesRSP), las clases:
    ///Persona
    ///Atributos (todos privados)
    ///dni : int
    ///apellido : string
    ///nombre : string
    ///Propiedades públicas de lectura y escritura para todos sus atributos.
    ///Constructor que reciba parámetros para cada atributo
    ///Polimorfismo sobre ToString
    ///

    public class Persona
    {
        int dni;
        string apellido;
        string nombre;

        public Persona()
        {

        }

        public Persona(int dni, string apellido, string nombre) : this()
        {
            this.Dni = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Nombre: {this.Nombre}");

            return sb.ToString();
        }
    }
}
