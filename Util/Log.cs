using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Utilidades
{
    public class Log
    {
        private static StreamWriter oEscritor = new StreamWriter(Utilidades.Herramientas.RutaDeLaAplicacion() + ".log", true);

        #region Constructores
        /*public Log(){
            string ruta = Utilidades.Herramientas.RutaDeLaAplicacion() + ".log";
            StreamWriter oEscritor = new StreamWriter(ruta, true);
        }*/
        #endregion

        #region Metodos
        public static void Registrar(string mensaje) {
            oEscritor.WriteLine(string.Format("[{0}] [advertencia] {1}", DateTime.Now, mensaje));
            oEscritor.Flush();
        }
        public static void Registrar(string tipo, string mensaje) {
            oEscritor.WriteLine(string.Format("[{0}] [{1}] {2}", DateTime.Now, tipo, mensaje));
            oEscritor.Flush();
        }
        
        public void Dispose()
        {
            oEscritor.Flush();
            oEscritor.Close();
            oEscritor.Dispose();
        }
        #endregion
    }
}
