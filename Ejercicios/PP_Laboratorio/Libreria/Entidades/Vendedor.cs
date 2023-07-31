using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiberiaPP
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float ganancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{vendedor.nombre}{Environment.NewLine}");

            foreach (Publicacion venta in vendedor.ventas)
            {
                ganancia = ganancia + (venta.Importe);
                sb.AppendLine("--------------------------------------");
                sb.AppendLine(venta.ObtenerInformacion());
            }

            sb.AppendLine($"Ganancia Total: ${ganancia}");
            return sb.ToString();
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            else
            {
                return false;
            }
        }

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) :this()
        {
            this.nombre = nombre;
        }
    }
}
