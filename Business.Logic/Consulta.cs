using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Consulta : BusinessLogic
    {
        #region Constructores

        public Data.Database.Consulta Database;

        public Consulta()
        {
            Database = new Data.Database.Consulta();
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene todas las Consultas realizadas por un Paciente
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Business.Entities.Consultas Listar(int IdPaciente)
        {
            return Database.Listar(IdPaciente);
        }
        public Business.Entities.Consultas ListarIntervalo(int Id, DateTime FechaInicio, DateTime FechaFin)
        {
            //return Database.Listar(Id,FechaInicio,FechaFin);
            return Database.Listar(Id);
        }
        public int Actualizar(int IdPaciente, Business.Entities.Consulta item)
        {
            return Database.Actualizar(IdPaciente, item);
        }

        public int Borrar(int IdPaciente, int IdObraSocial)
        {
            return Database.Borrar(IdPaciente,IdObraSocial);
        }

        #endregion
    }
}
