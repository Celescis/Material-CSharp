
namespace WikiCrafteo
{
    partial class frm_Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ingreso));
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_SalirIngreso = new System.Windows.Forms.Button();
            this.txt_NombreIngreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Silver;
            this.btn_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.Location = new System.Drawing.Point(36, 218);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(104, 34);
            this.btn_Ingresar.TabIndex = 9;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_SalirIngreso
            // 
            this.btn_SalirIngreso.BackColor = System.Drawing.Color.Silver;
            this.btn_SalirIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SalirIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalirIngreso.FlatAppearance.BorderSize = 0;
            this.btn_SalirIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirIngreso.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SalirIngreso.Location = new System.Drawing.Point(159, 218);
            this.btn_SalirIngreso.Name = "btn_SalirIngreso";
            this.btn_SalirIngreso.Size = new System.Drawing.Size(104, 34);
            this.btn_SalirIngreso.TabIndex = 10;
            this.btn_SalirIngreso.Text = "SALIR";
            this.btn_SalirIngreso.UseVisualStyleBackColor = false;
            // 
            // txt_NombreIngreso
            // 
            this.txt_NombreIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NombreIngreso.BackColor = System.Drawing.Color.LightGray;
            this.txt_NombreIngreso.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_NombreIngreso.ForeColor = System.Drawing.Color.Black;
            this.txt_NombreIngreso.Location = new System.Drawing.Point(36, 115);
            this.txt_NombreIngreso.MaxLength = 50;
            this.txt_NombreIngreso.Name = "txt_NombreIngreso";
            this.txt_NombreIngreso.Size = new System.Drawing.Size(227, 34);
            this.txt_NombreIngreso.TabIndex = 11;
            this.txt_NombreIngreso.Text = "Ingrese su usuario";
            this.txt_NombreIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Ingreso
            // 
            this.AcceptButton = this.btn_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_SalirIngreso;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txt_NombreIngreso);
            this.Controls.Add(this.btn_SalirIngreso);
            this.Controls.Add(this.btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.frm_Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_SalirIngreso;
        private System.Windows.Forms.TextBox txt_NombreIngreso;
    }
}