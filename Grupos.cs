using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doutorado
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            PersonalidadeCasal newPersonalidadeCasal = new PersonalidadeCasal();
            newPersonalidadeCasal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            PersonalidadeSolteiro newPersonalidadeSolteiro = new PersonalidadeSolteiro();
            newPersonalidadeSolteiro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Resultados newResultados = new Resultados();
            newResultados.ShowDialog();
        }
    }
}
