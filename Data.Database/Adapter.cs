using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Adapter
    {
        #region Metodos

        public static MySqlConnection NuevaConexion()
        {
            MySqlConnection oConexion = new MySqlConnection();
            
            try
            {
                //Obtenemos el ConnectionString desde el archivo de configuración
                string strConexion = Utilidades.Configuracion.RecuperarValor("MySQLCnnString"); //string strConexion = "SERVER=localhost; DATABASE=consultorio; UID=root; PASSWORD=mipass;";

                // Instanciamos la Conexión, asignando el connectionString que se recupero del archivo de configuración:
                oConexion = new MySqlConnection(strConexion);

                // Creamos el oComando
                //MySqlCommand oComando = oConexion.CreateCommand();

                //Retornamos el objeto conexion creado
                return oConexion;
            }
            catch (MySqlException exc)
            {
                Utilidades.Log.Registrar("Error de MySQL durante el proceso de conexión a la Base de Datos", exc.Message); //capturamos el error de MySQL
                return null;
            }
            catch (Exception e)
            {
                Utilidades.Log.Registrar("Error General durante el proceso de conexión a la Base de Datos", e.Message); //capturamos cualquier error (distinto al anterior).
                return null;
            }
            finally
            {
                //Eliminar referencias
                //oConexion = null;
            }
        }

        public int ResguardarBaseDeDatos(string ruta)
        {
            MySqlConnection oConexion = NuevaConexion();
            using (oConexion)
            {
                try
                {
                    oConexion.Open();
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        oComando.Connection = oConexion;
                        oComando.CommandType = CommandType.StoredProcedure;
                        oComando.CommandText = "GenerarBackUp";
                        oComando.Parameters.AddWithValue("@ruta", ruta);

                        return Convert.ToInt32(oComando.ExecuteScalar());
                    }
                }
                catch (MySqlException exc)
                {
                    Utilidades.Log.Registrar("Error de MySQL", exc.Message); //capturamos el error de MySQL
                    return -1;
                }
                catch (Exception e)
                {
                    Utilidades.Log.Registrar("Error General", e.Message); //capturamos cualquier error (distinto al anterior).
                    return -1;
                }
                finally
                {
                    oConexion.Close();
                }
            }

        }

        public int RestaurarBaseDeDatos(string ruta)
        {
            MySqlConnection oConexion = NuevaConexion();
            using (oConexion)
            {
                try
                {
                    oConexion.Open();
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        oComando.Connection = oConexion;
                        oComando.CommandType = CommandType.StoredProcedure;
                        oComando.CommandText = "RestaurarBackUp";
                        oComando.Parameters.AddWithValue("@ruta", ruta);

                        return Convert.ToInt32(oComando.ExecuteScalar());
                    }
                }

                catch (MySqlException exc)
                {
                    Utilidades.Log.Registrar("Error de MySQL", exc.Message); //capturamos el error de MySQL
                    return -1;
                }
                catch (Exception e)
                {
                    Utilidades.Log.Registrar("Error General", e.Message); //capturamos cualquier error (distinto al anterior).
                    return -1;
                }
                finally
                {
                    oConexion.Close();
                }
            }

        }

        #endregion
    }
}
