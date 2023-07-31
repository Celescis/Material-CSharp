using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class FrmHilos : Form
    {
        private static Random random;
        private CancellationTokenSource cancellationTokenSource;
        private List<Task> hilos;

        static FrmHilos()
        {
            random = new Random();
        }

        public FrmHilos()
        {
            InitializeComponent();
            hilos = new List<Task>();
        }

        private void FrmHilos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmHilos_Load(object sender, EventArgs e)
        {
            IniciarHilos();
        }

        private void IniciarHilos()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;

            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task1 = new Task(() => IniciarProceso(progressBar1, label1), cancellationToken);
            task1.Start();
            hilos.Add(task1);

            Task task2 = Task.Run(() => IniciarProceso(progressBar2, label2), cancellationToken);
            hilos.Add(task2);

            Task task3 = Task.Run(() => IniciarProceso(progressBar3, label3), cancellationToken);
            hilos.Add(task3);

            Task task4 = Task.Run(() => IniciarProceso(progressBar4, label4), cancellationToken);
            hilos.Add(task4);

            Task task5 = Task.Run(() => IniciarProceso(progressBar5, label5), cancellationToken);
            hilos.Add(task5);
        }

        private void IniciarProceso(ProgressBar barraProgreso, Label label)
        {
            while (barraProgreso.Value < barraProgreso.Maximum
                && !cancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(random.Next(100, 1000));
                IncrementarBarraProgreso(barraProgreso, label, Task.CurrentId.Value);
            }

            FinalizarProceso(barraProgreso, label);
        }

        private void IncrementarBarraProgreso(ProgressBar barraProgreso, Label label, int idHilo)
        {
            // InvokeRequired retorna true si requiero una invocación
            // desde el hilo que creo al formulario. Es decir, si estoy en un hilo distinto al principal.
            if (InvokeRequired)
            {
                // Encapsular la referencia al método que modifica a los controles en un delegado.
                Action<ProgressBar, Label, int> delegado = IncrementarBarraProgreso;
                // Si y sólo si recibe parámetros, voy a guardarlos en un array de object.
                object[] parametros = new object[] { barraProgreso, label, idHilo };
                // Invoke invoca al delegado desde el hilo que creo al formulario 
                // pasándole los parámetros (si tiene) en el mismo orden del array.
                Invoke(delegado, parametros);
            }
            else
            {
                // Luego del Invoke, InvokeRequired da false porque estamos en el mismo hilo que creo el formulario
                // y se pueden modificar los controles de manera segura. 
                barraProgreso.Increment(1);
                label.Text = $"Hilo N°{idHilo} - {barraProgreso.Value}%";
            }
        }

        private void FinalizarProceso(ProgressBar barraProgreso, Label label)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label> finalizarProceso = FinalizarProceso;
                object[] parametros = new object[] { barraProgreso, label };
                Invoke(finalizarProceso, parametros);
            }
            else
            {
                if (barraProgreso.Value == barraProgreso.Maximum)
                {
                    label.Text = "FINALIZADO";
                }
                else
                {
                    label.Text = "CANCELADO";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMensaje.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Task hilo in hilos)
            {
                stringBuilder.Append($"Hilo {hilo.Id} ");
                string mensaje = hilo.IsCompleted ? $"está completado." : $"en estado {hilo.Status}.";
                stringBuilder.Append(mensaje);
                stringBuilder.AppendLine();
            }

            MessageBox.Show(stringBuilder.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();

            while (!hilos.All(h => h.IsCompleted))
            {
                await Task.Delay(1000);
            }

            IniciarHilos();
        }

        private void FrmHilos_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
