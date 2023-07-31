using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{                //Agregar, para la clase CartucheraLlenaException, un método de extensión (InformarNovedad():string)
                 //que retorne el mensaje de error
    public class CartucheraLlenaException:Exception
    {
        public CartucheraLlenaException()
            :base()
        {
        }

    }
}
