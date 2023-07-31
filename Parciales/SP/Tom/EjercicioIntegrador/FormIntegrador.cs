using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace EjercicioIntegrador
{
    public partial class FormIntegrador : Form
    {
        public FormIntegrador()
        {
            InitializeComponent();


      


            this.StartPosition = FormStartPosition.CenterScreen;
        }



         /* 
           1- Crear un objeto de tipo Planeta.
           2- Serializarlo y mostrar en un MessageBox lo sucedido.
		   3- Si serializo, deserializarlo y mostrarlo en el RichTextBox.
         */
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                Planeta planeta = new Planeta(1, "Saturno", 28, 23.7);
  
                if(planeta.SerializarXml())
                {
                    MessageBox.Show("Planeta serializado correctamente.",
                     "Atencion.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha producido un error al serializar el planeta.",
                     "Alerta.",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }

                richTextBox1.Text = planeta.DeserializarXml();
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado.",
                 "Alerta.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }



        /*
        1- Crear tres objetos de tipo Planeta.
		2- Crear objeto de tipo SistemaSolar.
		3- Agregarlos planetas al sistema solar.
        4- Mostrarlos en el RichTextBox.
        */
        private void btn2_Click(object sender, EventArgs e)
        {
            Planeta planeta1 = new Planeta(1, "Saturno", 28, 23.7);
            Planeta planeta2 = new Planeta(2, "Jupiter", 56, 49.7);
            Planeta planeta3 = new Planeta(3, "Marte", 2, 12.7);

            SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(3);

            sistemaSolar.Agregar(planeta1);
            sistemaSolar.Agregar(planeta2);
            sistemaSolar.Agregar(planeta3);

            foreach (Planeta planeta in sistemaSolar.lista)
            {
                richTextBox1.Text += planeta;
            }
        }

        /*
         1- Crear tres objetos de tipo Planeta.
		 2- Crear objeto de tipo SistemaSolar con capacidad=2.
		 3- Atrapar la Excepción "NoHayLugarException" en un bloque try-catch 
         4- Mostrar el mensaje de error en un MessageBox.
         */
        private void btn3_Click(object sender, EventArgs e)
        {
            Planeta planeta1 = new Planeta(1, "Saturno", 28, 23.7);
            Planeta planeta2 = new Planeta(2, "Jupiter", 56, 49.7);
            Planeta planeta3 = new Planeta(3, "Marte", 2, 12.7);

            SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(2);

            try
            {
                sistemaSolar.Agregar(planeta1);
                sistemaSolar.Agregar(planeta2);
                sistemaSolar.Agregar(planeta3);
            }
            catch (NoHayLugarException ex)
            {
                MessageBox.Show(ex.Message,
                 "Alerta.",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }

        }


        /*
         * 1-Creo un objeto planeta
         * 2-Asociar evento al manejador "PlanetaConMuchaGravedad"
         * 3-Hago saltar el evento
         * 4-Atrapo y muestro la gravedad del planeta en el RichTextBox  
         */

        private void btn4_Click(object sender, EventArgs e)
        {
            SistemaSolar<Planeta> sistemaSolar = new SistemaSolar<Planeta>(5);
            Planeta planeta = new Planeta(2, "Jupiter", 56, 49.7);
       
            planeta.muchaGravedad += PlanetaConmuchaGravedad;

            planeta.Gravedad = 35;
        }

        private void PlanetaConmuchaGravedad(double gravedad)
        {
            richTextBox1.Text = gravedad.ToString();
        }


        /*
         1-Crea un Task, creo el método TraerPlanetas():void
         2-En el subproceso invoco al método TraerPlanetas()
         2-Traigo los planetas de la base de datos a través del hilo secundario.
         3-Modifico el ReachTextBox a través del hilo principal.
         */
        private void btnTraer_Click(object sender, EventArgs e)
        {
            AccesoDatos acceso = new AccesoDatos();
            List<Planeta> planetas = null;

            Task traerDatos = Task.Run(() => TraerPlanetas(richTextBox1));

            void TraerPlanetas(RichTextBox box)
            {
                if (InvokeRequired)
                {
                    planetas = acceso.ObtenerListaPlaneta();
                    Action<RichTextBox> delegado = TraerPlanetas;
                    object[] parametros = new object[] { box };
                    Invoke(delegado, parametros);
                }
                else
                {
                    foreach (Planeta p in planetas)
                    {
                        richTextBox1.Text += p;
                    }
                }
            }
        }


        /*
         1- Invoca al formulario de alta.
		 2- Si se acepta, se actualiza BD, se agrega a la lista.
         3- Retorna la lista y muestra en el RichTextBox.
         * */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();
            
            string nombre;
            int satelites;
            float gravedad;

            if (formAlta.DialogResult == DialogResult.OK)
            {
                nombre = formAlta.txtNombre.Text;
                satelites = Int32.Parse(formAlta.txtSatelites.Text);
                gravedad = Single.Parse(formAlta.txtGravedad.Text);

                Planeta planeta = new Planeta(0, nombre, satelites, gravedad);
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.AgregarPlaneta(planeta);

                btnTraer_Click(this, null);
            }
            else
            {
                //No hago nada
            }
        }

        /*
         1 Invoca el formulario de alta a modificar pasandole los datos para mostrar.
		 2- Si se acepta el modificado, se actualiza BD 
         3-retorna la lista y muestra en el RichTextBox.
         * */
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            string nombre;
            int satelites;
            float gravedad;

            if (formAlta.DialogResult == DialogResult.OK)
            {
                nombre = formAlta.txtNombre.Text;
                satelites = Int32.Parse(formAlta.txtSatelites.Text);
                gravedad = Single.Parse(formAlta.txtGravedad.Text);

                Planeta planeta = new Planeta(5, nombre, satelites, gravedad);
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.ModificarDato(planeta);
                btnTraer_Click(this, null);

            }
            else
            {
                //No hago nada
            }
        }

            /*
             1- Invoca el formulario de alta a eliminar pasandole los datos para mostrar.
             2- Si se acepta el eliminado, se actualiza BD
             3-retorna la lista y muestra.
             */
            private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.EliminarDato(5);
                btnTraer_Click(this, null);

            }
            else
            {
                //No hago nada
            }
        }    
    }
}
