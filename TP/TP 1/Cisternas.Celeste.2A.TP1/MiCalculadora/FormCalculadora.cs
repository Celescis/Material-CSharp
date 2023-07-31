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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Metodo del evento click del boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//LISTO
        /// <summary>
        /// Metodo del evento click del boton convertir a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "" && lblResultado.Text != "0" && lblResultado.Text != "Valor inválido")
            {
                string result = Operando.DecimalBinario(lblResultado.Text);
                lblResultado.Text = result;
                btnConvertirABinario.Enabled = false;
            }
        }
        /// <summary>
        /// Metodo del evento click del boton covertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(txtNumero1.Text != "" && txtNumero2.Text != "" && lblResultado.Text != "0" && lblResultado.Text != "Valor inválido")
            {
                string result = Operando.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = result;
                btnConvertirADecimal.Enabled = false;
            }
        }
        /// <summary>
        /// Metodo del evento click del boton limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.ActivarBotones();

        }//LISTO
        /// <summary>
        /// Metodo del evento click del boton operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text;
            string numero2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            double validar;
            
            if(double.TryParse(numero1,out validar)&& double.TryParse(numero2,out validar))
            {
                if (operador == string.Empty)
                {
                    operador = "+";
                }
                
                double result = FormCalculadora.Operar(numero1,numero2,operador);
                lblResultado.Text = result.ToString();
                lstOperaciones.Items.Add(numero1+operador+numero2+"="+result.ToString());
                this.ActivarBotones();
            }
            else
            {
                MessageBox.Show("El formulario no fue llenado correctamente","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//LISTO
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add(string.Empty);
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            this.Limpiar();
        }//LISTO
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }//LISTO
        /// <summary>
        /// Metodo que reestablece los valores iniciales
        /// </summary>
        private void Limpiar()
        {
            cmbOperador.SelectedItem = "";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "0";
        }//LISTO
        /// <summary>
        /// Metodo que activa los botones conversores luego de ser usados
        /// </summary>
        private void ActivarBotones()
        {
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }
        /// <summary>
        /// Metodo que llamara al metodo operar de calculadora
        /// </summary>
        /// <param name="numero1"></param> string
        /// <param name="numero2"></param> string
        /// <param name="operador"></param> string
        /// <returns></returns> retorna el resultado del calculo 
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            if(numero2=="0" && operador=="/")
            {
                MessageBox.Show("No se puede dividir por cero","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }

            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }//LISTO
    }
}
