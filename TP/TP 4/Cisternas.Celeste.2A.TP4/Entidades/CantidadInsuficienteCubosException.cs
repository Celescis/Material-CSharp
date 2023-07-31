using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadInsuficienteCubosException : Exception
    {
        static string msj = "No tiene cubos para crear una herramienta";
        public CantidadInsuficienteCubosException(): base(msj)
        {
        }
        public CantidadInsuficienteCubosException(string mensaje) : this(mensaje, null)
        {

        }
        public CantidadInsuficienteCubosException(Exception e): base(msj, e)
        {

        }
        public CantidadInsuficienteCubosException(string mensaje, Exception e): base(msj + mensaje, e)
        {

        }
    }
}
