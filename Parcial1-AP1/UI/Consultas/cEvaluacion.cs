using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_AP1.Entidades;
using Parcial1_AP1.BLL;

namespace Parcial1_AP1.UI.Consultas
{
    public partial class cEvaluacion : Form
    {
        public cEvaluacion()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            List<Evaluacion> lista = new List<Evaluacion>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex) 
                {
                    case 0:
                        lista = EvaluacionBLL.GetList(p => true);
                        break;
                    case 1:
                        try
                        {
                            int ID = Convert.ToInt32(CriteriotextBox.Text);
                            lista = EvaluacionBLL.GetList(p => p.IDEvaluacion1 == ID);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("El criterio para el ID debe ser numerico");
                        }
                        break;
                    case 2:
                        lista = EvaluacionBLL.GetList(p => p.Estudiante1.Contains(CriteriotextBox.Text));
                        break;
                    default:
                        MessageBox.Show("Esta opción no existe");
                        break;
                }
            }
            else
            {
                lista = EvaluacionBLL.GetList(p => true);
            }

            ConsultardataGridView.DataSource = null;
            ConsultardataGridView.DataSource = lista;
        }
    }
}
