using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Diagnostico: Adapter
    {
        /// <summary>
        /// Recupera el catalogo de Diagnosticos de Consulta
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Una colección de Diagnosticos de Consulta</returns>
        public Business.Entities.Diagnosticos Listar()
        {
            //Instanciamos la conexión
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
            DataSet result = new DataSet();
            //try
            //{
                using (oConexion)
                {
                    //abrimos conexion
                    oConexion.Open();

                    //Instanciamos el oComando
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        //asignamos la conexion
                        oComando.Connection = oConexion;

                        //utilizamos stored procedures
                        oComando.CommandType = CommandType.StoredProcedure;

                        //establecemos el nombre del stored procedure
                        oComando.CommandText = "diagnostico_listar";

                        //Instanciamos la coleccion de Diagnosticos
                        Business.Entities.Diagnosticos oDiagnosticos = new Business.Entities.Diagnosticos();

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instancio obra social y el Diagnostico
                                Business.Entities.Diagnostico oDiagnostico = new Business.Entities.Diagnostico();

                                oDiagnostico.Id = Convert.ToInt32(oLector["id_diagnostico"]); //diagnostico.id_Diagnostico
                                oDiagnostico.Nombre = Convert.ToString(oLector["nombre"]); //diagnostico.nombre

                                //Agregamos el objeto Diagnostico a la coleccion de Diagnosticos
                                oDiagnosticos.Add(oDiagnostico);
                                oDiagnostico = null;
                            }
                        }
                        //retornamos la coleccion
                        return oDiagnosticos;
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
}
