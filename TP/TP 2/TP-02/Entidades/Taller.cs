using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller //sealed porque no puede tener heredadas
    {
        #region ATRIBUTOS
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        #endregion ATRIBUTOS

        #region ENUMERADO
        public enum ETipo //modifique los tipos
        {
            Ciclomotor, Sedan, SUV, Todos
        }
        #endregion ENUMERADO

        #region "Constructores"
        /// <summary>
        /// Constructor por defecto, genera el espacio de la lista vehiculo
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor parametrizado, guarda el espacio disponible e inicializa la lista 
        /// </summary>
        /// <param name="espacioDisponible"><valor int> 
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns><devuelve la lista>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns><retorna el contenido a listar> 
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if(v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns><retorna taller> 
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            bool isHere= false;
            if(t.vehiculos.Count < t.espacioDisponible)
            {
                //t.vehiculos.Contains(vehiculo); lo mismo?
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        isHere = true;
                        break;
                    }
                }

                if (!isHere)
                {
                    t.vehiculos.Add(vehiculo);
                }
            }

            return t;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns><retorna taller> 
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in t.vehiculos)
            {
                if (v == vehiculo)
                {
                    t.vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return t;
        }
        #endregion
    }
}
