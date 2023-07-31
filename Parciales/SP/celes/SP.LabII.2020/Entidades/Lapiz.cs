using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{ //Lapiz-> color:ConsoleColor(público); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; público); PreciosCuidados->true; 
  //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).



    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        public ConsoleColor color;
        public ETipoTrazo trazo;

        public Lapiz() : base() { }//para poder serializarlo
        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio)
            : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public override bool PreciosCuidados { get { return true; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine($"Color: {this.color.ToString()}");
            sb.AppendLine($"Trazo: {this.trazo.ToString()}");

            return sb.ToString();
        }

        public string Path
        {    //El archivo .xml guardarlo en el escritorio del cliente, con el nombre formado con su apellido.nombre.lapiz.xml
             //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\gabor.roberta.lapiz.xml";
            }
        }

        public bool Xml()
        {
            bool rtn = true;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));//solo lapiz xq en main usa una variable que es solo lapiz
                    ser.Serialize(writer, this);
                }

            }
            catch (Exception)
            {
                rtn = false;
            }

            return rtn;
        }

        public bool Xml(out Lapiz l)
        {
            bool rtn = true;
            try
            {
                using (XmlTextReader reader = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    l = (Lapiz)ser.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                rtn = false;
                l = new Lapiz();//como lo va a devolver si o si hay que sarle !=nulo, e instanciarlo
            }
            return rtn;
        }
    }
}