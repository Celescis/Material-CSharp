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

namespace EjercicioIntegrador
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.None;
        }



        
        //Recupera los datos de los txtBox y carga el atributo.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
