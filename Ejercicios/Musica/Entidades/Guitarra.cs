using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Guitarra:Instrumento
    {
        #region ATRIBUTO
        private int cantidadDeCuerdas;
        #endregion ATRIBUTO

        #region CONSTRUCTOR
        public Guitarra(string marca, int cantidadDeCuerdas, int codigo, EClasificacion eClasificacion, ETipoGuitarra eTipoGuitarra):base(codigo,marca,eClasificacion)
        {
            this.cantidadDeCuerdas = cantidadDeCuerdas;
            this.Tipo = eTipoGuitarra;
        }
        #endregion CONSTRUCTOR
        #region PROPIEDAD
        public ETipoGuitarra Tipo
        {
            get;
            set;
        }
        #endregion PROPIEDAD
        #region MOSTRAR
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {base.codigo}\nMarca: {base.marca}\nClasificacion: {base.Clasificacion}\nTipo de guitarra: {this.Tipo}\nCantidad de cuerdas_ {this.cantidadDeCuerdas}");
            return sb.ToString();
        }
        #endregion MOSTRAR
    }
}
