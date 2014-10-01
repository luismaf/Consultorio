using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Logic
{
    public class BusinessLogic
    {
        #region Metodos

        public int ResguardarBaseDeDatos(string ruta)
        {
            Data.Database.Adapter oAdapter = new Data.Database.Adapter();
            return oAdapter.ResguardarBaseDeDatos(ruta);
        }

        public int RestaurarBaseDeDatos(string ruta)
        {
            Data.Database.Adapter oAdapter = new Data.Database.Adapter();
            return oAdapter.RestaurarBaseDeDatos(ruta);
        }

        #endregion
    }
}
