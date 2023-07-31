using EntidadesRSP;
using System;
using System.Linq;
using System.Windows.Forms;


namespace WinFormsAppRSP
{
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;

        public Alumno Alumno
        {
            get { return alumno; }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }
        public FrmAlumno(Alumno alumno) : this()
        {
            this.alumno = alumno;
            this.txtNombre.Text = alumno.Nombre;
            this.txtApellido.Text = alumno.Apellido;
            this.txtDNI.Text = alumno.Dni.ToString();
            this.txtNota.Text = alumno.Nota.ToString();
            this.txtDNI.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(this.txtNombre.Text) && string.IsNullOrEmpty(this.txtNombre.Text)) && this.txtDNI.Text.All(char.IsDigit) && this.txtNota.Text.All(char.IsDigit))
                {
                    int dni = int.Parse(this.txtDNI.Text);
                    double nota = double.Parse(this.txtNota.Text);
                    if (nota > 0 && nota<=10 && dni > 0)
                    {
                        this.alumno = new Alumno(nota, this.txtNombre.Text, this.txtApellido.Text, dni);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        throw new Exception("Valores numericos incorrectos");
                    }
                }
                else
                {
                    throw new Exception("Debe ingresar los datos correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
