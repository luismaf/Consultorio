using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Afiliado: BusinessLogic
    {
        #region Constructores

        public Data.Database.Afiliado Database;

        public Afiliado()
        {
            Database = new Data.Database.Afiliado();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene el Catalogo de 'Practicas de Consulta'
        /// </summary>
        /// <returns>Coleccion de Practicas</returns>
        public Business.Entities.Afiliados Listar(int Id)
        {
            return Database.Listar(Id);
        }

        public void Actualizar (int Id, Business.Entities.Afiliados items)
        {
            Database.Actualizar(Id, items);
        }

        public void Borrar (int IdPaciente,int IdObraSocial)
        {
            Database.Borrar(IdPaciente, IdObraSocial);
        }

        #endregion
    }
}
