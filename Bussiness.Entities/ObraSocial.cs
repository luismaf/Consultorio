using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class ObraSocial : BusinessEntitiy
    {
        #region Enumeradores

        public enum Estados
        {
            Deshabilitada = 1,
            Habilitada = 0,
        }
        #endregion

        #region Propiedades

        //public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<Estados> Estado { get; set; }
 
        #endregion

        #region Constructores

        public ObraSocial()
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
            this.Nombre = "";
        }
        #endregion
    }
}
