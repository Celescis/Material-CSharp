
namespace WikiCrafteo
{
    partial class frm_VerLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VerLista));
            this.dtgv_VerLista = new System.Windows.Forms.DataGridView();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VerLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_VerLista
            // 
            this.dtgv_VerLista.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgv_VerLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_VerLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_VerLista.Location = new System.Drawing.Point(18, 63);
            this.dtgv_VerLista.Name = "dtgv_VerLista";
            this.dtgv_VerLista.RowTemplate.Height = 25;
            this.dtgv_VerLista.Size = new System.Drawing.Size(525, 240);
            this.dtgv_VerLista.TabIndex = 0;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Borrar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Borrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Borrar.Location = new System.Drawing.Point(400, 12);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(70, 29);
            this.btn_Borrar.TabIndex = 1;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Editar.Location = new System.Drawing.Point(483, 12);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(70, 29);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Volver.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(70, 29);
            this.btn_Volver.TabIndex = 3;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // frm_VerLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 312);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.dtgv_VerLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VerLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VerLista";
            this.Load += new System.EventHandler(this.frm_VerLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VerLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_VerLista;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Volver;
    }
}