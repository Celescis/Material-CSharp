using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Agua : Botella
    {
        #region ATRIBUTOS
        public TipoAgua tipo;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public override double Ganancia
        {
            get
            {
                return (this.precio * 1.25);
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Agua(string marca, double precio, TipoAgua tipo):this(marca,precio,500,tipo)
        {
        }
        public Agua(string marca, double precio, int capacidad, TipoAgua tipo):base(marca,precio,capacidad)
        {
            this.tipo = tipo;
        }
        #endregion CONSTRUCTORES

        #region METODOS
        public override bool Equals(object obj)
        {
            Agua agua = obj as Agua;

            return agua is not null && agua==this;
        }
        protected override void ServirMedida()
        {
            this.contenido=0;//se consume la totalidad de su capacidad
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Agua tipo: {this.tipo}");
            
            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Agua a1, Agua a2)
        {
            bool isOk = false;

            if((Botella)a1==a2 && a1.tipo==a2.tipo)//COMPARO LAS BOTELLAS Y EL TIPO DE AGUA
            {
                isOk = true;
            }
            return isOk;
        }
        public static bool operator !=(Agua a1, Agua a2)
        {
            return !(a1 == a2);
        }
        #endregion SOBRECARGA
    }
}
