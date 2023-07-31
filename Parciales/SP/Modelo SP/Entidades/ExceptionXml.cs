using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //3.- Generar excepción propia para administrar posibles errores en el punto anterior.
    public class ExceptionXml : Exception
    {
        public ExceptionXml(string mensaje) : base(mensaje)
        {

        }
    }
}
