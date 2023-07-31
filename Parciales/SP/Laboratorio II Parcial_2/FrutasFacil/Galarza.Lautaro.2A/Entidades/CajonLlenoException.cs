using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class CajonLlenoException:Exception
    {

        public CajonLlenoException(string mensaje):base(mensaje)
        {

        }
    }
}
