using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //5.- Agregar interface para : Serializar y deserializar en json con 
    //bool SerializarJson(string) y bool DeserializarJson(string, out Clase), 
    //a la clase del punto anterior.
    public interface ISerializarJSON
    {
        bool SerializarJson(string path);
        bool DeserializarJson(string path, out Usuario user);
    }
}
