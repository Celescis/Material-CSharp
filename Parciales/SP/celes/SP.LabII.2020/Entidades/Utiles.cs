using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{        //Utiles-> marca:string y precio:double (públicos); PreciosCuidados:bool (prop. s/l, abstracta);
         //constructor con 2 parametros y UtilesToString():string (protegido y virtual, retorna los valores del útil)
         //ToString():string (polimorfismo; reutilizar código)
    public abstract class Utiles
    {
        public string marca;
        public double precio;
        public abstract bool PreciosCuidados { get; }

        public Utiles() { }//para poder serializar cualquier hijo
        public Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        protected virtual string UtilesToString()
        {
            return $"Marca: {this.marca}\n" + $"Precio: {this.precio}";
        }

        public override string ToString()
        {
            return this.UtilesToString();
        }

    }
}
