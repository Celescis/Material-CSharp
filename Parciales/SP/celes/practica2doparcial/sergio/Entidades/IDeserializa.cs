using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IDeserializa
    {
        //#.-IDeserializa -> Xml(out Lapiz) : bool
        bool Xml(out Lapiz l);
    }
}
