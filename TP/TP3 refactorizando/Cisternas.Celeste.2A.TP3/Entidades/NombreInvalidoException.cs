using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NombreInvalidoException : Exception
    {
        static string msj = "El nombre ingresado no es correcto";
        public NombreInvalidoException(): base(msj)
        {
        }
        public NombreInvalidoException(string mensaje) : this(mensaje, null)
        {

        }
        public NombreInvalidoException(Exception e): base(msj, e)
        {

        }
        public NombreInvalidoException(string mensaje, Exception e): base(msj + mensaje, e)
        {

        }
    }
}
