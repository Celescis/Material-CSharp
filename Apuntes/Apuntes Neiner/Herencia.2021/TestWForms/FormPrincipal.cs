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
    public partial class FormPrincipal : Form
    {
        //Atributo
        protected string personas;


        public FormPrincipal()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.personas = "";
        }


        private void btnPersona_Click(object sender, EventArgs e)
        {
            FormPersona p = new FormPersona();

           if(p.ShowDialog()==DialogResult.OK)
            {
                this.personas += p.Personita.Mostrar();

                this.richTextBox1.Text = this.personas;
            }

        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            FormAlumno a = new FormAlumno();

            if (a.ShowDialog() == DialogResult.OK)
            {
                this.personas += a.Alumnito.MostrarAlumno();

                this.richTextBox1.Text = this.personas;

            }
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FormProfesor p = new FormProfesor();

            if (p.ShowDialog() == DialogResult.OK)
            {
                this.personas += p.Profe.MostrarProfesor();

                this.richTextBox1.Text = this.personas;

            }
        }
    }
}
