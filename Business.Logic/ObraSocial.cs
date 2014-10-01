using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class ObraSocial
    {
        #region Constructores

        public Data.Database.ObraSocial Database;

        public ObraSocial()
        {
            Database = new Data.Database.ObraSocial();
        }

        #endregion

        #region Metodos

        /// Obtiene las Obras Sociales disponibles
        /// </summary>
        /// <returns>Coleccion de Obras Sociales</returns>
        public Business.Entities.ObrasSociales Listar()
        {
            return Database.Listar();
        }
        /* Implementación programada para la 2º etapa del proyecto
         * 
        public int Actualizar(Business.Entities.ObraSocial item)
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
