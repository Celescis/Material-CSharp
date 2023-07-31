using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface ISerializar <T,U>
    {

        bool Serializar(String path);
        bool Deserializar(String path, out Generica<T,U> datos);


    }

}
