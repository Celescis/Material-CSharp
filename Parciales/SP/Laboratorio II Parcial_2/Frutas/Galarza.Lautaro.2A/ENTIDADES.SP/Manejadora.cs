using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ENTIDADES.SP
{
    public class Manejadora<T>
    {

        public void LimitePrecio(object sender)//manejador de eventos
        {

            try
            {

                using (StreamWriter nuevoTexto = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Limite.txt"))
                {
                    nuevoTexto.WriteLine("Fecha: " + DateTime.Now);
                    nuevoTexto.WriteLine("Precio total del cajon: " + ((Cajon<T>)sender).PrecioTotal);

                }
            }
            catch (Exception e)
            {
                throw e;
            }


        }

    }
}
