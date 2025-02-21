using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionExamenes
{
    public partial class FormMenu: Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonPreguntas_Click(object sender, EventArgs e)
        {

            FormPreguntas form = new FormPreguntas();
            form.ShowDialog();
        }

        private void buttonGenerarExamen_Click(object sender, EventArgs e)
        {
            FormPreguntas form = new FormPreguntas();
            form.ShowDialog();
        }

        private void buttonCorregirExamen_Click(object sender, EventArgs e)
        {
            FormPreguntas form = new FormPreguntas();
            form.ShowDialog();
        }
    }
}
