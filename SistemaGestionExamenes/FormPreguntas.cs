using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestionExamenes
{
    public partial class FormPreguntas : Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
            CargarAsignaturas();
            LlenarComboBoxRespuestas();

            this.textBoxOpcion1.TextChanged += new System.EventHandler(this.txtRespuesta1_TextChanged);
            this.textBoxOpcion2.TextChanged += new System.EventHandler(this.txtRespuesta2_TextChanged);
            this.textBoxOpcion3.TextChanged += new System.EventHandler(this.txtRespuesta3_TextChanged);
            this.textBoxOpcion4.TextChanged += new System.EventHandler(this.txtRespuesta4_TextChanged);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIngresarPregunta.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta1.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta2.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta3.Text) ||
                string.IsNullOrWhiteSpace(txtRespuesta4.Text) ||
                comboBoxAsignatura.SelectedItem == null ||
                comboBoxRespuestaCorrecta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string preguntaId = Guid.NewGuid().ToString();
                string pregunta = textBoxIngresarPregunta.Text;
                string respuestas = $"{txtRespuesta1.Text}|{txtRespuesta2.Text}|{txtRespuesta3.Text}|{txtRespuesta4.Text}";
                string correcta = comboBoxRespuestaCorrecta.SelectedItem.ToString();
                string asignatura = comboBoxAsignatura.SelectedItem.ToString();
                string unidad = textBoxUnidad.Text;
                string subunidad = textBoxSubunidad.Text;

                string linea = $"{preguntaId},{pregunta},{respuestas},{correcta},{asignatura},{unidad},{subunidad}";
                File.AppendAllText("Preguntas.txt", linea + Environment.NewLine);

                MessageBox.Show("Pregunta guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la pregunta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            textBoxIngresarPregunta.Text = "";
            txtRespuesta1.Text = "";
            txtRespuesta2.Text = "";
            txtRespuesta3.Text = "";
            txtRespuesta4.Text = "";
            comboBoxRespuestaCorrecta.Items.Clear();
            comboBoxRespuestaCorrecta.SelectedIndex = -1;
            comboBoxAsignatura.SelectedIndex = -1;
        }

        private void LlenarComboBoxRespuestas()
        {
            comboBoxRespuestaCorrecta.Items.Clear();  
            if (!string.IsNullOrWhiteSpace(textBoxOpcion1.Text)) comboBoxRespuestaCorrecta.Items.Add(textBoxOpcion1.Text);
            if (!string.IsNullOrWhiteSpace(textBoxOpcion2.Text)) comboBoxRespuestaCorrecta.Items.Add(textBoxOpcion2.Text);
            if (!string.IsNullOrWhiteSpace(textBoxOpcion3.Text)) comboBoxRespuestaCorrecta.Items.Add(textBoxOpcion3.Text);
            if (!string.IsNullOrWhiteSpace(textBoxOpcion4.Text)) comboBoxRespuestaCorrecta.Items.Add(textBoxOpcion4.Text);

            if (comboBoxRespuestaCorrecta.Items.Count > 0)
            {
                comboBoxRespuestaCorrecta.SelectedIndex = 0; 
            }
        }

        private void CargarAsignaturas()
        {
            comboBoxAsignatura.Items.Add("Matemáticas");
            comboBoxAsignatura.Items.Add("Historia");
            comboBoxAsignatura.Items.Add("Ciencias");
            comboBoxAsignatura.Items.Add("Lengua");
        }


        private void txtRespuesta1_TextChanged(object sender, EventArgs e)
        {
            LlenarComboBoxRespuestas();
        }

        private void txtRespuesta2_TextChanged(object sender, EventArgs e)
        {
            LlenarComboBoxRespuestas();
        }

        private void txtRespuesta3_TextChanged(object sender, EventArgs e)
        {
            LlenarComboBoxRespuestas();
        }

        private void txtRespuesta4_TextChanged(object sender, EventArgs e)
        {
            LlenarComboBoxRespuestas();
        }
    }
}
