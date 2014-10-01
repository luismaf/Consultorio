using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Practica: BusinessLogic
    {
        #region Constructores

        public Data.Database.Practica Database;

        public Practica()
        {
            Database = new Data.Database.Practica();
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene el Catalogo de 'Practicas de Consulta'
        /// </summary>
        /// <returns>Coleccion de Practicas</returns>
        public Business.Entities.Practicas Listar()
        {
            return Database.Listar();
        }

        /* Implementación programada para la 2º etapa del proyecto
         * 
        public int Actualizar(Business.Entities.Practica item)
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
