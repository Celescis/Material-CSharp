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
    public partial class frm_Estadisticas : Form
    {
        public Wiki wiki;

        public frm_Estadisticas()
        {
            InitializeComponent();

        }
        public frm_Estadisticas(Wiki jugadores) : this()
        {
            this.wiki = new Wiki(jugadores.Jugadores);
        }
        private void frm_Estadisticas_Load(object sender, EventArgs e)
        {
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btn_JugadoresConMasCubos_Click(object sender, EventArgs e)
        //{
        //    Wiki filtros = Wiki.JugadoresConMasCubos(this.wiki);
        //    Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jugadores con mas cubos.txt", filtros);
        //    this.Mensaje();
        //}

        //private void btn_JugadoresMasHerramientas_Click(object sender, EventArgs e)
        //{
        //    Wiki filtros2 = Wiki.JugadoresConMasHerramientas(this.wiki);
        //    Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jugadores con mas herramientas.txt", filtros2);
        //    this.Mensaje();
        //}

        private void Mensaje()
        {
            MessageBox.Show("Se ha guardado el archivo con la lista en el escritorio","Aviso",MessageBoxButtons.OK);
        }
    }
}
