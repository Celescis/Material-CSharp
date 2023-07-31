using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoHayLugarException : Exception
    {
        public NoHayLugarException():this("No hay lugar para mas planetas.")
        {
        }
        public NoHayLugarException(string message)
        : this(message, null)
        {
        }

        public NoHayLugarException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
