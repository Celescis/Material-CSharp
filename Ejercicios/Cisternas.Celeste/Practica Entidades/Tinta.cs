using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tinta
    {
        #region Atributos
        private ConsoleColor color;
        private eTipoTinta tipo;
        #endregion Atributos

        #region Constructores
        public Tinta() : this(ConsoleColor.Black, eTipoTinta.Comun)
        { }
        public Tinta(ConsoleColor c) : this(c, eTipoTinta.Comun)
        { }
        public Tinta(eTipoTinta t) : this(ConsoleColor.Black, t)
        { }
        public Tinta(ConsoleColor c, eTipoTinta t)
        {
            this.color = c;
            this.tipo = t;
        }
        #endregion Constructores
        private string Mostrar()
        {
            return "hola";
        }
        public string Mostrar(Tinta tipo)
        {
            return "hola";
        }
        #region Sobrecarga de operadores
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool rta;
            if (t1 == t2)
            {
                rta = true;
            }
            else
            {
                rta = false;
            }
            return rta;
        }
        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }
        #endregion Sobrecarga de operadores
        public static explicit operator string(Tinta t)
        {
            return "hola";
        }


        //            instancia
        //            (-)Mostrar():string
        //            clase
        //            (+)Mostrar(Tinta):string
        //            sobrecarga de operadores
        //            == (Tinta, Tinta): bool //color y tipo
        //            explicit (Tinta) : string //se relaciona con mostrar  
    }
}
