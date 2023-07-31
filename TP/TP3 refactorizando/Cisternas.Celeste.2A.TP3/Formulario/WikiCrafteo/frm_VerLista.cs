using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiCrafteo
{
    public partial class frm_VerLista : Form
    {
        public Wiki wiki;

        public frm_VerLista()
        {
            InitializeComponent();
            this.wiki = new Wiki();
        }

        public frm_VerLista(Wiki lista) : this()
        {
            this.wiki = lista;
        }

        private void frm_VerLista_Load(object sender, EventArgs e)
        {

            dtgv_VerLista.DataSource = wiki.Jugadores;

            dtgv_VerLista.Columns["ID"].DisplayIndex = 0;
            dtgv_VerLista.Columns["Usuario"].DisplayIndex = 1;
            dtgv_VerLista.Columns["Inventario"].DisplayIndex = 2;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_VerLista.SelectedRows.Count > 0)
                {
                    Jugador player = (Jugador)dtgv_VerLista.CurrentRow.DataBoundItem;
                    if (MessageBox.Show("¿Esta seguro que desea borrar este jugador?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        JugadorAccesoDatos.Eliminar(player);
                        this.wiki = JugadorAccesoDatos.Leer();
                        this.Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Cancelado");
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Refrescar()
        {
            dtgv_VerLista.DataSource = this.wiki.Jugadores;
            dtgv_VerLista.Update();
            dtgv_VerLista.Refresh();
        }
    }
}
