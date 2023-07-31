using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo //abstract vs sealed, no se pueden instanciar, da una definicion común que modele una jerarquía de herencia. 
    {
        #region ATRIBUTOS
        EMarca marca;
        string chasis;
        ConsoleColor color;
        #endregion ATRIBUTOS

        #region ENUMERADOS
        public enum EMarca //no van en otro lado? Los hice publicos
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion ENUMERADOS

        #region PROPIEDAD
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;} //lo deje solo get porque es lectura
        #endregion PROPIEDAD

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="chasis"><string>
        /// <param name="marca"><tipo de marca>
        /// <param name="color"><tipo de color>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion CONSTRUCTOR

        #region METODO
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns><el mensaje con los datos>
        public virtual string Mostrar()
        {
            return ((string)this);
        }
        #endregion METODO

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga de tostring
        /// </summary>
        /// <param name="p"><un vehiculo>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}\r");
            sb.AppendLine($"MARCA : {p.marca.ToString()}\r");
            sb.AppendLine($"COLOR : {p.color.ToString()}\r");
            sb.AppendLine("---------------------");
            sb.Append($"\nTAMAÑO : {p.Tamanio}");

            return sb.ToString();
        }
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"><vehiculo 1>
        /// <param name="v2"><vehiculo 2>
        /// <returns><true o false si es igual>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"><vehiculo 1>
        /// <param name="v2"><vehiculo 2>
        /// <returns><true o false si es distinto>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }
        #endregion SOBRECARGA
    }
}
