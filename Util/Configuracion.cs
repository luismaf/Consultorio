using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;

namespace Utilidades
{
    public class Configuracion
    {
        #region Metodos

        /// <summary> 
        /// Obtiene las configuraciones desde un archivo de texto
        /// </summary>
        /// <returns>Devuelve el objeto configuracion</returns>
        public static Configuration RecuperarConfiguracion()
        {
            //string ruta; // Path del archivo de configuracion
            Configuration oConfiguracion;  // Objeto configuracion

            // Abre la configuración de acuerdo al entorno de trabajo
            if (System.Web.HttpContext.Current == null)
            {
                // No es un entorno Web
                var ruta = new ExeConfigurationFileMap
                         { 
                             ExeConfigFilename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName + ".config")
                         };
                    // Abre configuracion windows
                oConfiguracion = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(ruta, ConfigurationUserLevel.None);
            }
            else
            {
                // Abre configuracion Web en un entorno Web
                oConfiguracion = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(System.Web.HttpContext.Current.Request.ApplicationPath);
            }

            return oConfiguracion;
        }

        /// <summary>
        /// Obtiene un valor de la configuracion
        /// </summary>
        /// <param name="Key">Una clave (string)</param>
        /// <returns>String </returns>
        public static string RecuperarValor(string key)
        {
            Configuration oConfiguracion; // Objeto configuracion
            string valor;

            try
            {
                // Obtiene configuracion 
                oConfiguracion = RecuperarConfiguracion();

                try
                {
                    // Obtiene valor
                    valor = oConfiguracion.AppSettings.Settings[key].Value;
                }
                catch (Exception ex)
                {
                    // Si no existe crea una exception (KeyNotFoundException)
                    throw new Exception(String.Format("Error: la clave '{0}' no existe en el archivo de configuración.", key), ex);
                }
                return valor;
            }
            finally
            {
                oConfiguracion = null;
            }
        }

        #endregion

    }
}
