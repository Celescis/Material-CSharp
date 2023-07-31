
namespace TestWForms
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(365, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(332, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnPersona
            // 
            this.btnPersona.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersona.Location = new System.Drawing.Point(62, 74);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(153, 67);
            this.btnPersona.TabIndex = 1;
            this.btnPersona.Text = "Cargar Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlumno.Location = new System.Drawing.Point(62, 185);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(153, 67);
            this.btnAlumno.TabIndex = 2;
            this.btnAlumno.Text = "Cargar Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProfesor.Location = new System.Drawing.Point(62, 296);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(153, 67);
            this.btnProfesor.TabIndex = 3;
            this.btnProfesor.Text = "Cargar Profesor";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnProfesor;
    }
}

