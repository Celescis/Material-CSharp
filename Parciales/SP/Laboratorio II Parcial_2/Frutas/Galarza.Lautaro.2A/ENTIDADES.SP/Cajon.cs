using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ENTIDADES.SP
{
    public class Cajon<T>:ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public delegate void PrecioExcedidoDel(object sender);
        public event PrecioExcedidoDel eventoPrecio;


        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }

        }

        public int Capacidad
        {
            get
            {
                return this._capacidad;
            }

            set
            {
                this._capacidad = value;
            }
        }


        public double PrecioTotal
        {
            get
            {

                return this._precioUnitario * this._elementos.Count;
            }
            
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
          
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Capacidad: " + this._capacidad);
            cadena.AppendLine("Cantidad total: " + this._elementos.Count);
            cadena.AppendLine("Precio Total: " + this.PrecioTotal);
            cadena.AppendLine("Frutas: ");

            foreach (T item in this._elementos)
            {
                cadena.AppendLine(item.ToString());

            }

            return cadena.ToString();
        }
        
        public bool Xml(string path)
        {

            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(Cajon<T>));

                using (XmlTextWriter newTextWriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +path, Encoding.UTF8))
                {
                    nuevoXml.Serialize(newTextWriter, this);
                    retorno = true;

                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

            return retorno;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {

            if (c._elementos.Count < c._capacidad)
            {
                c._elementos.Add(f);
            }
            else
            {
                throw new CajonLlenoException("Se excedio el limite del cajon");
            }

            if (c.PrecioTotal > 55)
            {
                c.eventoPrecio(c);
            }

            return c;
        }
    }
}
