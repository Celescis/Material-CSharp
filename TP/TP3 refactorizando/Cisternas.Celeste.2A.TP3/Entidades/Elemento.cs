using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Cubo))]
    [XmlInclude(typeof(Herramienta))]
    public abstract class Elemento
    {
        #region ATRIBUTOS
        ETipoMaterial tipo;
        int cantidad;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor sin parametros para serializacion
        /// </summary>
        public Elemento()
        {

        }
        /// <summary>
        /// Constructor parametrizado con tipo de material
        /// </summary>
        /// <param name="tipo"></param>
        public Elemento(ETipoMaterial tipo)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Constructor parametrizado con tipo de material y cantidad de elemento
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="cantidad"></param>
        public Elemento(ETipoMaterial tipo, int cantidad) : this(tipo)
        {
            this.cantidad = cantidad;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve el tipo de material
        /// </summary>
        public ETipoMaterial Tipo
        {
            set
            {
                this.tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la cantidad de elementos
        /// </summary>
        public int Cantidad
        {
            set
            {
                this.cantidad = value;
            }
            get
            {
                return this.cantidad;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Override al ToString para mostrar el tipo de Material
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de material: {this.Tipo}");
            sb.Append($"Cantidad: {this.Cantidad}");

            return sb.ToString(); ;
        }
        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga == si es del mismo tipo de material y la misma clase
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Elemento c1, Elemento c2)
        {
            return (c1.Tipo == c2.Tipo && Equals(c1.GetType(), c2.GetType()));
        }
        public static bool operator !=(Elemento c1, Elemento c2)
        {
            return !(c1 == c2);
        }
        #endregion SOBRECARGA
    }
}
