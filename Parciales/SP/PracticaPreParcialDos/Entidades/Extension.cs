using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   // METODO DE EXTENSION QUE DEVUELVE UNA LISTA DE LA CLASE USUARIO
   public static class Extension
    {

        public static List<Usuario> ObtenerTodos(this Usuario usuario)
        {

              return Usuario.ReadAll();
        }
    }
}
