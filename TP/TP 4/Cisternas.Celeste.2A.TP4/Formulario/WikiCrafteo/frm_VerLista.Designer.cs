
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VerLista));
            this.dtgv_VerLista = new System.Windows.Forms.DataGridView();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.rtb_Inventario = new System.Windows.Forms.RichTextBox();
            this.btn_VaciarInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VerLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_VerLista
            // 
            this.dtgv_VerLista.AllowUserToAddRows = false;
            this.dtgv_VerLista.AllowUserToDeleteRows = false;
            this.dtgv_VerLista.AllowUserToResizeColumns = false;
            this.dtgv_VerLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.dtgv_VerLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_VerLista.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgv_VerLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_VerLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_VerLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_VerLista.ColumnHeadersHeight = 20;
            this.dtgv_VerLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_VerLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_VerLista.Location = new System.Drawing.Point(18, 63);
            this.dtgv_VerLista.MultiSelect = false;
            this.dtgv_VerLista.Name = "dtgv_VerLista";
            this.dtgv_VerLista.ReadOnly = true;
            this.dtgv_VerLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_VerLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            this.dtgv_VerLista.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_VerLista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dtgv_VerLista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Peru;
            this.dtgv_VerLista.RowTemplate.Height = 25;
            this.dtgv_VerLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_VerLista.Size = new System.Drawing.Size(263, 240);
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
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
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
            // btn_Inventario
            // 
            this.btn_Inventario.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inventario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Inventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Inventario.Location = new System.Drawing.Point(349, 64);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(192, 59);
            this.btn_Inventario.TabIndex = 5;
            this.btn_Inventario.Text = "Ver inventario";
            this.btn_Inventario.UseVisualStyleBackColor = false;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // rtb_Inventario
            // 
            this.rtb_Inventario.BackColor = System.Drawing.Color.DarkGray;
            this.rtb_Inventario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtb_Inventario.DetectUrls = false;
            this.rtb_Inventario.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_Inventario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtb_Inventario.Location = new System.Drawing.Point(349, 129);
            this.rtb_Inventario.Name = "rtb_Inventario";
            this.rtb_Inventario.Size = new System.Drawing.Size(192, 174);
            this.rtb_Inventario.TabIndex = 6;
            this.rtb_Inventario.TabStop = false;
            this.rtb_Inventario.Text = "";
            // 
            // btn_VaciarInventario
            // 
            this.btn_VaciarInventario.BackColor = System.Drawing.Color.Transparent;
            this.btn_VaciarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VaciarInventario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VaciarInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_VaciarInventario.Location = new System.Drawing.Point(283, 210);
            this.btn_VaciarInventario.Name = "btn_VaciarInventario";
            this.btn_VaciarInventario.Size = new System.Drawing.Size(65, 29);
            this.btn_VaciarInventario.TabIndex = 7;
            this.btn_VaciarInventario.Text = "Vaciar";
            this.btn_VaciarInventario.UseVisualStyleBackColor = false;
            this.btn_VaciarInventario.Click += new System.EventHandler(this.btn_VaciarInventario_Click);
            // 
            // frm_VerLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 312);
            this.Controls.Add(this.btn_VaciarInventario);
            this.Controls.Add(this.rtb_Inventario);
            this.Controls.Add(this.btn_Inventario);
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
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.RichTextBox rtb_Inventario;
        private System.Windows.Forms.Button btn_VaciarInventario;
    }
}