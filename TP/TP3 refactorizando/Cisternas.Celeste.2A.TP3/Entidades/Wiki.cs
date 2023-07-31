using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Jugador))]
    public class Wiki
    {
        #region ATRIBUTOS
        List<Jugador> jugadores;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto que inicializa la lista de jugadores
        /// </summary>
        public Wiki()
        {
            this.jugadores = new List<Jugador>();
        }
        /// <summary>
        /// Constructor parametrizado que recibe una lista de jugadores
        /// </summary>
        /// <param name="lista"></param>
        public Wiki(List<Jugador> lista) : this()
        {
            this.jugadores = lista;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de escritura y lectura que guarda y devuelve la lista de jugadores
        /// </summary>
        public List<Jugador> Jugadores
        {
            get
            {
                return this.jugadores;
            }
            set
            {
                this.jugadores = value;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Metodo que recibe un string, va a buscar ese usuario en la lista de jugadores
        /// y de no encontrarlo, lo crea y lo devuelve
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Jugador GetJugador(string usuario, out bool nuevo)
        {
            Jugador aux = null;
            bool isOk = false;
            nuevo = false;
            string userAux;
            string userAux2 = usuario.ToLower();
            int id = 0;

            foreach (Jugador item in this.jugadores)
            {
                if (id == 0 || id < item.Id)
                {
                    id = item.Id;
                }
                userAux = item.Usuario;
                userAux = userAux.ToLower();
                if (userAux == userAux2)
                {
                    nuevo = false;
                    aux = item;
                    isOk = true;
                    break;
                }
            }
            if (!isOk)
            {
                id++;
                nuevo = true;
                aux = new Jugador(id, usuario);
            }

            return aux;
        }

        /// <summary>
        /// Metodo Mostrar que devuelve los datos de los jugadores
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jugador item in jugadores)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Porcentaje de jugadores con inventario lleno
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public float JugadorConInventarioLleno(Wiki lista)
        {
            float porcentaje = 0;
            int total = lista.Jugadores.Count;
            int lleno = 0;
            foreach (Jugador item in lista.Jugadores)
            {
                if(item.Inventario.ListaElementos.Count==20)
                {
                    lleno += 1;
                }
            }

            if(lleno!=0)
            {
                porcentaje = (lleno * 100) / total;
            }

            return porcentaje;
        }

        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga igualdad, analiza si el jugador se encuentra en la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Wiki w, Jugador j)
        {
            bool isOk = false;

            if (w.jugadores.Count > 0)
            {
                foreach (Jugador item in w.jugadores)
                {
                    if (item == j)
                    {
                        isOk = true;
                    }
                }
            }
            return isOk;
        }
        /// <summary>
        /// Sobrecarga distinto, analiza si el jugador no esta en la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Wiki w, Jugador j)
        {
            return !(w == j);
        }
        /// <summary>
        /// Sobrecarga operador +, agrega un jugador a la lista
        /// </summary>
        /// <param name="w"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Wiki operator +(Wiki w, Jugador j)
        {
            Wiki aux = new Wiki();
            aux = w;
            if (w != j)
            {
                aux.jugadores.Add(j);
            }
            return aux;
        }
        #endregion SOBRECARGA
    }
}
