using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        /// <param name="marca"><tipo de marca>
        /// <param name="chasis"><string>
        /// <param name="color"><tipo de color>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis,marca,color)//le agrego la referencia a su clase padre
        {
        }
        #endregion CONSTRUCTOR

        #region PROPIEDAD
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion PROPIEDAD

        #region METODO
        public override sealed string Mostrar()//cambio a public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion METODO
    }
}
