using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    //1.- Crear una clase genérica que contenga un atributo de tipo List<T> y otro de tipo U, ambos protected.
    //Realizar sobre la clase: propiedades(l/e), constructor por defecto + sobrecarga(1 parametro U), métodos Add y Remove y polimorfismo sobre ToString.

    public class ClaseGenerica<T, U> : ISerializarXml<T, U>
        where T : class
        where U : struct
    {
        //ATRIBUTOS
        protected List<T> lista;
        protected U objeto;

        //CONSTRUCTOR
        public ClaseGenerica()
        {
            this.Lista = new List<T>();
        }
        public ClaseGenerica(U objeto) : this()
        {
            this.Objeto = objeto;
        }

        //PROPIEDADES
        public U Objeto { get => objeto; set => objeto = value; }
        public List<T> Lista { get => lista; set => lista = value; }

        //METODOS
        public bool AddT(T t)
        {
            return this + t;
        }

        public bool Remove(T t)
        {
            return this - t;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this.objeto}");
            sb.AppendLine($"Listado de {typeof(T).Name}");//PARA PONER EL NOMBRE DEL TIPO
            foreach (T item in this.Lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        //SOBRECARGA
        public static bool operator +(ClaseGenerica<T, U> t, T t2)
        {
            bool isOk = false;

            if (!t.lista.Contains(t2))
            {
                t.Lista.Add(t2);
                isOk = true;
            }

            return isOk;
        }
        public static bool operator -(ClaseGenerica<T, U> t, T t2)
        {
            bool isOk = false;

            if (t.lista.Contains(t2))
            {
                t.Lista.Remove(t2);
                isOk = true;
            }

            return isOk;
        }

        //SERIALIZAR XML
        public bool Deserializar(string path, out ClaseGenerica<T, U> claseGenerica)
        {
            try
            {
                bool isOk = false;

                XmlSerializer deserializer = new XmlSerializer(typeof(ClaseGenerica<T, U>));

                using (XmlTextReader writer = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path))
                { 
                    claseGenerica = (ClaseGenerica<T, U>)deserializer.Deserialize(writer);

                    isOk = true;
                }
                return isOk;
            }
            catch (Exception)
            {

                throw new ExceptionXml("No se pudo deserializar");
            }
        }

        public bool Serializar(string path)
        {
            try
            {
                bool isOk = false;

                XmlSerializer serializer = new XmlSerializer(typeof(ClaseGenerica<T, U>));

                using (XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, Encoding.UTF8))
                {
                    serializer.Serialize(writer, this);

                    isOk = true;
                }
                return isOk;
            }
            catch (Exception)
            {

                throw new ExceptionXml("No se pudo serializar");
            }
        }
    }
}