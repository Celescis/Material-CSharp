using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ENTIDADES.SP
{
    public class Manzana:Fruta,ISerializar,IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Manzana";
            }

        }


        public string ProvinciaOrigen
        {
            get
            {
                return this._provinciaOrigen;
            }
            set
            {
                this._provinciaOrigen = value;
            }

        }


        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Manzana()
        {

        }

        public Manzana(string color, double peso, string provincia) : base(color, peso)
        {
            this._provinciaOrigen = provincia;
        }


        protected override string FrutaToString()
        {
            return "Nombre: " + this.Nombre + base.FrutaToString() + " Provincia De Origen: " + this._provinciaOrigen;
        }


        public override string ToString()
        {
            return this.FrutaToString();
        }

       
        //DESERIALIZAR EXPLICITAMENTE
        bool IDeserializar.Xml(string path, out Fruta f)
        {
            f = default(Fruta);
            bool retorno = false;

            try
            {

                XmlSerializer nuevoXml = new XmlSerializer(typeof(Manzana));

                using (XmlTextReader newTextReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +path))
                {
                    f = (Manzana)nuevoXml.Deserialize(newTextReader);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }

        //SERIALIZAR IMPLICITAMENTE
        public bool Xml(string path)
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(Manzana));

                using (XmlTextWriter newTextWriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, Encoding.UTF8))
                {
                    nuevoXml.Serialize(newTextWriter, this);
                    retorno = true;

                }

            }
            catch (Exception e)
            {

                throw e;

            }

            return retorno;
        }
    }
}
