using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        #region ATRIBUTOS
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas;
        protected float precio;
        protected string titulo;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public int CantidadDePaginas
        {
            get
            {
                if(this.cantidadDePaginas==0)
                {
                    this.cantidadDePaginas = Libro.generadorDePaginas.Next(10,570);
                }
                return this.cantidadDePaginas;
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        static Libro()
        {
            Libro.generadorDePaginas = new Random();
        }
        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
        }
        public Libro(string titulo,string apellido, string nombre, float precio):this(precio,titulo, new Autor(nombre,apellido))
        {

        }
        #endregion CONSTRUCTORES

        #region METODOS
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"AUTOR: {(string)l.autor}");
            sb.AppendLine($"TITULO: {l.titulo}");
            sb.AppendLine($"CANTIDAD DE PAGINAS: {l.CantidadDePaginas}");
            sb.AppendLine($"PRECIO: {l.precio}");
            return sb.ToString(); ;
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Libro a, Libro b)
        {
            return (a.titulo==b.titulo && a.autor==b.autor);
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        #endregion SOBRECARGA
    }
}
