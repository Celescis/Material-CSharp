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
    public partial class frm_ConstruirHerramienta : Form
    {
        public Jugador aux;
        public Herramienta auxTool;
        bool eve = false;

        public frm_ConstruirHerramienta()
        {
            InitializeComponent();
        }
        public frm_ConstruirHerramienta(Jugador jugador) : this()
        {
            this.aux = jugador;
        }

        private void ConstruirHerramienta_Load(object sender, EventArgs e)
        {
            foreach (ETipoHerramienta item in Enum.GetValues(typeof(ETipoHerramienta)))
            {
                this.cbox_Herramientas.Items.Add(item);
            }
            this.cbox_Herramientas.Items.Add("Seleccionar");
            this.cbox_Herramientas.SelectedItem = "Seleccionar";
            lbl_CapacidadInventario.Text = aux.Inventario.Capacidad.ToString();
            lbl_CantidadBloquesMadera.Text = aux.Inventario.CantidadMadera.ToString();
            lbl_CantidadBloquesDiamante.Text = aux.Inventario.CantidadDiamante.ToString();
            lbl_CantidadBloquesPiedra.Text = aux.Inventario.CantidadPiedra.ToString();
            aux.Inventario.EventoCapacidad += Inventario_EventoCapacidad;
        }

        private void btn_Construir_Click(object sender, EventArgs e)
        {
            this.Construir();
        }

        private void Construir()
        {
            Jugador auxiliar = this.aux;

            try
            {
                string seleccion = cbox_Herramientas.SelectedItem.ToString();
                int capacidadInventario = auxiliar.Inventario.Capacidad;
                int.TryParse(nud_CantidadHerramientas.Value.ToString(), out int cantidad);

                if (seleccion != "Seleccionar" && capacidadInventario <= 20 && capacidadInventario > 0 && cantidad > 0 && cantidad <= capacidadInventario && (auxiliar.Inventario.CantidadDiamante >= cantidad || auxiliar.Inventario.CantidadPiedra >= cantidad || auxiliar.Inventario.CantidadMadera >= cantidad))
                {
                    auxTool = this.SeleccionUsuario(auxiliar, cantidad);
                    if (auxTool is not null)
                    {
                        if (eve)
                        {
                            this.DialogResult = DialogResult.No;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    if (cantidad == 0 || cantidad > capacidadInventario)
                    {
                        throw new CantidadIncorrectaException();
                    }
                }
            }
            catch (SinSeleccionException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Herramienta SeleccionUsuario(Jugador jugador, int cantidad)
        {
            try
            {
                Herramienta herramienta = new Herramienta();
                ETipoMaterial material = ValorRadioButton();

                if (material != ETipoMaterial.Ninguno)
                {
                    if (this.ValidacionMaterial(jugador, material) == true)
                    {
                        switch (cbox_Herramientas.SelectedItem)
                        {
                            case ETipoHerramienta.Pico:
                                herramienta = new Herramienta(ETipoHerramienta.Pico, material, cantidad);
                                jugador.Inventario.AgregarElemento(herramienta);
                                break;
                            case ETipoHerramienta.Hacha:
                                herramienta = new Herramienta(ETipoHerramienta.Hacha, material, cantidad);
                                jugador.Inventario.AgregarElemento(herramienta);
                                break;
                            case ETipoHerramienta.Espada:
                                herramienta = new Herramienta(ETipoHerramienta.Espada, material, cantidad);
                                jugador.Inventario.AgregarElemento(herramienta);
                                break;
                        }
                    }
                }
                else
                {
                    herramienta = null;
                }
                return herramienta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool ValidacionMaterial(Jugador jugador, ETipoMaterial material)
        {
            bool isOk = true;
            if (!jugador.Inventario.BloquesJugador(jugador.Inventario, material))
            {
                MessageBox.Show("No tiene bloques de ese tipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isOk = false;
            }

            return isOk;
        }

        private ETipoMaterial ValorRadioButton()
        {
            ETipoMaterial material = ETipoMaterial.Ninguno;

            foreach (Control item in this.gbox_RadioButton.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    switch (((RadioButton)item).Tag)
                    {
                        case "Madera":
                            material = ETipoMaterial.Madera;
                            break;
                        case "Piedra":
                            material = ETipoMaterial.Piedra;
                            break;
                        case "Diamante":
                            material = ETipoMaterial.Diamante;
                            break;
                    }
                }
            }
            if (material == ETipoMaterial.Ninguno)
            {
                MessageBox.Show("No ha seleccionado el material", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return material;
        }


        private void Inventario_EventoCapacidad(object sender, EventArgs e)
        {
            if (MessageBox.Show("Le queda poco espacio ¿Desea vaciar el inventario?", "LIMITE CAPACIDAD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ((Inventario)sender).ListaElementos.Clear();
                ((Inventario)sender).Capacidad = 20;
                eve = true;
                aux.Inventario.EventoCapacidad -= Inventario_EventoCapacidad;
            }
            else
            {
                MessageBox.Show("Inventario completo", "LIMITE CAPACIDAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.OK;
            }
        }
    }
}







