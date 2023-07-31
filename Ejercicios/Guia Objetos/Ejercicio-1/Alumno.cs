using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        //ATRIBUTOS
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        //METODOS
        public void CalcularFinal()
        {
            Random random = new Random();
            if(this.nota1 > 3 && this.nota2 > 3)
            {
                this.notaFinal = random.Next(4, 10);
            }
            else 
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string alumno;

            if (this.notaFinal == -1)
            {
                alumno = "Nombre: " + this.nombre + " Apellido: " + this.apellido + " Legajo: " + this.legajo.ToString() + " Nota 1: " + this.nota1.ToString() + " Nota 2: " + this.nota2.ToString() + " Nota Final: Alumno desaprobado";
            }
            else
            {
                alumno = "Nombre: " + this.nombre + " Apellido: " + this.apellido + " Legajo: " + this.legajo.ToString() + " Nota 1: " + this.nota1.ToString() + " Nota 2: " + this.nota2.ToString() + " Nota Final: " + this.notaFinal.ToString();
            }
            return alumno;
             
        }

    }
}
