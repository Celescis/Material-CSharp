using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cubo : Elemento, ICubo
    {
        #region ATRIBUTO
        int dureza;
        #endregion ATRIBUTO

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor sin parametros para serializacion
        /// </summary>
        public Cubo()
        {

        }
        /// <summary>
        /// Constructor parametrizado que recibe el tipo de material y guarda cantidad 1
        /// </summary>
        /// <param name="tipoMaterial"></param>
        public Cubo(ETipoMaterial tipoMaterial) : this(tipoMaterial, 1)
        {

        }
        /// <summary>
        /// Constructor parametrizado que recibe tipo materia, cantidad y llama al constructor base
        /// </summary>
        /// <param name="tipoMaterial"></param>
        /// <param name="cantidad"></param>
        public Cubo(ETipoMaterial tipoMaterial, int cantidad) : base(tipoMaterial, cantidad)
        {

        }
        /// <summary>
        /// Constructor parametrizado completo
        /// </summary>
        /// <param name="tipoMaterial"></param>
        /// <param name="dureza"></param>
        /// <param name="cantidad"></param>
        public Cubo(ETipoMaterial tipoMaterial, int dureza, int cantidad) : this(tipoMaterial, cantidad)
        {
            this.dureza = dureza;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la dureza segun el tipo de material
        /// </summary>
        public int DurezaPropiedad
        {
            get
            {
                this.dureza = GeneroDureza();
                return this.dureza;
            }
            set
            {
                this.dureza = value;
            }
        }

        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Override del ToString que muestra la informacion del cubo con la de su clase base
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Dureza de bloque: {this.GeneroDureza()}");

            return sb.ToString(); ;
        }
        public override bool Equals(object obj)
        {
            Cubo cubo = obj as Cubo;

            return cubo is not null && cubo == this;
        }

        /// <summary>
        /// Metodo que me devuelve la dureza dependiendo del material del cubo
        /// </summary>
        /// <returns>int</returns>
        public int GeneroDureza()
        {
            int numero = 0;

            switch (base.Tipo)
            {
                case ETipoMaterial.Madera:
                    numero = 2;
                    break;
                case ETipoMaterial.Piedra:
                    numero = 4;
                    break;
                case ETipoMaterial.Diamante:
                    numero = 10;
                    break;
            }

            return numero;
        }

        /// <summary>
        /// Metodo que me devuelve el enumerado de tipo de material que le paso por string
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
        /// Sobrecarga == dos cubos son iguales si son del mismo tipo de material y la misma dureza
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cubo c1, Cubo c2)
        {
            return (c1.Tipo == c2.Tipo);
        }

        /// <summary>
        /// Sobrecarga != utiliza polimorfismo del == 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cubo c1, Cubo c2)
        {
            return !(c1 == c2);
        }
        #endregion SOBRECARGA
    }
}
