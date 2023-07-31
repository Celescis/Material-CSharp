using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinSeleccionException : Exception
    {
        public SinSeleccionException() : base("No ha seleccionado nada")
        {
        }
        public SinSeleccionException(string mensaje) : this(mensaje, null)
        {

        }
        public SinSeleccionException(Exception e) : base("No ha seleccionado nada", e)
        {

        }
        public SinSeleccionException(string mensaje, Exception e) : base("No ha seleccionado nada" + mensaje, e)
        {

        }
    }
}
