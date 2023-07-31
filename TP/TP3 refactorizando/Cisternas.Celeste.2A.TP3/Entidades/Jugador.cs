using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Jugador
    {
        #region ATRIBUTOS
        int id;
        string usuario;
        Inventario inventario;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto que inicializa el inventario
        /// </summary>
        public Jugador()
        {
            this.inventario = new Inventario();
        }
        /// <summary>
        /// Constructor parametrizado que recibe el nombre y llama al por defecto para inicializar el inventario
        /// </summary>
        /// <param name="nombre"></param>
        public Jugador(int id, string usuario) : this()
        {
            this.Id = id;
            this.Usuario = usuario;
        }
        public Jugador(int id, string usuario, int capacidad) : this(id, usuario)
        {
            this.Inventario.Capacidad = capacidad;
        }
        /// <summary>
        /// Contructor parametrizado que recibe un id, nombre y un inventario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="inventario"></param>
        public Jugador(int id, string usuario, Inventario inventario) : this(id, usuario)
        {
            this.Inventario = inventario;
        }

        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve y guarda el usuario
        /// </summary>
        public string Usuario
        {
            set
            {
                this.usuario = value;
            }
            get
            {
                return this.usuario;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve y guarda el inventario
        /// </summary>
        public Inventario Inventario
        {
            set
            {
                this.inventario = value;
            }
            get
            {
                return this.inventario;
            }
        }
        public int Id
        {
            set
            {
                this.id= value;
            }
            get
            {
                return this.id;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Override ToString para mostrar el usuario y su inventario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.Id}");
            sb.AppendLine($"USUARIO: {this.Usuario}");
            sb.AppendLine($"INVENTARIO: \n{this.Inventario}");

            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga operador == entre el usuario de un jugador y el string recibido
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, string usuario)
        {
            return (j1.Usuario == usuario);
        }
        public static bool operator !=(Jugador j1, string usuario)
        {
            return !(j1 == usuario);
        }
        /// <summary>
        /// Sobrecarga operador == entre el usuario de los jugadores
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Usuario == j2.Usuario && j1.Id == j2.Id);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion SOBRECARGA
    }
}
