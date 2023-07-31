using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        string _color;
        string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        #region SOBRECARGA
        public static bool operator ==(Auto a, Auto b)
        {
            return a.Marca == b.Marca && a.Color == b.Color;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion SOBRECARGA

        public override bool Equals(object obj)
        {
            Auto auto = obj as Auto;

            return auto is not null && auto == this;
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {Marca} - Color: {Color}");
            return sb.ToString();
        }
    }
}
