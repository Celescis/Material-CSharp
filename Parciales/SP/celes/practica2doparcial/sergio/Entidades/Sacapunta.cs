using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        //Sacapunta-> deMetal:bool(público); 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

        public bool deMetal;
        public override bool PreciosCuidados { get { return false; } }

        public Sacapunta(bool metal, double precio, string marca) : base(marca, precio)
        {
            this.deMetal = metal;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(base.UtilesToString());
            st.AppendFormat("De Metal: {0}\nPrecio Cuidado {1}", this.deMetal, this.PreciosCuidados);

            return st.ToString();
        }
    }
}
