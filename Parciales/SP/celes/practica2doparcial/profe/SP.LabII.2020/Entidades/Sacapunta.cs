using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   //Sacapunta-> deMetal:bool(público); 
    //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
    public class Sacapunta:Utiles
    {
        public bool deMetal;

        public Sacapunta(bool deMetal, double precio, string marca)
            : base(marca, precio)
        {
            this.deMetal = deMetal;
        }

        public override bool PreciosCuidados { get { return false; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine($"De metal?: {this.deMetal}");

            return sb.ToString();
        }

    }
}
