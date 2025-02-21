namespace SistemaGestionExamenes
{
    partial class FormGenerarExamen
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
            this.labelSeleccioneAsignatura = new System.Windows.Forms.Label();
            this.comboBoxAsignatura = new System.Windows.Forms.ComboBox();
            this.textBoxUnidad = new System.Windows.Forms.TextBox();
            this.unidad = new System.Windows.Forms.Label();
            this.textBoxSubunidad = new System.Windows.Forms.TextBox();
            this.subunidad = new System.Windows.Forms.Label();
            this.buttonGenerarExamen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeleccioneAsignatura
            // 
            this.labelSeleccioneAsignatura.AutoSize = true;
            this.labelSeleccioneAsignatura.Location = new System.Drawing.Point(32, 46);
            this.labelSeleccioneAsignatura.Name = "labelSeleccioneAsignatura";
            this.labelSeleccioneAsignatura.Size = new System.Drawing.Size(126, 13);
            this.labelSeleccioneAsignatura.TabIndex = 15;
            this.labelSeleccioneAsignatura.Text = "Seleccione la asignatura:";
            // 
            // comboBoxAsignatura
            // 
            this.comboBoxAsignatura.FormattingEnabled = true;
            this.comboBoxAsignatura.Location = new System.Drawing.Point(35, 62);
            this.comboBoxAsignatura.Name = "comboBoxAsignatura";
            this.comboBoxAsignatura.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAsignatura.TabIndex = 14;
            // 
            // textBoxUnidad
            // 
            this.textBoxUnidad.Location = new System.Drawing.Point(35, 135);
            this.textBoxUnidad.Name = "textBoxUnidad";
            this.textBoxUnidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidad.TabIndex = 17;
            // 
            // unidad
            // 
            this.unidad.AutoSize = true;
            this.unidad.Location = new System.Drawing.Point(32, 119);
            this.unidad.Name = "unidad";
            this.unidad.Size = new System.Drawing.Size(44, 13);
            this.unidad.TabIndex = 16;
            this.unidad.Text = "Unidad:";
            // 
            // textBoxSubunidad
            // 
            this.textBoxSubunidad.Location = new System.Drawing.Point(189, 135);
            this.textBoxSubunidad.Name = "textBoxSubunidad";
            this.textBoxSubunidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubunidad.TabIndex = 19;
            // 
            // subunidad
            // 
            this.subunidad.AutoSize = true;
            this.subunidad.Location = new System.Drawing.Point(186, 119);
            this.subunidad.Name = "subunidad";
            this.subunidad.Size = new System.Drawing.Size(61, 13);
            this.subunidad.TabIndex = 18;
            this.subunidad.Text = "Subunidad:";
            // 
            // buttonGenerarExamen
            // 
            this.buttonGenerarExamen.Location = new System.Drawing.Point(35, 273);
            this.buttonGenerarExamen.Name = "buttonGenerarExamen";
            this.buttonGenerarExamen.Size = new System.Drawing.Size(197, 23);
            this.buttonGenerarExamen.TabIndex = 20;
            this.buttonGenerarExamen.Text = "Generar Examen";
            this.buttonGenerarExamen.UseVisualStyleBackColor = true;
            // 
            // FormGenerarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGenerarExamen);
            this.Controls.Add(this.textBoxSubunidad);
            this.Controls.Add(this.subunidad);
            this.Controls.Add(this.textBoxUnidad);
            this.Controls.Add(this.unidad);
            this.Controls.Add(this.labelSeleccioneAsignatura);
            this.Controls.Add(this.comboBoxAsignatura);
            this.Name = "FormGenerarExamen";
            this.Text = "FormGenerarExamen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccioneAsignatura;
        private System.Windows.Forms.ComboBox comboBoxAsignatura;
        private System.Windows.Forms.TextBox textBoxUnidad;
        private System.Windows.Forms.Label unidad;
        private System.Windows.Forms.TextBox textBoxSubunidad;
        private System.Windows.Forms.Label subunidad;
        private System.Windows.Forms.Button buttonGenerarExamen;
    }
}