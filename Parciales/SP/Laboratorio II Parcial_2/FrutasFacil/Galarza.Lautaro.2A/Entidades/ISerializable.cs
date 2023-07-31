using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface ISerializable
    {
        string RutaArchiva {get;}

        bool DeserializarXML();
        bool SerializarXML();
    }
}
