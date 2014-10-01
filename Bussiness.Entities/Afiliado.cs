using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Afiliado : BusinessEntitiy
    {
       
        #region Enumeradores

        public enum Estados
        {
            Deshabilitado = 1,
            Habilitado = 0,
        }
        #endregion

        #region Propiedades

        //public int Id { get; set; }
        //public int NroAfiliado { get; set; }
        public Nullable<Estados> Estado { get; set; }
        public Business.Entities.ObraSocial ObraSocial { get; set; }
               
        #endregion
        
        #region Constructores

        public Afiliado()
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
            this.Estado = Business.Entities.Afiliado.Estados.Habilitado;
        }
        #endregion
    }
}
