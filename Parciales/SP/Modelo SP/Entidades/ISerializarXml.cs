using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //2.- Agregar interface para: Serializar y deserializar en xml con bool Serializar(string) y bool Deserializar(string, out Clase<T,U>) en la clase del punto anterior.
    interface ISerializarXml<T,U> where T: class where U: struct
    {
        bool Serializar(string path);
        bool Deserializar(string path, out ClaseGenerica<T,U> claseGenerica);
    }
}
