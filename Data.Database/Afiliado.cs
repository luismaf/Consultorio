using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/

namespace Data.Database
{
    public class Afiliado: Adapter
    {
        /// <summary>
        /// Obtiene infromación de Afiliación a Obras Sociales de un Paciente
        /// </summary>
        /// <param name="Id"></param>
        /// <returns> Una coleccion de Afiliados</returns>
        public Business.Entities.Afiliados Listar(int Id)
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
                        oComando.CommandText = "afiliado_listar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", Id);

                        //Instanciamos la coleccion de Afiliados
                        Business.Entities.Afiliados oAfiliados = new Business.Entities.Afiliados();

                        //Instanciamos la coleccion de Obras Sociales = para buscar en ella
                        ///Business.Entities.ObrasSociales oObrasSociales = new Business.Entities.ObrasSociales();


                        //Instanciamos la coleccion de Obras Sociales para buscar en ella
                        Data.Database.ObraSocial oObraSocialDatos = new Data.Database.ObraSocial();

                        //Recupero la colección de todos las Obras Sociales desde la base de datos.

                        // Obtener la coleccion de Obras Sociales
                        Business.Entities.ObrasSociales oObrasSociales = new Business.Entities.ObrasSociales();
                        oObrasSociales =  oObraSocialDatos.Listar();

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instanciamos al Afiliado y la coleccion de Afiliados
                                Business.Entities.Afiliado oAfiliado = new Business.Entities.Afiliado();

                                //Buscamos y agregamos la obra social al objeto oAfiliado
                                oAfiliado.ObraSocial = oObrasSociales.Find(
                                delegate(Business.Entities.ObraSocial oObraSocial)
                                {
                                    return oObraSocial.Id == Convert.ToInt32(oLector["id_obrasocial"]); //obrasocial.id_obrasocial
                                }
                                );

                                oAfiliado.Id = Convert.ToInt32(oLector["nro_afiliado"]); //afiliado.nro_afiliado
                                //este stored procedure solo recupera los afiliados con estado habilitado, por lo tanto:
                                oAfiliado.Estado = Business.Entities.Afiliado.Estados.Habilitado; //(Business.Entities.Afiliado.Estados)Convert.ToInt32(oLector["estado"]); //afiliado.estado

                                //Agregamos el objeto Afiliado a la coleccion de Afiliados del Afiliado
                                oAfiliados.Add(oAfiliado);
                                //oAfiliados.Add(oAfiliado);
                                oAfiliado = null;
                            }
                        }
                        //retornamos la coleccion
                        return oAfiliados;
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

        /// <summary>
        /// Agrega o Actualiza la información de un Afiliado a la base de datos
        /// </summary>
        /// <param name="item">Un objetto Afiliado de clase Business.Entities</param>
        /// <returns>Un entero correspondiente al ID del nuevo Afiliado agregado</returns>
        public void Actualizar(int IdPaciente, Business.Entities.Afiliados items)
        {
            //Instanciamos la conexion         
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
            //try
            //{
                using (oConexion)
                {
                    //Abrimos la conexion
                    oConexion.Open();
                    foreach (Business.Entities.Afiliado item in items)
                    {
                        //Instanciamos el oComando
                        MySqlCommand oComando = oConexion.CreateCommand();
                        using (oComando)
                        {
                            //Asignamos la conexion al oComando
                            oComando.Connection = oConexion;

                            //utilizamos stored procedures
                            oComando.CommandType = CommandType.StoredProcedure;

                            //establecemos el nombre del stored procedure
                            oComando.CommandText = "afiliado_actualizar";

                            //asignamos parámetros
                            oComando.Parameters.AddWithValue("@_id_obrasocial", item.ObraSocial.Id);
                            oComando.Parameters.AddWithValue("@_id_paciente", IdPaciente);
                            oComando.Parameters.AddWithValue("@_nro_afiliado", item.Id);

                            //este stored procedure no recibe el aggumento "estado" ya que todos estan habilitados, se utiliza borrar para hacer un borrado logico.
                            //oComando.Parameters.AddWithValue("@_estado", item.Estado); //0 deshabilitado, 1 habilitado

                            //Ejecutamos el oComando, (no devuelve nada)
                            oComando.ExecuteNonQuery();
                        }
                    }
                }
            /*}
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
            }//*/
        }


        /// <summary>
        /// Elimina un Afiliado de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        public int Borrar(int IdPaciente, int IdObraSocial)
        {
            //Instanciamos la conexión
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
            //try
            //{
                using (oConexion)
                {
                    //abrimos conexion
                    oConexion.Open();

                    //Creamos un commando para realizar el alta del
                    //Afiliado en la base de datos
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        //asignamos la conexion de trabajo
                        oComando.Connection = oConexion;

                        //utilizamos stored procedures
                        oComando.CommandType = CommandType.StoredProcedure;

                        //establecemos el nombre del stored procedure
                        oComando.CommandText = "afiliado_borrar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", IdPaciente);
                        oComando.Parameters.AddWithValue("@_id_obrasocial", IdObraSocial);

                        //Ejecutamos el oComando
                        return Convert.ToInt32(oComando.ExecuteNonQuery());
                    }
                }
            /*}
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
            }//*/
        }
    }
}
