using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Diagnostico: BusinessLogic
    {
        #region Constructores

        public Data.Database.Diagnostico Database;

        public Diagnostico()
        {
            Database = new Data.Database.Diagnostico();
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene el Catalogo de 'Diagnosticos de Consulta'
        /// </summary>
        /// <returns>Coleccion de Diagnosticos</returns>
        public Business.Entities.Diagnosticos Listar()
        {
            return Database.Listar();
        }

        /* Implementación programada para la 2º etapa del proyecto
         * 
        public int Actualizar(Business.Entities.Diagnostico item)
        {
            return Database.Actualizar(item);
        }

        public int Borrar (int Id)
        {
            return Database.Borrar(Id);
        }
        */

        #endregion
    }
}
