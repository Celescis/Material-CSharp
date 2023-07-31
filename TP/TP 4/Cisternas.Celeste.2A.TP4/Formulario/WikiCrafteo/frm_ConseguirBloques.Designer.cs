
namespace WikiCrafteo
{
    partial class frm_ConseguirBloques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConseguirBloques));
            this.lbl_ElijaMaterial = new System.Windows.Forms.Label();
            this.btn_GuardarBloques = new System.Windows.Forms.Button();
            this.btn_SalirBloques = new System.Windows.Forms.Button();
            this.cbox_Material = new System.Windows.Forms.ComboBox();
            this.lbl_CapacidadInventarioBloques = new System.Windows.Forms.Label();
            this.lbl_InventarioBloques = new System.Windows.Forms.Label();
            this.lbl_CapacidadInventario = new System.Windows.Forms.Label();
            this.nud_CantidadCubos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadCubos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ElijaMaterial
            // 
            this.lbl_ElijaMaterial.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl_ElijaMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ElijaMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ElijaMaterial.Font = new System.Drawing.Font("Malgun Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ElijaMaterial.ForeColor = System.Drawing.Color.Black;
            this.lbl_ElijaMaterial.Location = new System.Drawing.Point(101, 137);
            this.lbl_ElijaMaterial.Name = "lbl_ElijaMaterial";
            this.lbl_ElijaMaterial.Size = new System.Drawing.Size(277, 51);
            this.lbl_ElijaMaterial.TabIndex = 2;
            this.lbl_ElijaMaterial.Text = "Elija el material:";
            this.lbl_ElijaMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GuardarBloques
            // 
            this.btn_GuardarBloques.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_GuardarBloques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GuardarBloques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarBloques.FlatAppearance.BorderSize = 0;
            this.btn_GuardarBloques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarBloques.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarBloques.Location = new System.Drawing.Point(124, 344);
            this.btn_GuardarBloques.Name = "btn_GuardarBloques";
            this.btn_GuardarBloques.Size = new System.Drawing.Size(95, 34);
            this.btn_GuardarBloques.TabIndex = 2;
            this.btn_GuardarBloques.Text = "GUARDAR";
            this.btn_GuardarBloques.UseVisualStyleBackColor = false;
            this.btn_GuardarBloques.Click += new System.EventHandler(this.btn_GuardarBloques_Click);
            // 
            // btn_SalirBloques
            // 
            this.btn_SalirBloques.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_SalirBloques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SalirBloques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalirBloques.FlatAppearance.BorderSize = 0;
            this.btn_SalirBloques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirBloques.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SalirBloques.Location = new System.Drawing.Point(250, 344);
            this.btn_SalirBloques.Name = "btn_SalirBloques";
            this.btn_SalirBloques.Size = new System.Drawing.Size(95, 34);
            this.btn_SalirBloques.TabIndex = 3;
            this.btn_SalirBloques.Text = "SALIR";
            this.btn_SalirBloques.UseVisualStyleBackColor = false;
            this.btn_SalirBloques.Click += new System.EventHandler(this.btn_SalirBloques_Click);
            // 
            // cbox_Material
            // 
            this.cbox_Material.BackColor = System.Drawing.Color.LightGray;
            this.cbox_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Material.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbox_Material.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_Material.ForeColor = System.Drawing.Color.Black;
            this.cbox_Material.FormattingEnabled = true;
            this.cbox_Material.Location = new System.Drawing.Point(168, 205);
            this.cbox_Material.MaxDropDownItems = 3;
            this.cbox_Material.Name = "cbox_Material";
            this.cbox_Material.Size = new System.Drawing.Size(126, 29);
            this.cbox_Material.Sorted = true;
            this.cbox_Material.TabIndex = 0;
            // 
            // lbl_CapacidadInventarioBloques
            // 
            this.lbl_CapacidadInventarioBloques.AutoSize = true;
            this.lbl_CapacidadInventarioBloques.BackColor = System.Drawing.Color.LightGray;
            this.lbl_CapacidadInventarioBloques.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapacidadInventarioBloques.ForeColor = System.Drawing.Color.Black;
            this.lbl_CapacidadInventarioBloques.Location = new System.Drawing.Point(294, 291);
            this.lbl_CapacidadInventarioBloques.Name = "lbl_CapacidadInventarioBloques";
            this.lbl_CapacidadInventarioBloques.Size = new System.Drawing.Size(0, 21);
            this.lbl_CapacidadInventarioBloques.TabIndex = 23;
            // 
            // lbl_InventarioBloques
            // 
            this.lbl_InventarioBloques.BackColor = System.Drawing.Color.LightGray;
            this.lbl_InventarioBloques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_InventarioBloques.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_InventarioBloques.ForeColor = System.Drawing.Color.Black;
            this.lbl_InventarioBloques.Location = new System.Drawing.Point(138, 291);
            this.lbl_InventarioBloques.Name = "lbl_InventarioBloques";
            this.lbl_InventarioBloques.Size = new System.Drawing.Size(156, 21);
            this.lbl_InventarioBloques.TabIndex = 22;
            this.lbl_InventarioBloques.Text = "Espacio inventario:";
            this.lbl_InventarioBloques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CapacidadInventario
            // 
            this.lbl_CapacidadInventario.BackColor = System.Drawing.Color.LightGray;
            this.lbl_CapacidadInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CapacidadInventario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapacidadInventario.ForeColor = System.Drawing.Color.Black;
            this.lbl_CapacidadInventario.Location = new System.Drawing.Point(294, 291);
            this.lbl_CapacidadInventario.Name = "lbl_CapacidadInventario";
            this.lbl_CapacidadInventario.Size = new System.Drawing.Size(33, 21);
            this.lbl_CapacidadInventario.TabIndex = 24;
            this.lbl_CapacidadInventario.Text = "20";
            this.lbl_CapacidadInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_CantidadCubos
            // 
            this.nud_CantidadCubos.BackColor = System.Drawing.Color.LightGray;
            this.nud_CantidadCubos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nud_CantidadCubos.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_CantidadCubos.Location = new System.Drawing.Point(199, 251);
            this.nud_CantidadCubos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_CantidadCubos.Name = "nud_CantidadCubos";
            this.nud_CantidadCubos.Size = new System.Drawing.Size(55, 25);
            this.nud_CantidadCubos.TabIndex = 1;
            this.nud_CantidadCubos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_ConseguirBloques
            // 
            this.AcceptButton = this.btn_GuardarBloques;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.nud_CantidadCubos);
            this.Controls.Add(this.lbl_CapacidadInventario);
            this.Controls.Add(this.lbl_CapacidadInventarioBloques);
            this.Controls.Add(this.lbl_InventarioBloques);
            this.Controls.Add(this.cbox_Material);
            this.Controls.Add(this.btn_SalirBloques);
            this.Controls.Add(this.btn_GuardarBloques);
            this.Controls.Add(this.lbl_ElijaMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConseguirBloques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "A elegir bloques!";
            this.Load += new System.EventHandler(this.frm_ConseguirBloques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadCubos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ElijaMaterial;
        private System.Windows.Forms.Button btn_GuardarBloques;
        private System.Windows.Forms.Button btn_SalirBloques;
        private System.Windows.Forms.ComboBox cbox_Material;
        private System.Windows.Forms.Label lbl_CapacidadInventarioBloques;
        private System.Windows.Forms.Label lbl_InventarioBloques;
        private System.Windows.Forms.Label lbl_CapacidadInventario;
        private System.Windows.Forms.NumericUpDown nud_CantidadCubos;
    }
}