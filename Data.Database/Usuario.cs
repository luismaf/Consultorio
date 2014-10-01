using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Usuario : Adapter
    {
        /// <summary>
        /// Autentifica un Usuario
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Clave"></param>
        /// <returns>Null o Nombre del Usuario</returns>
        public string Validar(string Usuario, string Clave)
        {
            //try
            //{
            //Instanciamos la conexión       
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();

            using (oConexion)
            {
                //abrimos conexion
                oConexion.Open();

                //Instanciamos un commando
                MySqlCommand oComando = oConexion.CreateCommand();
                using (oComando)
                {
                    string Nombre = null;
                    //asignamos la conexion al oComando
                    oComando.Connection = oConexion;

                    //utilizamos stored procedures
                    oComando.CommandType = CommandType.StoredProcedure;

                    //establecemos el nombre del stored procedure
                    oComando.CommandText = "usuario_validar";

                    //asignamos parámetros
                    oComando.Parameters.AddWithValue("@_usuario", Usuario).Direction = ParameterDirection.Input;
                    oComando.Parameters.AddWithValue("@_password", Clave).Direction = ParameterDirection.Input;
                    oComando.Parameters.AddWithValue("@_nombre", Nombre).Direction = ParameterDirection.Output;


                    //ejecutamos el oComando, si afectó a mas de una celda, entonces encontró conincidencia y el usuario es válido
                    oComando.ExecuteNonQuery();
                    Nombre = Convert.ToString(oComando.Parameters["@_nombre"].Value);
                    if (Nombre.Trim() != "") return Nombre;
                    else return null;
                }
            }
        }
        /*}
            catch (MySqlException exc)
            {
                Utilidades.Log.Registrar("Error de MySQL", exc.Message); //capturamos el error de MySQL
                return null;
            }
            catch (Exception e)
            {
                Utilidades.Log.Registrar("Error General", e.Message); //capturamos cualquier error (distinto al anterior).
                return null;
            }
            finally
            {
                oConexion.Close();
            }//*/
    }
}
