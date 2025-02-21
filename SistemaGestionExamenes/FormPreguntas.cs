using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionExamenes
{
    public partial class FormPreguntas: Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string preguntaId = Guid.NewGuid().ToString();
            string pregunta = textBoxIngresarPregunta.Text;
            string respuestas = $"{txtRespuesta1.Text}|{txtRespuesta2.Text}|{txtRespuesta3.Text}|{txtRespuesta4.Text}";
            string correcta = comboBoxRespuestaCorrecta.SelectedItem.ToString();
            string asignatura = comboBoxAsignatura.SelectedItem.ToString();

            string linea = $"{preguntaId},{pregunta},{respuestas},{correcta},{asignatura}";

            File.AppendAllText("Preguntas.txt", linea + Environment.NewLine);
            MessageBox.Show("Pregunta guardada con éxito");
        }
    }
}
