using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiCrafteo
{
    public partial class frm_Edit : Form
    {
        public Jugador aux;
        public frm_Edit()
        {
            InitializeComponent();
        }
        public frm_Edit(Jugador player):this()
        {
            this.aux = player;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_NuevoUsuario.Text))
            {
                aux.Usuario = txt_NuevoUsuario.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
