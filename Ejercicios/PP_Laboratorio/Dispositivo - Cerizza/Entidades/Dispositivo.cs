using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivoPP
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(sistemaOperativo == app.SistemaOperativo)
            {
                //Utilizo sobrecarga para agregar la app de la clase Aplicacion. Reutilizo codigo.
                return appsInstaladas + app;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo del dispositivo: {sistemaOperativo} {Environment.NewLine}");

            foreach (Aplicacion aplicacion in appsInstaladas)
            {
                sb.AppendLine(aplicacion.ObtenerInformacionApp());
            }

            return sb.ToString();
        }

    }
}
