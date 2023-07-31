using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionSerealizacion : Exception
    {
        public override string Message
        {
            get
            {
                return "Hubo un fallo en la serializacion en XML";
            }
        }
    }
}
