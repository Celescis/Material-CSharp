using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Lapiz : Utiles, IDeserializa
    {
        public enum ETipoTrazo
        {
            Fino,
            Grueso,
            Medio
        }

        public ConsoleColor color;
        public ETipoTrazo trazo;


        public override bool PrecioCuidados
        {
            get { return true; }
        }

        public string Path
        {
            get
            {
                return "Sinisterra.Luciano.lapiz.xml";
            }
        }

        public Lapiz() : this(ConsoleColor.Black, ETipoTrazo.Fino, " ", 0) //Constructor necesario para serialziar
        {

        }

        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.trazo = trazo;
            this.color = color;

        }


        public override string ToString()
        {
            return UtilesToString() + "\nColor: " + this.color + "\nTrazo: " + this.trazo + "\nPrecios cuiados: " + PrecioCuidados;
        }

        public bool Xml()
        {
            bool exito = false;

            try
            {
                XmlSerializer XmlS = new XmlSerializer(typeof(Lapiz));

                using (XmlTextWriter escritor = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path, Encoding.UTF8))
                {
                    XmlS.Serialize(escritor, this);
                    exito = true;

                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        bool IDeserializa.Xml(out Lapiz lapiz)
        {
            bool exito = false;
            lapiz = null;
            XmlSerializer serializador = new XmlSerializer(typeof(Lapiz));

            try
            {
                using (TextReader lector = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + this.Path))
                {
                    lapiz = (Lapiz)serializador.Deserialize(lector);
                    exito = true;
                }
            }
            catch (Exception)
            {
                exito = false;
     
            }

            return exito;
        }






    }
}
