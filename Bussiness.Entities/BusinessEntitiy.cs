using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class BusinessEntitiy : IDisposable
    {
        #region Enumeradores

        /// <summary>
        /// Enumeración de estados
        /// </summary>
        ///
        public enum EstadosObj { Nuevo, Modificado, NoModificado, Eliminado }

        #endregion

        #region Constructores
        public BusinessEntitiy()
        {
            this.Id = null;
            this.EstadoObj = EstadosObj.Nuevo;
        }
        public void Dispose()
        {
            this.Dispose();
        }

        #endregion

        #region Propiedades

        public Nullable<int> Id { get; set; }
        public EstadosObj EstadoObj { get; set; }

        #endregion
    }
}
