using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Cajon<T>:ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        public List<T> Frutas
        {
            get { return this._frutas; }         
        }

        public float PrecioTotal
        {
            get { return this._precioUnitario * this._frutas.Count; }
        }

        public string RutaArchiva
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Cajon.xml";
            }
        }


        public Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio):this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c.Frutas.Count<c._capacidad)
            {
                c._frutas.Add(f);
            }
            else
            {
                throw new CajonLlenoException("Se exedio la capacidad del cajon");
            }

            return c;

        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Capacidad: "+ this._capacidad);
            cadena.AppendLine("Precio Total: " + this.PrecioTotal);
            cadena.AppendLine("Cantidad: " + this.Frutas.Count);
            cadena.AppendLine("Frutas: ");
            foreach (T item in this._frutas)
            {
                cadena.AppendLine(item.ToString());
            }

            return cadena.ToString();
        }



        public bool DeserializarXML()
        {          
            bool retorno = false;
          

            try
            {

                XmlSerializer nuevoXml = new XmlSerializer(this.GetType());

                using (XmlTextReader newTextReader = new XmlTextReader(this.RutaArchiva))
                {                 
                    Console.WriteLine(((Cajon<T>)nuevoXml.Deserialize(newTextReader)).ToString());
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return retorno;
        }

        public bool SerializarXML()
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(Cajon<T>));

                using (XmlTextWriter newTextWriter = new XmlTextWriter(this.RutaArchiva, Encoding.UTF8))
                {
                    nuevoXml.Serialize(newTextWriter, this);
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
