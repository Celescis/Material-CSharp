using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Entidades
{
    public static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c,string path)
        {
            bool retorno = false;

            try
            {

                using (StreamWriter nuevoTexto = new StreamWriter(path))
                {
                    nuevoTexto.Write(DateTime.Now.ToString() +" Precio Total: "+c.PrecioTotal);
                    retorno = true;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return retorno;
        }
       

    }
}
