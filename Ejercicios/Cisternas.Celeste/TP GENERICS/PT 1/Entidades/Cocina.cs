using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        #region ATRIBUTOS
        int _codigo;
        bool _esIndustrial;
        double _precio;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTOR
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        #endregion CONSTRUCTOR

        #region METODOS
        public override bool Equals(object obj)
        {
            Cocina cocina = obj as Cocina;
            return cocina is not null && cocina == this;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Código: {this.Codigo} - Precio: {this.Precio} - Es industrial? {this.EsIndustrial}");
            return sb.ToString();
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Cocina a, Cocina b)
        {
            return a.Codigo==b.Codigo;
        }
        public static bool operator != (Cocina a, Cocina b)
        {
            return !(a==b);
        }
        #endregion SOBRECARGA
    }
}
