using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WikiCrafteo
{
    public partial class frm_ConseguirBloques : Form
    {
        public Jugador aux;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frm_ConseguirBloques()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor parametrizado que recibe un jugador
        /// </summary>
        /// <param name="jugador"></param>
        public frm_ConseguirBloques(Jugador jugador) : this()
        {
            this.aux = jugador;
        }
        #endregion CONSTRUCTORES

        /// <summary>
        /// Evento load donde cargo los datos del comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_ConseguirBloques_Load(object sender, EventArgs e)
        {
            foreach (ETipoMaterial item in Enum.GetValues(typeof(ETipoMaterial)))
            {
                this.cbox_Material.Items.Add(item);
            }
            this.cbox_Material.SelectedItem = ETipoMaterial.Ninguno;
            this.cbox_Material.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_CapacidadInventario.Text = aux.Inventario.Capacidad.ToString();
            nud_CantidadCubos.Value = 0;
        }

        #region GUARDAR
        private void btn_GuardarBloques_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }
        #endregion GUARDAR

        private void Guardar()
        {
            Jugador auxiliar = new Jugador(this.aux.Id, this.aux.Usuario, this.aux.Inventario);
            try
            {
                try
                {
                    string seleccion = cbox_Material.SelectedItem.ToString();
                    int capacidadInventario = auxiliar.Inventario.Capacidad;
                    int.TryParse(nud_CantidadCubos.Value.ToString(), out int cantidad);
            
                    if (seleccion != "Ninguno" && capacidadInventario > 0 && cantidad > 0 && cantidad<=auxiliar.Inventario.Capacidad)
                    {
                        this.SeleccionUsuario(auxiliar,cantidad);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch(Exception)
                {
                    throw new SinSeleccionException();
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeleccionUsuario(Jugador jugador, int cantidad)
        {
            Cubo cubo;

            switch (cbox_Material.SelectedItem)
            {
                case ETipoMaterial.Madera:
                    cubo = new Cubo(ETipoMaterial.Madera, cantidad);
                    jugador.Inventario.AgregarElemento(cubo);
                    break;
                case ETipoMaterial.Piedra:
                    cubo = new Cubo(ETipoMaterial.Piedra, cantidad);
                    jugador.Inventario.AgregarElemento(cubo);
                    break;
                case ETipoMaterial.Diamante:
                    cubo = new Cubo(ETipoMaterial.Diamante, cantidad);
                    jugador.Inventario.AgregarElemento(cubo);
                    break;
            }
        }

        #region SALIR
        private void btn_SalirBloques_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que desea salir sin guardar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion SALIR
    }
}
