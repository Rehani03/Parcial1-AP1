using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Evaluacion e = new Evaluacion();
            e.IDEvaluacion1 = 0;
            e.Estudiante1 = "Pedro";
            e.Fecha = DateTime.Now;
            e.Valor = 31;
            e.Logadro = 20;
            e.Perdido = 14;
            e.Pronostico = 1;
            bool paso = EvaluacionBLL.Guardar(e);
            
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}