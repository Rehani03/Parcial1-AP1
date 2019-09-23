using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_AP1.Entidades;
using Parcial1_AP1.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial1_AP1.BLL
{
    public class EvaluacionBLL
    {
        public static bool Guardar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Evaluacion Buscar(int ID)
        {
            Evaluacion evaluacion = new Evaluacion();
            Contexto db = new Contexto();

            try
            {
                evaluacion = db.Evaluacion.Find(ID);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return evaluacion;
        }

        public static bool Eliminar(int ID)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Evaluacion.Find(ID);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static List<Evaluacion> GetList(Expression<Func<Evaluacion, bool>> evaluacion)
        {
            List<Evaluacion> lista = new List<Evaluacion>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Evaluacion.Where(evaluacion).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }






    }
}
