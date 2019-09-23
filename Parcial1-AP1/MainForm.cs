using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_AP1.UI;
using Parcial1_AP1.UI.Consultas;
using Parcial1_AP1.UI.Registros;

namespace Parcial1_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEvaluacion evaluacion = new rEvaluacion();
            evaluacion.Show();
        }

        private void ConsultarEvaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEvaluacion evaluacion = new cEvaluacion();
            evaluacion.Show();
        }
    }
}
