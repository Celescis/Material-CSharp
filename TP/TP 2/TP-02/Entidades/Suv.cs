using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo //le agrego su clase padre
    {
        #region CONSTRUCTOR
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion CONSTRUCTOR

        #region PROPIEDAD
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande; //cambie el tamaño
            }
        }
        #endregion PROPIEDAD

        #region METODO
        /// <summary>
        /// Metodo mostrar 
        /// </summary>
        /// <returns><los datos de los vehiculos>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion METODO
    }
}
