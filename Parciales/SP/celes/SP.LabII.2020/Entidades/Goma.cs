using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{  //Goma-> soloLapiz:bool(público); PreciosCuidados->true; 
   //Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).
    public class Goma : Utiles
    {
        public bool soloLapiz;

        public Goma(bool soloLapiz, string marca, double precio)
            : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;
        }

        public override bool PreciosCuidados { get { return true; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine($"Solo lapiz?: {this.soloLapiz}");

            return sb.ToString();
        }


    }
}
