using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public delegate void CapacidadLimite(object sender, EventArgs args);
        public event CapacidadLimite EventoCapacidad;

        #region ATRIBUTOS
        int id;
        List<Elemento> elementos;
        int capacidad;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto que inicializa la lista y el tamaño del inventario en 20
        /// </summary>
        public Inventario()
        {
            this.elementos = new List<Elemento>();
            this.capacidad = 20;
        }
        public Inventario(int id) : this()
        {
            this.id = id;
        }
        /// <summary>
        /// Constructor parametrizado para generar una capacidad al inventario
        /// </summary>
        /// <param name="capacidad"></param>
        public Inventario(int id, int capacidad):this(id)
        {
            this.capacidad = capacidad;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public List<Elemento> ListaElementos
        {
            get
            {
                return this.elementos;
            }
            set
            {
                this.elementos = value;
            }
        }

        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }

        public int CantidadMadera
        {
            get
            {
                int madera;
                int x;
                int y;
                this.CantidadBloquesPorMaterial(out madera, out x, out y);
                return madera;
            }
        }

        public int CantidadPiedra
        {
            get
            {
                int piedra;
                int x;
                int y;
                this.CantidadBloquesPorMaterial(out x, out piedra, out y);
                return piedra;
            }
        }

        public int CantidadDiamante
        {
            get
            {
                int diamante;
                int x;
                int y;
                this.CantidadBloquesPorMaterial(out x, out y, out diamante);
                return diamante;
            }
        }

        public int CantidadDiamanteInventario
        {
            get
            {
                int diamante = this.CantidadDiamanteTotal();
                return diamante;
            }
        }

        public int CantidadMaderaInventario
        {
            get
            {
                int madera = this.CantidadMaderaTotal();
                return madera;
            }
        }
        public int CantidadPiedraInventario
        {
            get
            {
                int piedra = this.CantidadPiedraTotal();
                return piedra;
            }
        }
        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// Metodo para guardar los datos de cada elemento en un StringBuilder
        /// </summary>
        /// <param name="i"></param>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder cubos = new StringBuilder();
            StringBuilder tools = new StringBuilder();
            int i = 0;
            int j = 0;

            foreach (Elemento item in this.elementos)
            {
                if (item is Cubo)
                {
                    cubos.AppendLine(((Cubo)item).ToString());
                    i++;
                }
                else
                {
                    tools.AppendLine(((Herramienta)item).ToString());
                    j++;
                }
            }
            if (i == 0 && j == 0)
            {
                sb.AppendLine($"Capacidad: {this.capacidad}");
            }
            else
            {
                if (i > 0 && j > 0)
                {
                    sb.AppendLine($"Capacidad: {this.capacidad}\n");
                    sb.AppendLine($"CUBOS: {cubos}");
                    sb.AppendLine($"HERRAMIENTAS: {tools}");
                }
                else
                {
                    if (i > 0 && j == 0)
                    {
                        sb.AppendLine($"Capacidad: {this.capacidad}\n");
                        sb.AppendLine($"CUBOS: {cubos}");
                    }
                    else if (i == 0 && j > 0)
                    {
                        sb.AppendLine($"Capacidad: {this.capacidad}\n");
                        sb.AppendLine($"HERRAMIENTAS: {tools}");
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que busca el indice de un elemento pasado por parametro
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        int GetIndiceElemento(Elemento e)
        {
            int index = -1;

            foreach (Elemento item in this.elementos)
            {
                if (item == e)
                {
                    index = this.elementos.IndexOf(e);
                    break;
                }
            }

            return index;
        }

        public void OrdenarInventario()
        {
            Elemento aux;
            int index=-1;
            for (int i = 0; i < this.ListaElementos.Count - 1; i++)
            {
                for (int j = i + 1; j < this.ListaElementos.Count; j++)
                {
                    index = -1;
                    if (this.ListaElementos[i] == this.ListaElementos[j])
                    {
                        aux = this.ListaElementos[i];
                        aux.Cantidad += this.ListaElementos[j].Cantidad;
                        this.Capacidad -= aux.Cantidad;
                        index = j;
                        this.ListaElementos.Remove(this.ListaElementos[i]);
                        this.ListaElementos.Insert(i,aux);          
                    }
                }
            }
                if(index>0)
                this.ListaElementos.RemoveAt(index);
        }

        /// <summary>
        /// Metodo que utiliza la sobrecarga del + para agregar cubos o herramientas a la lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool AgregarElemento(Elemento e)
        {
            return this + e;
        }

        /// <summary>
        /// Metodo que utiliza la sobrecarda del operador -
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool RemoverElemento(Elemento e)
        {
            return this - e;
        }

        public void CantidadBloquesPorMaterial(out int madera, out int piedra, out int diamante)
        {
            madera = 0;
            piedra = 0;
            diamante = 0;

            foreach (Elemento item in this.ListaElementos)
            {
                if (item is Cubo)
                {
                    switch (item.Tipo)
                    {
                        case ETipoMaterial.Madera:
                            madera += item.Cantidad;
                            break;
                        case ETipoMaterial.Piedra:
                            piedra += item.Cantidad;
                            break;
                        case ETipoMaterial.Diamante:
                            diamante += item.Cantidad;
                            break;
                    }
                }
            }
        }

        public bool BloquesJugador(Inventario inv, ETipoMaterial mat)
        {
            bool isHere = false;
            foreach (Elemento item in inv.ListaElementos)
            {
                if (item is Cubo && item.Tipo.Equals(mat))
                {
                    isHere = true;
                }
            }
            return isHere;
        }
        public int CantidadBloquesTotal()
        {
            int i = 0;
            foreach (Elemento item in this.ListaElementos)
            {
                if (item is Cubo)
                {
                    i += item.Cantidad;
                }
            }
            return i;
        }

        public bool TieneCubo()
        {
            bool isOk = false;
            if (this.CantidadBloquesTotal() > 0)
            {
                isOk = true;
            }
            return isOk;
        }
        private int CantidadDiamanteTotal()
        {
            int i = 0;
            foreach (Elemento item in this.ListaElementos)
            {
                if (item.Tipo == ETipoMaterial.Diamante)
                {
                    i += item.Cantidad;
                }
            }
            return i;
        }
        private int CantidadMaderaTotal()
        {
            int i = 0;
            foreach (Elemento item in this.ListaElementos)
            {
                if (item.Tipo == ETipoMaterial.Madera)
                {
                    i += item.Cantidad;
                }
            }
            return i;
        }

        private int CantidadPiedraTotal()
        {
            int i = 0;
            foreach (Elemento item in this.ListaElementos)
            {
                if (item.Tipo == ETipoMaterial.Piedra)
                {
                    i += item.Cantidad;
                }
            }
            return i;
        }
        #endregion METODOS

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga operador + que agrega Cubos y Herramientas a la lista con la particularidad que se disminuye la capacidad del inventario
        /// cada vez que se agrega un elemento, ademas cuando una herramienta es agregada se saca la misma cantidad de cubos del mismo tipo de material
        /// </summary>
        /// <param name="i"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator +(Inventario i, Elemento e)
        {
            bool isOk = false;
            Cubo cubito = new Cubo(e.Tipo);
            Elemento elementoAgregar;
            Elemento elementoBorrar;
            int indexAgregar;
            int indexBorrar;

            if (i.capacidad <= 20)
            {
                if (e is Cubo)
                {
                    indexAgregar = i.GetIndiceElemento(e);

                    if (indexAgregar == -1)
                    {
                        i.elementos.Add(e);
                    }
                    else
                    {
                        elementoAgregar = i.ListaElementos.ElementAt(indexAgregar);

                        elementoAgregar.Cantidad += e.Cantidad;
                    }

                    i.capacidad -= e.Cantidad;
                    isOk = true;
                }
                else
                {
                    int dif;
                    indexAgregar = i.GetIndiceElemento(e);
                    indexBorrar = i.GetIndiceElemento(cubito);

                    if (indexBorrar != -1)//hay cubos del tipo de material
                    {
                        elementoBorrar = i.ListaElementos.ElementAt(indexBorrar);//busco el cubo del material
                        dif = elementoBorrar.Cantidad - e.Cantidad;//diferencia de cantidad

                        if (indexAgregar == -1)
                        {
                            i.elementos.Add(e);
                            if (dif < 0)
                            {
                                e.Cantidad += dif;
                            }
                            elementoBorrar.Cantidad -= e.Cantidad;
                        }
                        else
                        {
                            elementoAgregar = i.ListaElementos.ElementAt(indexAgregar);

                            elementoAgregar.Cantidad += e.Cantidad;
                        }

                        if (elementoBorrar.Cantidad <= 0)
                        {
                            i.RemoverElemento(elementoBorrar);
                        }

                        isOk = true;

                    }
                    else
                    {
                        isOk = false;//no hay cubos para hacer las herramientas
                    }
                }
            }

            if (i.Capacidad <= 1)
            {
                if (i.EventoCapacidad != null)
                {
                    i.EventoCapacidad(i, EventArgs.Empty);
                }
            }

            return isOk;
        }

        /// <summary>
        /// Sobrecarga operador - en el cual se elimina un elemento de la lista y aumenta la capacidad del inventario
        /// </summary>
        /// <param name="i"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator -(Inventario i, Elemento e)
        {
            bool isOk = false;
            int index = i.GetIndiceElemento(e);

            if (index != -1)
            {
                i.elementos.RemoveAt(index);

                if (e is Herramienta)
                {
                    i.capacidad++;
                }

                isOk = true;
            }

            return isOk;
        }
        #endregion SOBRECARGA
    }
}
