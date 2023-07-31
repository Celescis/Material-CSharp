using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        //Goma-> soloLapiz:bool(público); PreciosCuidados->true; 
        //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

        public bool soloLapiz;

        public override bool PreciosCuidados { get { return true; } }

        public Goma(bool lapiz, string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = lapiz;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine(base.UtilesToString());
            st.AppendFormat("SoloLapiz: {0}\nPrecio Cuidado {1}", this.soloLapiz, this.PreciosCuidados);

            return st.ToString();
        }
    }


}
