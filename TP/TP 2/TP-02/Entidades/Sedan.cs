using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region ATRIBUTO
        ETipo tipo;
        #endregion ATRIBUTO

        #region ENUMERADO
        public enum ETipo { CuatroPuertas, CincoPuertas }
        #endregion ENUMERADO

        #region CONSTRUCTORES
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"><tipo de marca> 
        /// <param name="chasis"><string> 
        /// <param name="color"><tipo de color> 
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="marca"><tipo de marca> 
        /// <param name="chasis"><string>
        /// <param name="color"><tipo de color>
        /// <param name="tipo"><tipo de vehiculo>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion CONSTRUCTORES

        #region PROPIEDAD
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion PROPIEDAD

        #region METODO
        /// <summary>
        /// Metodo mostrar de clase Sedan
        /// </summary>
        /// <returns><retorna el mensaje con sus datos>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.Append(base.Mostrar());
            sb.AppendLine($" TIPO : {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion METODO
    }
}
