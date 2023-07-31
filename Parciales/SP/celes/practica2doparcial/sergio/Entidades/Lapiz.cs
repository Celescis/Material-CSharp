using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        //Lapiz-> color:ConsoleColor(público); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; público); PreciosCuidados->true; 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

        //Implementar (implícitamente) ISerializa lápiz
        //Implementar (explícitamente) IDeserializa en lápiz
        //El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con su apellido.nombre.lapiz.xml
        //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml

        public enum ETipoTrazo { Fino, Grueso, Medio }
        public ConsoleColor color;
        public ETipoTrazo trazo;

        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }
        public Lapiz() : base() { }

        public override bool PreciosCuidados { get { return true; } }

        public string Path
        {
            get
            {
                return Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString() +
 "\\Sergio.Dominguez.lapiz.xml";
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(base.UtilesToString());
            st.AppendFormat("Trazo: {0}\nColor: {1}\nPrecio Cuidado: {2}\n", this.trazo, this.color.ToString(), this.PreciosCuidados);

            return st.ToString();
        }

        public bool Xml()
        {
            bool rta = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    ser.Serialize(writer, this);
                }

            }
            catch (Exception)
            {
                rta = false;

            }

            return rta;
        }

        bool IDeserializa.Xml(out Lapiz l)
        {
            bool rta = true;

            try
            {
                using (XmlTextReader read = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    l = (Lapiz)ser.Deserialize(read);

                }

            }
            catch (Exception)
            {
                rta = false;
                l = new Lapiz();
            }

            return rta;

        }
    }
}
