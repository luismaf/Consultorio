using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Consulta : BusinessEntitiy
    {
        #region Propiedades
        //public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public Business.Entities.Practica Practica { get; set; }
        public string DetallePractica { get; set; }
        public Business.Entities.Diagnostico Diagnostico { get; set; }
        public string DetalleDiagnostico { get; set; }
           
        #endregion

        #region Constructores

        public Consulta()
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
            this.Fecha = DateTime.Now;
            this.Detalle = "";
            this.DetallePractica = "";
            this.DetalleDiagnostico = "";
            //this.Diagnostico = null;
            //this.Practica = null;
        }
        #endregion
    }
}
