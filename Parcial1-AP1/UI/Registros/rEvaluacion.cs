using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1.UI.Registros
{
    public partial class rEvaluacion : Form
    {
        private const int VALOR = 31;
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void EstudiantetextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LimpiarCampos()
        {
            MyErrorProvider.Clear();
            IDEvaluacionnumericUpDown.Value = 0;
            EstudiantetextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            ValortextBox.Text = string.Empty;
            LogradotextBox.Text = string.Empty;
            PerdidotextBox.Text = string.Empty;
            PronosticocomboBox.Text = string.Empty;
        }

        private void LlenaCampos(Evaluacion e)
        {
            IDEvaluacionnumericUpDown.Value = e.IDEvaluacion1;
            EstudiantetextBox.Text = e.Estudiante1;
            FechadateTimePicker.Value = e.Fecha;
            ValortextBox.Text = Convert.ToString(e.Valor);
            LogradotextBox.Text = Convert.ToString(e.Logadro);
            PerdidotextBox.Text = Convert.ToString(e.Perdido);
            if (e.Pronostico == 1)
            {
                PronosticocomboBox.Text = "Continuar";
                PronosticocomboBox.Show();
            }
            if (e.Pronostico == 2)
            {
                PronosticocomboBox.Text = "Suspenso";
                PronosticocomboBox.Show();
            }
            if (e.Pronostico == 3)
            {
                PronosticocomboBox.Text = "Retirar";
                PronosticocomboBox.Show();
            }
        }

        private Evaluacion LlenaClase()
        {
            Evaluacion e = new Evaluacion();

            e.IDEvaluacion1 = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);
            e.Estudiante1 = EstudiantetextBox.Text;
            e.Valor = VALOR;

            decimal auxLogrado, auxPerdido;
            auxLogrado = e.Logadro = Convert.ToDecimal(LogradotextBox.Text);
            auxPerdido = VALOR - auxLogrado;
            if (auxPerdido <= 25)
                e.Pronostico = 1;
            if (auxPerdido >= 25 && auxPerdido <= 30)
                e.Pronostico = 2;
            if (auxPerdido > 30)
                e.Pronostico = 3;

            e.Perdido = auxPerdido;

            return e;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyErrorProvider.SetError(EstudiantetextBox, "El campo estudiante no puede estar vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                MyErrorProvider.SetError(LogradotextBox, "El campo logrado no puede estar vacio");
                paso = false;
            }
            else
            {
                try
                {
                    decimal logrado = Convert.ToDecimal(LogradotextBox.Text);
                }
                catch (Exception)
                {
                    MyErrorProvider.SetError(LogradotextBox, "El campo logrado debe ser numerico");
                    paso = false;
                }
            }

            return paso;
        }

        private bool Existe()
        {
            Evaluacion e = EvaluacionBLL.Buscar((int)IDEvaluacionnumericUpDown.Value);
            return (e != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Gurdarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            Evaluacion evaluacion;

            if (!Validar())
                return;

            evaluacion = LlenaClase();

            if(IDEvaluacionnumericUpDown.Value == 0)
            {
                paso = EvaluacionBLL.Guardar(evaluacion);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EvaluacionBLL.Modificar(evaluacion);
            }

            if (paso)
            {
                LimpiarCampos();
                MessageBox.Show("Guardado!");
            }
            else
            {
                MessageBox.Show("No se pudo Guardar!");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Evaluacion evaluacion = new Evaluacion();

            int ID = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);

            evaluacion = EvaluacionBLL.Buscar(ID);

            if (evaluacion != null)
            {
                LimpiarCampos();
                LlenaCampos(evaluacion);
            }
            else
            {
                MessageBox.Show("Evaluación no encontrada");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);
            bool paso;

            paso = EvaluacionBLL.Eliminar(ID);

            if (paso)
            {
                MessageBox.Show("Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
