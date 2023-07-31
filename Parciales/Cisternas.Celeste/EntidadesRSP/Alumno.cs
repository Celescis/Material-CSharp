using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRSP
{
    ///Alumno (deriva de Persona)
    ///Atributo
    ///nota : double
    ///Propiedad pública de lectura y escritura para su atributo.
    ///Constructor que reciba parámetro para cada atributo
    ///Polimorfismo sobre ToString
    ///Eventos (diseñados según convenciones vistas)
    ///Aprobar
    ///NoAprobar
    ///Promocionar
    ///Método de instancia (público)
    ///Clasificar() : void
    ///Si el atributo nota es menor a 4, lanzará el evento NoAprobar.
    ///Si el atributo nota es menor a 6 (y mayor o igual a 4), lanzará el evento Aprobar.
    ///Si el atributo nota es mayor o igual a 6, lanzará el evento Promocionar.
    ///
    public class Alumno : Persona
    {
        double nota;
        public delegate void DelegadoNota(object sender, EventArgs e);
        public event DelegadoNota NoAprobar;
        public event DelegadoNota Aprobar;
        public event DelegadoNota Promocionar;
        public Alumno()
        {

        }
        public Alumno(double nota, string nombre, string apellido, int dni) : base(dni, apellido, nombre)
        {
            this.Nota = nota;
        }

        public double Nota
        {
            get
            {
                return this.nota;
            }
            set
            {
                nota = value;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Nota: {this.Nota}");
            return sb.ToString();
        }

        public void Clasificar()
        {
            if (this.Nota < 4 && this.NoAprobar != null)
            {
                this.NoAprobar(this, EventArgs.Empty);
            }
            else
            {
                if (this.Nota < 6 && this.Nota >= 4 && this.Aprobar != null)
                {
                    this.Aprobar(this, EventArgs.Empty);
                }
                else
                {
                    if (this.Promocionar != null)
                    {
                        this.Promocionar(this, EventArgs.Empty);
                    }
                }
            }
        }
    }
}
