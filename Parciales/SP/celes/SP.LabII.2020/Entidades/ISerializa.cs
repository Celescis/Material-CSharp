using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //#.-ISerializa -> Xml() : bool
    //              -> Path{ get; } : string

    public interface ISerializa
    {
        bool Xml();//interfae no llevan visibilidad
        string Path { get; }
    }
}
