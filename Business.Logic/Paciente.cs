using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Paciente : BusinessLogic
    {       
        #region Constructores

        public Data.Database.Paciente Database;

        public Paciente()
        {
            Database = new Data.Database.Paciente();
        }

        #endregion

        #region Metodos

        public Business.Entities.Pacientes Listar ()
        {
            return Database.Listar();
        }

        public int Actualizar(Business.Entities.Paciente item)
        {
            return Database.Actualizar(item);
        }

        public int Borrar (int Id)
        {
            return Database.Borrar(Id);
        }

        #endregion



    }
}
