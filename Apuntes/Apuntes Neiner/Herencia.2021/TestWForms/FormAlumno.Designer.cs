
namespace TestWForms
{
    partial class FormAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNotaUno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotaDos = new System.Windows.Forms.TextBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 

            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_ClickAlumno);
            // 
            // txtNotaUno
            // 
            this.txtNotaUno.Location = new System.Drawing.Point(258, 86);
            this.txtNotaUno.Name = "txtNotaUno";
            this.txtNotaUno.Size = new System.Drawing.Size(162, 23);
            this.txtNotaUno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(258, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(258, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nota 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(258, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota 3:";
            // 
            // txtNotaDos
            // 
            this.txtNotaDos.Location = new System.Drawing.Point(258, 168);
            this.txtNotaDos.Name = "txtNotaDos";
            this.txtNotaDos.Size = new System.Drawing.Size(162, 23);
            this.txtNotaDos.TabIndex = 11;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(258, 256);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(162, 23);
            this.txtNotaTres.TabIndex = 12;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.txtNotaTres);
            this.Controls.Add(this.txtNotaDos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotaUno);
            this.Name = "FormAlumno";
            this.Text = "FormAlumno";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.txtNotaUno, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNotaDos, 0);
            this.Controls.SetChildIndex(this.txtNotaTres, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotaUno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotaDos;
        private System.Windows.Forms.TextBox txtNotaTres;
    }
}