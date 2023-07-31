using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza : Botella
    {
        #region ATRIBUTOS
        public int medida;
        public TipoCerveza tipo;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public override double Ganancia
        {
            get
            {
                return this.precio * 0.5;
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo) : this(marca, precio, capacidad, tipo,(capacidad/3))
        {
        }
        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida) : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }
        #endregion CONSTRUCTORES

        #region METODOS
        public override bool Equals(object obj)
        {
            Cerveza cerveza = obj as Cerveza;

            return cerveza is not null && cerveza == this;
        }
        protected override void ServirMedida()
        {
//            ServirMedida descontará, del contenido de la botella de cerveza, una medida.Si una vez descontada, el
//contenido restante de la botella de cerveza es menor al valor del atributo medida, se descartará, vaciando el
//contenido de la botella
            this.contenido-=this.medida;

            if (this.contenido<this.medida)
            {
                this.contenido = 0;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cerveza tipo: {this.tipo}");
            
            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Cerveza c1, Cerveza c2)
        {
            return ((Botella)c1 == c2 && c1.tipo == c2.tipo);//COMPARO LAS BOTELLAS Y EL TIPO DE CERVEZA
        }
        public static bool operator !=(Cerveza c1, Cerveza c2)
        {
            return !(c1 == c2);
        }
        #endregion SOBRECARGA
    }
}
