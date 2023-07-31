using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public class Planeta : ISerializable
    {
        public int id;
        public string nombre;
        public int satelites;
        public double gravedad;

        public Planeta()
        {

        }
        public Planeta(int id, string nombre, int satelites, double gravedad)
        {
            this.id = id;
            this.nombre = nombre;
            this.satelites = satelites;
            this.gravedad = gravedad;
        }

        public string Ruta
        {
            get
            {
                string desktop = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "/integrador/planetaSerializado,Xml");
                return desktop;
            }
        }

        public bool SerializarXml()
        {
            if(this is not null)
            {
                using (StreamWriter streamWriter = new StreamWriter(this.Ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Planeta));
                    xmlSerializer.Serialize(streamWriter, this);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DeserializarXml()
        {
            using (StreamReader streamReader = new StreamReader(this.Ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Planeta));
                Planeta planeta = xmlSerializer.Deserialize(streamReader) as Planeta;
                return planeta.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Planeta - Id: {this.id} Nombre: {this.nombre} Satelites: {this.satelites} Gravedad: {this.gravedad}");

            return sb.ToString();
        }
    }
}
