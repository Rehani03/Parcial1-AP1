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
       
        public rEvaluacion()
        {
            InitializeComponent();
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
            MyErrorProvider.Clear();
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
            decimal auxLogrado, auxPerdido, auxValor;

            e.IDEvaluacion1 = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);
            e.Estudiante1 = EstudiantetextBox.Text;
            auxValor = e.Valor = Convert.ToDecimal(ValortextBox.Text);
            auxLogrado = e.Logadro = Convert.ToDecimal(LogradotextBox.Text);
            auxPerdido = auxValor - auxLogrado;

            e.Pronostico = CondicionPronostico(auxPerdido);
            e.Fecha = FechadateTimePicker.Value;
            e.Perdido = auxPerdido;

            return e;
        }

        private int CondicionPronostico(decimal auxPerdido)
        {
            int aux=0;
            if (auxPerdido < 25)
                return aux = 0;
            if (auxPerdido >= 25 && auxPerdido <= 30)
                return aux = 1;
            if (auxPerdido > 30)
                return aux = 2;

            return aux;
        }

        private bool Validar()
        {
            bool paso = true;
            decimal valor = 0, logrado = 0;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyErrorProvider.SetError(EstudiantetextBox, "El campo estudiante no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                MyErrorProvider.SetError(ValortextBox, "El campo Valor no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                MyErrorProvider.SetError(LogradotextBox, "El campo logrado no puede estar vacio.");
                paso = false;
            }

            try
            {
                valor = Convert.ToDecimal(ValortextBox.Text);
                
            }
            catch (Exception)
            {

                MyErrorProvider.SetError(ValortextBox, "El campo valor debe ser numerico.");
                paso = false;
            }

            try
            {
                logrado = Convert.ToDecimal(LogradotextBox.Text);

            }
            catch (Exception)
            {

                MyErrorProvider.SetError(ValortextBox, "El campo logrado debe ser numerico.");
                paso = false;
            }

            if(valor < 0)
            {
                MyErrorProvider.SetError(ValortextBox, "El campo valor no puede ser menor a cero.");
                paso = false;
            }

            if(logrado < 0)
            {
                MyErrorProvider.SetError(LogradotextBox, "El campo logrado no ser menor a cero.");
                paso = false;
            }

            return paso;
        }

        private bool ValidarTareasProyecto()
        {
            bool paso = true;
            decimal valor = 0, logrado=0;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                MyErrorProvider.SetError(ValortextBox, "El campo Valor no puede estar vacio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                MyErrorProvider.SetError(LogradotextBox, "El campo logrado no puede estar vacio.");
                paso = false;
            }

            try
            {
                valor = Convert.ToDecimal(ValortextBox.Text);

            }
            catch (Exception)
            {

                MyErrorProvider.SetError(ValortextBox, "El campo valor debe ser numerico.");
                paso = false;
            }

            try
            {
                logrado = Convert.ToDecimal(LogradotextBox.Text);

            }
            catch (Exception)
            {

                MyErrorProvider.SetError(LogradotextBox,"El campo logrado debe ser numerico.");
                paso = false;
            }

            if (valor < 0)
            {
                MyErrorProvider.SetError(ValortextBox, "El campo valor no puede ser menor a cero.");
                paso = false;
            }

            if (logrado < 0)
            {
                MyErrorProvider.SetError(LogradotextBox, "El campo logrado no ser menor a cero.");
                paso = false;
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
            Evaluacion evaluacion = new Evaluacion();

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
                MessageBox.Show("Evaluación no encontrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void LogradotextBox_TextChanged(object sender, EventArgs e)
        {
            decimal valor, logrado, perdido;

             if (!ValidarTareasProyecto())
                return;

            try
            {
                valor = Convert.ToDecimal(ValortextBox.Text);
                logrado = Convert.ToDecimal(LogradotextBox.Text);
                perdido = valor - logrado;  
                PerdidotextBox.Text = perdido.ToString();
                PronosticocomboBox.SelectedIndex = CondicionPronostico(perdido);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);
            bool paso;

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                return;
            }

            paso = EvaluacionBLL.Eliminar(ID);
            if (paso)
            {
                LimpiarCampos();
                MessageBox.Show("Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
