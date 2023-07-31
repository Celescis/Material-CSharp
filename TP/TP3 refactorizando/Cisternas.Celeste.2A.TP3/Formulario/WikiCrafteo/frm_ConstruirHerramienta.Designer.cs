
namespace WikiCrafteo
{
    partial class frm_ConstruirHerramienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConstruirHerramienta));
            this.btn_Construir = new System.Windows.Forms.Button();
            this.btn_SalirHerramientas = new System.Windows.Forms.Button();
            this.lbl_CantidadBloquesHerramienta = new System.Windows.Forms.Label();
            this.lbl_CantidadBloquesDiamante = new System.Windows.Forms.Label();
            this.lbl_CapacidadInventario = new System.Windows.Forms.Label();
            this.lbl_InventarioHerramientas = new System.Windows.Forms.Label();
            this.cbox_Herramientas = new System.Windows.Forms.ComboBox();
            this.rb_Madera = new System.Windows.Forms.RadioButton();
            this.rb_Piedra = new System.Windows.Forms.RadioButton();
            this.rb_Diamante = new System.Windows.Forms.RadioButton();
            this.gbox_RadioButton = new System.Windows.Forms.GroupBox();
            this.lbl_CantidadBloquesMadera = new System.Windows.Forms.Label();
            this.lbl_CantidadBloquesPiedra = new System.Windows.Forms.Label();
            this.nud_CantidadHerramientas = new System.Windows.Forms.NumericUpDown();
            this.gbox_RadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Construir
            // 
            this.btn_Construir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Construir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Construir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Construir.FlatAppearance.BorderSize = 0;
            this.btn_Construir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Construir.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Construir.ForeColor = System.Drawing.Color.Black;
            this.btn_Construir.Location = new System.Drawing.Point(247, 228);
            this.btn_Construir.Name = "btn_Construir";
            this.btn_Construir.Size = new System.Drawing.Size(110, 31);
            this.btn_Construir.TabIndex = 5;
            this.btn_Construir.Text = "CONSTRUIR";
            this.btn_Construir.UseVisualStyleBackColor = false;
            this.btn_Construir.Click += new System.EventHandler(this.btn_Construir_Click);
            // 
            // btn_SalirHerramientas
            // 
            this.btn_SalirHerramientas.BackColor = System.Drawing.Color.Silver;
            this.btn_SalirHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SalirHerramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalirHerramientas.FlatAppearance.BorderSize = 0;
            this.btn_SalirHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirHerramientas.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SalirHerramientas.Location = new System.Drawing.Point(181, 394);
            this.btn_SalirHerramientas.Name = "btn_SalirHerramientas";
            this.btn_SalirHerramientas.Size = new System.Drawing.Size(104, 34);
            this.btn_SalirHerramientas.TabIndex = 6;
            this.btn_SalirHerramientas.Text = "SALIR";
            this.btn_SalirHerramientas.UseVisualStyleBackColor = false;
            // 
            // lbl_CantidadBloquesHerramienta
            // 
            this.lbl_CantidadBloquesHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantidadBloquesHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CantidadBloquesHerramienta.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadBloquesHerramienta.ForeColor = System.Drawing.Color.Black;
            this.lbl_CantidadBloquesHerramienta.Location = new System.Drawing.Point(2, 361);
            this.lbl_CantidadBloquesHerramienta.Name = "lbl_CantidadBloquesHerramienta";
            this.lbl_CantidadBloquesHerramienta.Size = new System.Drawing.Size(272, 21);
            this.lbl_CantidadBloquesHerramienta.TabIndex = 15;
            this.lbl_CantidadBloquesHerramienta.Text = "Cantidad de bloques disponibles:";
            this.lbl_CantidadBloquesHerramienta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CantidadBloquesDiamante
            // 
            this.lbl_CantidadBloquesDiamante.AutoSize = true;
            this.lbl_CantidadBloquesDiamante.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantidadBloquesDiamante.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadBloquesDiamante.ForeColor = System.Drawing.Color.Black;
            this.lbl_CantidadBloquesDiamante.Location = new System.Drawing.Point(180, 312);
            this.lbl_CantidadBloquesDiamante.Name = "lbl_CantidadBloquesDiamante";
            this.lbl_CantidadBloquesDiamante.Size = new System.Drawing.Size(19, 21);
            this.lbl_CantidadBloquesDiamante.TabIndex = 18;
            this.lbl_CantidadBloquesDiamante.Text = "0";
            // 
            // lbl_CapacidadInventario
            // 
            this.lbl_CapacidadInventario.AutoSize = true;
            this.lbl_CapacidadInventario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CapacidadInventario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapacidadInventario.ForeColor = System.Drawing.Color.Black;
            this.lbl_CapacidadInventario.Location = new System.Drawing.Point(399, 113);
            this.lbl_CapacidadInventario.Name = "lbl_CapacidadInventario";
            this.lbl_CapacidadInventario.Size = new System.Drawing.Size(28, 21);
            this.lbl_CapacidadInventario.TabIndex = 21;
            this.lbl_CapacidadInventario.Text = "20";
            // 
            // lbl_InventarioHerramientas
            // 
            this.lbl_InventarioHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InventarioHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_InventarioHerramientas.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_InventarioHerramientas.ForeColor = System.Drawing.Color.Black;
            this.lbl_InventarioHerramientas.Location = new System.Drawing.Point(247, 113);
            this.lbl_InventarioHerramientas.Name = "lbl_InventarioHerramientas";
            this.lbl_InventarioHerramientas.Size = new System.Drawing.Size(156, 21);
            this.lbl_InventarioHerramientas.TabIndex = 20;
            this.lbl_InventarioHerramientas.Text = "Espacio inventario:";
            this.lbl_InventarioHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_Herramientas
            // 
            this.cbox_Herramientas.BackColor = System.Drawing.Color.DarkGray;
            this.cbox_Herramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_Herramientas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Herramientas.FormattingEnabled = true;
            this.cbox_Herramientas.Location = new System.Drawing.Point(378, 193);
            this.cbox_Herramientas.Name = "cbox_Herramientas";
            this.cbox_Herramientas.Size = new System.Drawing.Size(98, 23);
            this.cbox_Herramientas.TabIndex = 4;
            // 
            // rb_Madera
            // 
            this.rb_Madera.AutoSize = true;
            this.rb_Madera.BackColor = System.Drawing.Color.Transparent;
            this.rb_Madera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Madera.ForeColor = System.Drawing.Color.Black;
            this.rb_Madera.Location = new System.Drawing.Point(26, 13);
            this.rb_Madera.Name = "rb_Madera";
            this.rb_Madera.Size = new System.Drawing.Size(13, 12);
            this.rb_Madera.TabIndex = 0;
            this.rb_Madera.TabStop = true;
            this.rb_Madera.Tag = "Madera";
            this.rb_Madera.UseVisualStyleBackColor = false;
            // 
            // rb_Piedra
            // 
            this.rb_Piedra.AutoSize = true;
            this.rb_Piedra.BackColor = System.Drawing.Color.Transparent;
            this.rb_Piedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Piedra.ForeColor = System.Drawing.Color.Black;
            this.rb_Piedra.Location = new System.Drawing.Point(99, 12);
            this.rb_Piedra.Name = "rb_Piedra";
            this.rb_Piedra.Size = new System.Drawing.Size(13, 12);
            this.rb_Piedra.TabIndex = 1;
            this.rb_Piedra.TabStop = true;
            this.rb_Piedra.Tag = "Piedra";
            this.rb_Piedra.UseVisualStyleBackColor = false;
            // 
            // rb_Diamante
            // 
            this.rb_Diamante.AutoSize = true;
            this.rb_Diamante.BackColor = System.Drawing.Color.Transparent;
            this.rb_Diamante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Diamante.ForeColor = System.Drawing.Color.Black;
            this.rb_Diamante.Location = new System.Drawing.Point(175, 12);
            this.rb_Diamante.Name = "rb_Diamante";
            this.rb_Diamante.Size = new System.Drawing.Size(13, 12);
            this.rb_Diamante.TabIndex = 2;
            this.rb_Diamante.TabStop = true;
            this.rb_Diamante.Tag = "Diamante";
            this.rb_Diamante.UseVisualStyleBackColor = false;
            // 
            // gbox_RadioButton
            // 
            this.gbox_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.gbox_RadioButton.Controls.Add(this.rb_Madera);
            this.gbox_RadioButton.Controls.Add(this.rb_Diamante);
            this.gbox_RadioButton.Controls.Add(this.rb_Piedra);
            this.gbox_RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbox_RadioButton.Location = new System.Drawing.Point(14, 282);
            this.gbox_RadioButton.Name = "gbox_RadioButton";
            this.gbox_RadioButton.Size = new System.Drawing.Size(210, 29);
            this.gbox_RadioButton.TabIndex = 22;
            this.gbox_RadioButton.TabStop = false;
            // 
            // lbl_CantidadBloquesMadera
            // 
            this.lbl_CantidadBloquesMadera.AutoSize = true;
            this.lbl_CantidadBloquesMadera.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantidadBloquesMadera.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadBloquesMadera.ForeColor = System.Drawing.Color.Black;
            this.lbl_CantidadBloquesMadera.Location = new System.Drawing.Point(33, 313);
            this.lbl_CantidadBloquesMadera.Name = "lbl_CantidadBloquesMadera";
            this.lbl_CantidadBloquesMadera.Size = new System.Drawing.Size(19, 21);
            this.lbl_CantidadBloquesMadera.TabIndex = 23;
            this.lbl_CantidadBloquesMadera.Text = "0";
            // 
            // lbl_CantidadBloquesPiedra
            // 
            this.lbl_CantidadBloquesPiedra.AutoSize = true;
            this.lbl_CantidadBloquesPiedra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantidadBloquesPiedra.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadBloquesPiedra.ForeColor = System.Drawing.Color.Black;
            this.lbl_CantidadBloquesPiedra.Location = new System.Drawing.Point(105, 313);
            this.lbl_CantidadBloquesPiedra.Name = "lbl_CantidadBloquesPiedra";
            this.lbl_CantidadBloquesPiedra.Size = new System.Drawing.Size(19, 21);
            this.lbl_CantidadBloquesPiedra.TabIndex = 24;
            this.lbl_CantidadBloquesPiedra.Text = "0";
            // 
            // nud_CantidadHerramientas
            // 
            this.nud_CantidadHerramientas.BackColor = System.Drawing.Color.LightGray;
            this.nud_CantidadHerramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nud_CantidadHerramientas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_CantidadHerramientas.Location = new System.Drawing.Point(276, 282);
            this.nud_CantidadHerramientas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_CantidadHerramientas.Name = "nud_CantidadHerramientas";
            this.nud_CantidadHerramientas.Size = new System.Drawing.Size(55, 25);
            this.nud_CantidadHerramientas.TabIndex = 3;
            this.nud_CantidadHerramientas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_ConstruirHerramienta
            // 
            this.AcceptButton = this.btn_Construir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_SalirHerramientas;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.nud_CantidadHerramientas);
            this.Controls.Add(this.lbl_CantidadBloquesPiedra);
            this.Controls.Add(this.lbl_CantidadBloquesMadera);
            this.Controls.Add(this.gbox_RadioButton);
            this.Controls.Add(this.cbox_Herramientas);
            this.Controls.Add(this.lbl_CapacidadInventario);
            this.Controls.Add(this.lbl_InventarioHerramientas);
            this.Controls.Add(this.lbl_CantidadBloquesDiamante);
            this.Controls.Add(this.lbl_CantidadBloquesHerramienta);
            this.Controls.Add(this.btn_SalirHerramientas);
            this.Controls.Add(this.btn_Construir);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConstruirHerramienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Qué heramienta desea crear?";
            this.Load += new System.EventHandler(this.ConstruirHerramienta_Load);
            this.gbox_RadioButton.ResumeLayout(false);
            this.gbox_RadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Construir;
        private System.Windows.Forms.Button btn_SalirHerramientas;
        private System.Windows.Forms.Label lbl_CantidadBloquesHerramienta;
        private System.Windows.Forms.Label lbl_CantidadBloquesDiamante;
        private System.Windows.Forms.Label lbl_CapacidadInventario;
        private System.Windows.Forms.Label lbl_InventarioHerramientas;
        private System.Windows.Forms.ComboBox cbox_Herramientas;
        private System.Windows.Forms.RadioButton rb_Madera;
        private System.Windows.Forms.RadioButton rb_Piedra;
        private System.Windows.Forms.RadioButton rb_Diamante;
        private System.Windows.Forms.GroupBox gbox_RadioButton;
        private System.Windows.Forms.Label lbl_CantidadBloquesMadera;
        private System.Windows.Forms.Label lbl_CantidadBloquesPiedra;
        private System.Windows.Forms.NumericUpDown nud_CantidadHerramientas;
    }
}