using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        public bool soloLapiz;
        public override bool PrecioCuidados { get { return true; } }

        public Goma( bool soloLapiz, string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;

        }

        public override string ToString()
        {
            return UtilesToString() + "\nSolo Lapiz: " + this.soloLapiz + "\nPrecios cuiados: " + PrecioCuidados;
        }

    }
}
