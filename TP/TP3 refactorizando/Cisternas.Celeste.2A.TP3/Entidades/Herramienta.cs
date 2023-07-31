using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta : Elemento, IHerramienta
    {
        #region ATRIBUTOS
        ETipoHerramienta tipoHerramienta;
        int durabilidad;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor sin parametros para serializacion
        /// </summary>
        public Herramienta()
        {

        }
        /// <summary>
        /// Constructor parametrizado con tipo de herramienta, tipo de material que inicializa la cantidad en 1
        /// </summary>
        /// <param name="tipoHerramienta"></param>
        /// <param name="tipoMaterial"></param>
        public Herramienta(ETipoHerramienta tipoHerramienta, ETipoMaterial tipoMaterial) : this(tipoHerramienta, tipoMaterial, 1)
        {

        }
        /// <summary>
        /// Constructor parametrizado con tipo de herramienta, tipo de material y con cantidad que llama al constructor base
        /// </summary>
        /// <param name="tipoHerramienta"></param>
        /// <param name="tipoMaterial"></param>
        /// <param name="cantidad"></param>
        public Herramienta(ETipoHerramienta tipoHerramienta, ETipoMaterial tipoMaterial, int cantidad) : base(tipoMaterial, cantidad)
        {
            this.tipoHerramienta = tipoHerramienta;
        }
        /// <summary>
        /// Constructor parametriza con tipo de herramiento, tipo de material, cantidad y durabilidad
        /// </summary>
        /// <param name="tipoHerramienta"></param>
        /// <param name="tipoMaterial"></param>
        /// <param name="cantidad"></param>
        /// <param name="durabilidad"></param>
        public Herramienta(ETipoHerramienta tipoHerramienta, ETipoMaterial tipoMaterial, int cantidad, int durabilidad) : this(tipoHerramienta, tipoMaterial, cantidad)
        {
            this.durabilidad = durabilidad;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Propiedad que devuelve el tipo de herramienta
        /// </summary>
        public ETipoHerramienta TipoHerramienta
        {
            set
            {
                this.tipoHerramienta = value;
            }
            get
            {
                return this.tipoHerramienta;
            }
        }

        /// <summary>
        /// Retorna la durabilidad de la herramienta segun el material
        /// </summary>
        public int Durabilidad
        {
            get
            {
                this.durabilidad = DurabilidadPorTipo(Tipo);
                return this.durabilidad;
            }
            set
            {
                this.durabilidad = value;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Override del ToString que muestra los datos de la herramientas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de herramienta: {this.TipoHerramienta}");
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.Uso(this.tipoHerramienta));
            sb.AppendLine($"Durabilidad: {this.Durabilidad}");


            return sb.ToString(); ;
        }

        public override bool Equals(object obj)
        {
            Herramienta herramienta = obj as Herramienta;

            return herramienta is not null && herramienta == this;
        }

        /// <summary>
        /// Metodo que devuelve en un string el uso de la herramienta
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public string Uso(ETipoHerramienta tipo)
        {
            string usos = "Desconocido";

            switch (tipo)
            {
                case ETipoHerramienta.Pico:
                    usos = "Sirve para mineria";
                    break;
                case ETipoHerramienta.Hacha:
                    usos = "Sirve para cortar leña";
                    break;
                case ETipoHerramienta.Espada:
                    usos = "Sirve para luchar";
                    break;
            }

            return usos;
        }

        /// <summary>
        /// Metodo que devuelve la durabilidad segun el tipo de material
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public int DurabilidadPorTipo(ETipoMaterial material)
        {
            int durabilidad = 0;
            switch (material)
            {
                case ETipoMaterial.Madera:
                    durabilidad = 59;
                    break;
                case ETipoMaterial.Piedra:
                    durabilidad = 131;
                    break;
                case ETipoMaterial.Diamante:
                    durabilidad = 1561;
                    break;
            }
            return durabilidad;
        }

        /// <summary>
        /// Metodo que me devuelve el enumerado de tipo de herramienta segun el string
        /// </summary>
        /// <param name="enu"></param>
        /// <returns></returns>
        static public ETipoHerramienta DevuelveEnumH(string enu)
        {
            Enum.TryParse(enu, out ETipoHerramienta eTipoHerramienta);

            return eTipoHerramienta;

        }

        /// <summary>
        /// Metodo que me devuelve el enumerado de tipo de material segun el string
        /// </summary>
        /// <param name="enu"></param>
        /// <returns></returns>
        static public ETipoMaterial DevuelveEnumM(string enu)
        {
            Enum.TryParse(enu, out ETipoMaterial eTipoMaterial);

            return eTipoMaterial;

        }
        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga operador == dos herramientas son iguales si son del mismo tipo de material y la misma herramienta
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        public static bool operator ==(Herramienta h1, Herramienta h2)
        {
            return (h1.Tipo == h2.Tipo && h1.TipoHerramienta == h2.TipoHerramienta);
        }

        /// <summary>
        /// Sobrecarga operador !=
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        public static bool operator !=(Herramienta h1, Herramienta h2)
        {
            return (h1 == h2);
        }
        #endregion SOBRECARGA

    }
}
