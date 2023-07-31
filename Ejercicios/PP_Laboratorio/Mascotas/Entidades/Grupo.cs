using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region ATRIBUTOS
        string nombre;
        static EtipoManada tipo; //ATRIBUTO DE CLASE POR SER ESTATICO
        List<Mascota> manada;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        static Grupo() //de clase
        {
            Grupo.tipo = EtipoManada.Unica;
        }
        private Grupo() // de instancia
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public EtipoManada Tipo //static??
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        #endregion PROPIEDADES

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Grupo: {g.nombre} - tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes({g.manada.Count})");
            foreach (Mascota mascotas in g.manada)
            {
                sb.AppendLine($"{mascotas.ToString()}");
            }
            
            return sb.ToString();
        }

        #region SOBRECARGAS
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool isOk = false;

            //if (g.manada.Contains(m))
            //{
            //    isOk = true;
            //}
            foreach (Mascota mascota in g.manada)
            {
                if(mascota == m && mascota.GetType() == m.GetType())
                {
                    isOk = true;
                }
            }
            return isOk;
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g!=m)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine($"Ya esta {m.ToString()} en el grupo");
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No esta {0} en el grupo", m.ToString());
            }
            return g;
            //if (m != null && g.manada != null)//estan bien estas validaciones?
            //{
            //    for (int i = 0; i < g.manada.Count; i++)
            //    {
            //        if (g.manada[i] == m)
            //        {
            //            g.manada.RemoveAt(i);
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    como le informo que no pudo
            //}
        }

        #endregion SOBRECARGAS
    }
}
