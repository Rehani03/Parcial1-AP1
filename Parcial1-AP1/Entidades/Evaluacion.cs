using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.Entidades
{
    public class Evaluacion
    {
        private int IDEvaluacion;
        private DateTime fecha;
        private string Estudiante;
        private int valor;
        private decimal logadro;
        private decimal perdido;
        private int pronostico;

        public Evaluacion()
        {

        }

        [Key]
        public int IDEvaluacion1 { get ; set; }
        public DateTime Fecha { get ; set ; }
        public string Estudiante1 { get ; set ; }
        public int Valor { get ; set ; }
        public decimal Logadro { get ; set; }
        public decimal Perdido { get ; set ; }
        public int Pronostico { get ; set; }
    }
}
