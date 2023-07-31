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

namespace TestWForms
{
    public partial class FormPersona : Form
    {
        //Atributo
        protected Persona personita;

        //Constructor
        public FormPersona()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        //Propiedad
        public Persona Personita { get { return this.personita; } }


        //Manejador de evento
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text!="" && this.txtApellido.Text!="" && this.txtDni.Text != "" )
            {
              this.personita = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text));


             this.DialogResult = DialogResult.OK;

            }


        }

    }
}
