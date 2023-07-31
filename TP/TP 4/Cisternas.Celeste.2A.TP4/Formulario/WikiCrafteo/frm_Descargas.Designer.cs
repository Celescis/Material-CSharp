
namespace WikiCrafteo
{
    partial class frm_Descargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Descargas));
            this.pgb_Descarga = new System.Windows.Forms.ProgressBar();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Descarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb_Descarga
            // 
            this.pgb_Descarga.ForeColor = System.Drawing.Color.Green;
            this.pgb_Descarga.Location = new System.Drawing.Point(35, 41);
            this.pgb_Descarga.Name = "pgb_Descarga";
            this.pgb_Descarga.Size = new System.Drawing.Size(271, 38);
            this.pgb_Descarga.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(131, 98);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbl_Descarga
            // 
            this.lbl_Descarga.AutoSize = true;
            this.lbl_Descarga.Location = new System.Drawing.Point(35, 23);
            this.lbl_Descarga.Name = "lbl_Descarga";
            this.lbl_Descarga.Size = new System.Drawing.Size(97, 15);
            this.lbl_Descarga.TabIndex = 2;
            this.lbl_Descarga.Text = "En progreso - 0%";
            // 
            // frm_Descargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(346, 142);
            this.Controls.Add(this.lbl_Descarga);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pgb_Descarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Descargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargando...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Descargas_FormClosing);
            this.Load += new System.EventHandler(this.frm_Descargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_Descarga;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Descarga;
    }
}