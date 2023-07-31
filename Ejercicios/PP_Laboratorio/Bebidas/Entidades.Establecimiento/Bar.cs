using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades.Establecimiento
{
    public class Bar
    {
        #region ATRIBUTOS
        List<Botella> botellas;
        int capacidadMaximaBotellas;
        string nombre;
        double recaudacion;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }
        public string MostrarBar
        {
            get
            {
                return this.Mostrar();
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Bar():this(5)
        {
        }
        public Bar(int capacidad):this(capacidad,"Sin Nombre")
        {
        }
        public Bar(int capacidad, string nombre)
        {
            this.botellas = new List<Botella>();
            this.capacidadMaximaBotellas = capacidad;
            this.nombre = nombre;
        }
        #endregion CONSTRUCTORES

        #region METODOS
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append($"INFORMACION BAR\nNombre: {this.nombre}\nCapacidad MAX de botellas: {this.capacidadMaximaBotellas}\nRecaudacion: {this.recaudacion}\n");
            sb.AppendLine("\n-----------------------");
            if (botellas.Count > 0)
            {
                sb.AppendLine("BOTELLAS");
            }

            foreach (Botella item in Botellas)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString();
        }

        public void OrdenarBotellas(Ordenamiento o)
        {
            switch (o)
            {
                case Ordenamiento.Marca:
                    this.botellas.Sort(OrdenarPorMarca);
                    break;
                case Ordenamiento.Ganancia:
                    this.botellas.Sort(OrdenarPorGanancia);
                    break;
                case Ordenamiento.PorcentajeContenido:
                    this.botellas.Sort(OrdenarPorContenido);
                    break;
            }
        }
        //de clase
        private static int OrdenarPorContenido(Botella b1, Botella b2)
        {
            return b1.PorcentajeContenido.CompareTo(b2.PorcentajeContenido);
        }
        //de instancia
        private int OrdenarPorGanancia(Botella b1, Botella b2)
        {
            return b1.Ganancia.CompareTo(b2.Ganancia);
        }
        //de clase
        private static int OrdenarPorMarca(Botella b1, Botella b2)
        {
            return ((string)b1).CompareTo(((string)b2));
        }
        #endregion METODOS

        #region SOBRECARGA
// Sustracción, si la botella se encuentra en el bar, se consumirá una medida de esa botella de agua o
//botella de cerveza.Se acumulará la ganancia correspondiente en el bar y si el porcentaje de contenido
//es cero, se quitará la botella del bar. Reutilizar código
        public static explicit operator Double(Bar b)
        {
            return b.recaudacion;
        }
        public static bool operator ==(Bar a, Botella b)
        {
            //foreach (Botella item in a.botellas)
            //{
            //    if(item==b)
            //    {
            //        isOk = true;
            //    }
            //}

            //hago el foreach o solo contains ya que tengo equals?
            return a.botellas.Contains(b);
        }
        public static bool operator !=(Bar a, Botella b)
        {
            return !(a == b);
        }
        public static Bar operator -(Bar a, Botella b)
        {
            if(a==b)
            {
                b--;//se consume una medida de la botella (sobrecarga operador --)
                a+=b.Ganancia;//(sobrecarga operador +)
                if(b.PorcentajeContenido==0)
                {
                    a.botellas.Remove(b);
                }
            }
            return a;
        }
        public static Bar operator +(Bar a, Botella b)
        {
            if(a.botellas.Count() < a.capacidadMaximaBotellas && a!=b)
            {
                a.botellas.Add(b);
            }

            return a;
        }
        public static Bar operator +(Bar a, double g)
        {
            a.recaudacion += g;
            return a;
        }
        #endregion SOBRECARGA

    }
}
