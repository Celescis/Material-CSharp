using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionDeserealizacion : Exception
    {
        public override string Message
        {
            get
            {
                return "Hubo un fallo en la deserealizacion con XML";
            }
        }
    }
}
