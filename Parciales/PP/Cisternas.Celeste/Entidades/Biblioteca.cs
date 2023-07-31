using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        #region ATRIBUTOS
        int capacidad;
        List<Libro> libros;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioDeManuales);
            }
        }
        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioDeNovelas);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioTotal);
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        private Biblioteca(int capacidad):this()
        {
            this.capacidad = capacidad;
        }
        #endregion CONSTRUCTORES

        #region METODOS
        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {b.capacidad}");
            sb.AppendLine($"Total por manuales: {b.PrecioDeManuales}");
            sb.AppendLine($"Total por novelas: {b.PrecioDeNovelas}");
            sb.AppendLine($"Total: {b.PrecioTotal}");
            sb.AppendLine($"************************");
            sb.AppendLine($"Listado de libros");
            sb.AppendLine($"************************");

            foreach (Libro libro in b.libros)
            {
                sb.AppendLine(libro.ToString());
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precio=0;
            foreach(Libro libro in this.libros)
            {
                switch (tipoLibro)  
                {
                    case ELibro.PrecioDeManuales:
                        if(libro is Manual)
                        {
                            precio += (Single)((Manual)libro);
                        }
                        break;
                    case ELibro.PrecioDeNovelas:
                        if (libro is Novela)
                        {
                            precio += ((Novela)libro);
                        }
                        break;
                    case ELibro.PrecioTotal:
                        if (libro is Manual)
                        {
                            precio += (Single)((Manual)libro);
                        }
                        else
                        {
                            if (libro is Novela)
                            {
                                precio += ((Novela)libro);
                            }
                        }
                        break;
                }
            }

            return precio;
        }
        #endregion METODOS

        #region SOBRECARGA
        public static bool operator ==(Biblioteca b, Libro l)
        {
            return b.libros.Contains(l);
        }
        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }
        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if(b.libros.Count() < b.capacidad && b!=l)
            {
                b.libros.Add(l);
            }
            else
            {
                if(b.libros.Count()>=b.capacidad)
                {
                    Console.WriteLine("No hay mas lugar en la biblioteca!!!");
                }
                else
                {
                    Console.WriteLine("El libro ya esta en la biblioteca!!!");
                }
            }
            return b;
        }
        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.capacidad = capacidad;

            return biblioteca;
        }
        #endregion SOBRECARGA
    }
}
