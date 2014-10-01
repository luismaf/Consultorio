using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class ObraSocial: Adapter
    {
        /// <summary>
        /// Recupera el listado de Obras Sociales almacenadas en la base de datos
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Una colección de Obras Sociales</returns>
        public Business.Entities.ObrasSociales Listar()
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
                        oComando.CommandText = "obrasocial_listar";

                        //Instanciamos la coleccion de Obras Sociales
                        Business.Entities.ObrasSociales oObrasSociales = new Business.Entities.ObrasSociales();

                        //No usamos DataSets, siempre utilizamos objetos para independizar la estructura de las tablas
                        //en el resto de las capas. Para ellos leemos con el DataReader y creamos los objetos asociados que se esperan

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instancio obra social y el ObraSocial
                                Business.Entities.ObraSocial oObraSocial = new Business.Entities.ObraSocial();

                                oObraSocial.Id = Convert.ToInt32(oLector["id_obrasocial"]); //obrasocial.id_obrasocial
                                oObraSocial.Nombre = Convert.ToString(oLector["nombre"]); //obrasocial.nombre
                                oObraSocial.Estado = (Business.Entities.ObraSocial.Estados) Convert.ToInt32(oLector["estado"]); //ObraSocial.estado

                                //Agregamos el objeto ObraSocial a la coleccion de ObrasSociales
                                oObrasSociales.Add(oObraSocial);
                                oObraSocial = null;
                            }
                        }
                        //retornamos la coleccion
                        return oObrasSociales;
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
