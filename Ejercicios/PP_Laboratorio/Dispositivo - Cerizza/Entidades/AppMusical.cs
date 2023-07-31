using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivoPP
{
    public class AppMusical : Aplicacion
    {
        protected List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) : this(nombre, sistemaOperativo, tamanioMb, null)
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones) : base(nombre, sistemaOperativo, tamanioMb)
        {
            if(listaCanciones is not null)
            {
                this.listaCanciones = listaCanciones;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }

        protected override int Tamanio
        {
            get
            {
                return tamanioMb + (listaCanciones.Count * 2);
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones: ");
            foreach  (string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }

            return sb.ToString();
        }



    }
}
