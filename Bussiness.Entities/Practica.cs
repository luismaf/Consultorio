using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Practica : BusinessEntitiy
    {
        #region Propiedades

        //public int Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constructores

        public Practica()
        {
            this.Inicializar();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Inicializa la entidad a los valores por defecto 
        /// </summary>
        public void Inicializar()
        {
            this.Id = null;
            this.Nombre = "";
        }
        #endregion
    }
}
