using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            rtb_Inventario.ReadOnly = true;
            this.wiki = ConvertirALista.ListaJugadoresConInventario(JugadorAccesoDatos.LeerConsulta());
            dtgv_VerLista.DataSource = this.wiki.Jugadores;
            dtgv_VerLista.Columns["Id"].DisplayIndex = 0;
            dtgv_VerLista.Columns["Usuario"].DisplayIndex = 1;
            dtgv_VerLista.Columns["Inventario"].Visible = false;
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
                        JugadorAccesoDatos.BorrarConsulta(player);
                        this.Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Cancelado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un jugador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_VerLista.SelectedRows.Count > 0)
                {
                    Jugador player = (Jugador)dtgv_VerLista.CurrentRow.DataBoundItem;
                    frm_Edit editar = new frm_Edit(player);
                    DialogResult resultado = editar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        JugadorAccesoDatos.EditarJugador(editar.aux);
                        this.Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no editado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un jugador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Refrescar()
        {
            this.wiki = ConvertirALista.ListaJugadoresConInventario(JugadorAccesoDatos.LeerConsulta());
            dtgv_VerLista.DataSource = this.wiki.Jugadores;
            dtgv_VerLista.Update();
            dtgv_VerLista.Refresh();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_VerLista.SelectedRows.Count > 0)
                {
                    Jugador player = (Jugador)dtgv_VerLista.CurrentRow.DataBoundItem;
                    Task hilo = Task.Run(() => TraerContenido(rtb_Inventario, player));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void TraerContenido(RichTextBox textBox, Jugador jugador)
        {
            if (InvokeRequired)
            {
                Action<RichTextBox, Jugador> action = TraerContenido;
                object[] parameters = new object[] { textBox, jugador };
                this.Invoke(action, parameters);
            }
            else
            {
                textBox.Text = jugador.Inventario.ToString();
            }
        }

        private void btn_VaciarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_VerLista.SelectedRows.Count > 0)
                {
                    Jugador player = (Jugador)dtgv_VerLista.CurrentRow.DataBoundItem;
                    if (MessageBox.Show("¿Esta seguro que desea vaciar el inventario de este jugador?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        player.Inventario.ListaElementos.Clear();
                        player.Inventario.Capacidad = 20;
                        this.wiki += player;
                        JugadorAccesoDatos.EditarInventarioConsulta(player);
                        TraerContenido(rtb_Inventario, player);
                    }
                    else
                    {
                        MessageBox.Show("Cancelado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un jugador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
