using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadIncorrectaException : Exception
    {
        static string msj = "Elija una cantidad correcta";
        public CantidadIncorrectaException() : base(msj)
        {
        }

    }
}
