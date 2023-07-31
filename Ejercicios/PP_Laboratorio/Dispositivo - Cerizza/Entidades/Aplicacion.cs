using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ElDispositivoPP
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }

        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion appMasPesada = null;

            foreach (Aplicacion aplicacion in listaApp)
            {
                if (appMasPesada == null || aplicacion.Tamanio > appMasPesada.Tamanio)
                {
                    appMasPesada = aplicacion;
                }
            }
            return appMasPesada;
        }
        
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema operativo: {SistemaOperativo}");
            sb.AppendLine($"Tamaño ocupado: {Tamanio}");


            return sb.ToString();
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion x in listaApp)
            {
                if(x.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return nombre;
        }


    }
}
