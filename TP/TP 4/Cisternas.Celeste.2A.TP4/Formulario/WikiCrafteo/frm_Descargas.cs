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

namespace WikiCrafteo
{
    public partial class frm_Descargas : Form
    {
        private static Random tiempo;
        Task task;
        private CancellationTokenSource cancelar;
        CancellationToken cancellationToken;

        static frm_Descargas()
        {
            tiempo = new Random();
        }

        public frm_Descargas()
        {
            InitializeComponent();
        }

        private void frm_Descargas_Load(object sender, EventArgs e)
        {
            IniciarHilo();
        }
        private void IniciarHilo()
        {
            cancelar = new CancellationTokenSource();
            cancellationToken = cancelar.Token;
            pgb_Descarga.Value = 0;
            task = new Task(() => IniciarProceso(pgb_Descarga, lbl_Descarga), cancellationToken);
            task.Start();
        }

        private void IniciarProceso(ProgressBar barra, Label label)
        {

            while (barra.Value < barra.Maximum && !cancelar.IsCancellationRequested)
            {
                Thread.Sleep(tiempo.Next(10, 60));
                Incremento(barra, label);
            }

            Finalizar(barra, label);
        }
        private void Incremento(ProgressBar barra, Label label)
        {
            try
            {
                if (InvokeRequired)
                {
                    Action<ProgressBar, Label> incrementar = Incremento;
                    object[] args = new object[] { barra, label };
                    Invoke(incrementar, args);
                }
                else
                {
                    barra.Increment(1);
                    label.Text = $"{barra.Value}%";
                }
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Cancelado");
            }
        }

        private void Finalizar(ProgressBar barra, Label label)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label> finalizarProceso = Finalizar;
                object[] args = new object[] { barra, label };
                Invoke(finalizarProceso, args);
            }
            else
            {
                this.Mensaje(barra);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar.Cancel();
        }

        private void frm_Descargas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
            {
                cancelar.Cancel();
                MessageBox.Show("Cancelado", "Descarga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Mensaje(ProgressBar barra)
        {
            if (barra.Value == barra.Maximum)
            {
                MessageBox.Show("Archivo guardado con exito en el escritorio", "Descarga realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
