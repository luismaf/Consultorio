using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class Usuario
    {
        #region Constructores

        public Usuario()
        {
            Database = new Data.Database.Usuario();
        }

        #endregion

        #region Metodos

        public Data.Database.Usuario Database = new Data.Database.Usuario();
        /// <summary>
        /// Valida un usuario
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Clave"></param>
        /// <returns>Devuelve true si el usuario es valido, o false en caso contrario</returns>
        public string Validar(string Usuario, string Clave)
        {
            return Database.Validar(Usuario, Clave);
        }
        #endregion
    }
}
