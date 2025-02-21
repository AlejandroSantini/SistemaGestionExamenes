namespace SistemaGestionExamenes
{
    partial class FormMenu
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
            this.buttonCorregirExamen = new System.Windows.Forms.Button();
            this.buttonGenerarExamen = new System.Windows.Forms.Button();
            this.buttonPreguntas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCorregirExamen
            // 
            this.buttonCorregirExamen.Location = new System.Drawing.Point(261, 295);
            this.buttonCorregirExamen.Name = "buttonCorregirExamen";
            this.buttonCorregirExamen.Size = new System.Drawing.Size(204, 32);
            this.buttonCorregirExamen.TabIndex = 0;
            this.buttonCorregirExamen.Text = "Corregir Examen";
            this.buttonCorregirExamen.UseVisualStyleBackColor = true;
            this.buttonCorregirExamen.Click += new System.EventHandler(this.buttonCorregirExamen_Click);
            // 
            // buttonGenerarExamen
            // 
            this.buttonGenerarExamen.Location = new System.Drawing.Point(261, 230);
            this.buttonGenerarExamen.Name = "buttonGenerarExamen";
            this.buttonGenerarExamen.Size = new System.Drawing.Size(204, 32);
            this.buttonGenerarExamen.TabIndex = 1;
            this.buttonGenerarExamen.Text = "Generar Examen";
            this.buttonGenerarExamen.UseVisualStyleBackColor = true;
            this.buttonGenerarExamen.Click += new System.EventHandler(this.buttonGenerarExamen_Click);
            // 
            // buttonPreguntas
            // 
            this.buttonPreguntas.Location = new System.Drawing.Point(261, 167);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(204, 32);
            this.buttonPreguntas.TabIndex = 2;
            this.buttonPreguntas.Text = "Crear Preguntas";
            this.buttonPreguntas.UseVisualStyleBackColor = true;
            this.buttonPreguntas.Click += new System.EventHandler(this.buttonPreguntas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido al Sistema de Gestión";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPreguntas);
            this.Controls.Add(this.buttonGenerarExamen);
            this.Controls.Add(this.buttonCorregirExamen);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCorregirExamen;
        private System.Windows.Forms.Button buttonGenerarExamen;
        private System.Windows.Forms.Button buttonPreguntas;
        private System.Windows.Forms.Label label1;
    }
}