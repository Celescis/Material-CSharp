using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Platano))]
    [XmlInclude(typeof(Manzana))]
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _precio;

        public abstract bool TieneCarozo { get; }

        public Fruta()
        {

        }

        public Fruta(ConsoleColor color, float precio)
        {
            this._color = color;
            this._precio = precio;
        }

        protected virtual string FrutaToString()
        {
            return "Color: " + this._color.ToString() + " Precio: " + this._precio.ToString();
        }


    }
}
