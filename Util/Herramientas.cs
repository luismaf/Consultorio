using System;
//using System.Collections.Generic;
using System.Configuration;
using System.Web;

namespace Utilidades
{
    public class Herramientas
    {

        /// <summary>
        /// Obtiene un string que solo contiene digitos (numeros enteros)
        /// </summary>
        /// <returns>Devuelve una cadena de numeros (string) </returns>
        public static string soloNumeros(string Texto)
        {
            for (int j = 0; j < Texto.Length; j++)
            {
                if (!Char.IsDigit(Texto, j))
                {
                    Texto = Texto.Remove(j, 1);
                    j--;
                }
            }
            return Texto;
        }

        /// <summary>
        /// Obtiene la ruta de la aplicación
        /// </summary>
        /// <returns>Devuelve una ruta (string) </returns>
        public static string RutaDeLaAplicacion()
        {
            if (System.Web.HttpContext.Current == null)
            {
                // No es un entorno Web
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);
            }
            else
            {
                // Entorno Web
                return System.Web.HttpContext.Current.Request.ApplicationPath;
            }
        }

        /// <summary>
        /// Determina si una cadena de texto esta vacia o es null
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>devuelve true si la cadena esta vacia</returns>
        public static bool esVacio(string texto)
        {
            if (texto == null || texto.Trim() == "") return true;
            else return false;
        }
    }
}
