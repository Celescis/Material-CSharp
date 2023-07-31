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
        frm_Descargas descargas;

        public frm_Estadisticas()
        {
            InitializeComponent();

        }
        public frm_Estadisticas(Wiki jugadores) : this()
        {
            this.wiki = jugadores;
        }
        private void frm_Estadisticas_Load(object sender, EventArgs e)
        {
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_InventarioLleno_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_SeleccionDescarga.SelectedItem is not null)
                {
                    this.descargas = new frm_Descargas();
                    DialogResult resultado = descargas.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.SeleccionDescarga(this.wiki, 1);
                    }
                }
                else
                {
                    throw new SinSeleccionException();
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_PorcentajeDeDiamantes_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_SeleccionDescarga.SelectedItem is not null)
                {
                    this.descargas = new frm_Descargas();
                    DialogResult resultado = descargas.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.SeleccionDescarga(this.wiki, 2);
                    }
                }
                else
                {
                    throw new SinSeleccionException();
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_PorcentajePiedra_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_SeleccionDescarga.SelectedItem is not null)
                {
                    this.descargas = new frm_Descargas();
                    DialogResult resultado = descargas.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        this.SeleccionDescarga(this.wiki, 3);
                    }
                }
                else
                {
                    throw new SinSeleccionException();
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_PorcentajeMadera_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_SeleccionDescarga.SelectedItem is not null)
                {
                    this.descargas = new frm_Descargas();
                    DialogResult resultado = descargas.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.SeleccionDescarga(this.wiki, 4);
                    }
                }
                else
                {
                    throw new SinSeleccionException();
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeleccionDescarga(Wiki lista, int boton)
        {

            switch (cmb_SeleccionDescarga.SelectedItem)
            {
                case "Xml":
                    ArchivosEstadisticos.ImprimirPorcentaje(lista, boton, "Xml");
                    break;
                case "Json":
                    ArchivosEstadisticos.ImprimirPorcentaje(lista, boton, "Json");
                    break;
                case "Txt":
                    ArchivosEstadisticos.ImprimirPorcentaje(lista, boton, "Txt");
                    break;
            }
        }

        private void btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            lbl_numInventario.Text = this.wiki.PorcentajeConInventarioLleno().ToString()+"%";
            lbl_numDiamante.Text = this.wiki.PorcentajeDeDiamanteEnInventarios().ToString() + "%";
            lbl_numPiedra.Text = this.wiki.PorcentajeDePiedraEnInventarios().ToString() + "%";
            lbl_numMadera.Text = this.wiki.PorcentajeDeMaderaEnInventarios().ToString() + "%";
        }
    }
}
