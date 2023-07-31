using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //#.-IDeserializa -> Xml(out Lapiz) : bool
    public interface IDeserializa
    {
        bool Xml(out Lapiz l);
    }
}
