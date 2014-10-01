using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Consulta : Adapter
    {
        /// <summary>
        /// Obtiene la información de todas las Consultas de un Paciente (cuando Id = null)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns> Una coleccion de Consultas</returns>
        public Business.Entities.Consultas Listar (int IdPaciente)
        {
            //Instanciamos la conexión
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
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
                        oComando.CommandText = "consulta_listar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", IdPaciente);
                        //oComando.Parameters.AddWithValue("@_id_consulta", IdConsulta);

                        //Instanciamos la coleccion de Pacientes, Practicas y Diagnosticos (estas 2 ultimas para busqueda)
                        Business.Entities.Consultas oConsultas = new Business.Entities.Consultas();

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instanciamos la Consulta
                                Business.Entities.Consulta oConsulta = new Business.Entities.Consulta();
                                Business.Entities.Practica oPractica = new Business.Entities.Practica();
                                Business.Entities.Diagnostico oDiagnostico = new Business.Entities.Diagnostico();

                                oConsulta.Id = Convert.ToInt32(oLector["id_consulta"]);
                                oConsulta.Fecha = Convert.ToDateTime(oLector["fecha"]);
                                oPractica.Id = Convert.ToInt32(oLector["id_practica"]); 
                                oPractica.Nombre = Convert.ToString(oLector["nombre_practica"]);
                                oConsulta.DetallePractica = Convert.ToString(oLector["detalle_practica"]);
                                oDiagnostico.Id = Convert.ToInt32(oLector["id_diagnostico"]);
                                oDiagnostico.Nombre = Convert.ToString(oLector["nombre_diagnostico"]);
                                oConsulta.DetalleDiagnostico = Convert.ToString(oLector["detalle_diagnostico"]); 
                                oConsulta.Detalle = Convert.ToString(oLector["detalle_consulta"]); 

                                //agrego el objeto oPractica al objeto oConsulta
                                oConsulta.Practica = oPractica;
                                oConsulta.Diagnostico = oDiagnostico;
                                oPractica = null;
                                oDiagnostico = null;

                                //Agregamos el objeto Consulta a la coleccion de Consultas del Paciente
                                oConsultas.Add(oConsulta);
                                oConsulta = null;
                            }
                        }
                        //retornamos la coleccion
                        return oConsultas;
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
        /// Agrega o Actualiza la información de un Consulta a la base de datos
        /// </summary>
        /// <param name="item">Un objetto Consulta de clase Business.Entities</param>
        /// <returns>Un entero correspondiente al ID del nuevo Consulta agregado</returns>
        public int Actualizar(int IdPaciente, Business.Entities.Consulta item)
        {
            //Instanciamos la conexion         
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
            //try
            //{
                using (oConexion)
                {
                    //Abrimos la conexion
                    oConexion.Open();

                    //Instanciamos el oComando
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        //Asignamos la conexion al oComando
                        oComando.Connection = oConexion;

                        //utilizamos stored procedures
                        oComando.CommandType = CommandType.StoredProcedure;

                        //establecemos el nombre del stored procedure
                        oComando.CommandText = "consulta_actualizar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", IdPaciente);
                        oComando.Parameters.AddWithValue("@_id_consulta", item.Id).Direction = ParameterDirection.InputOutput;
                        oComando.Parameters.AddWithValue("@_id_obrasocial", null);//item.ObraSocial.Id);
                        oComando.Parameters.AddWithValue("@_fecha", item.Fecha);
                        oComando.Parameters.AddWithValue("@_id_practica", item.Practica.Id);
                        oComando.Parameters.AddWithValue("@_id_diagnostico", item.Diagnostico.Id);
                        oComando.Parameters.AddWithValue("@_detalle_practica", item.DetallePractica);
                        oComando.Parameters.AddWithValue("@_detalle_diagnostico", item.DetalleDiagnostico);
                        oComando.Parameters.AddWithValue("@_detalle_consulta", item.Detalle);
                        //oComando.Parameters.AddWithValue("@_estado", item.Estado); //0 deshabilitado, 1 habilitado

                        //Ejecutamos el oComando, que devuelve el Id del Consulta
                        oComando.ExecuteNonQuery();
                        //Si no existe, el parametro de entrada/salida devuelve el nuevo Id, sino null
                        if (!string.IsNullOrEmpty(oComando.Parameters["@_id_consulta"].Value.ToString()))
                            item.Id = Convert.ToInt32(oComando.Parameters["@_id_consulta"].Value);
                        //de todos modos, retornamos siempre el id.
                        return (int) item.Id;
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
        /// Elimina un Consulta de la base de datos
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
                    //Consulta en la base de datos
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        //asignamos la conexion de trabajo
                        oComando.Connection = oConexion;

                        //utilizamos stored procedures
                        oComando.CommandType = CommandType.StoredProcedure;

                        //establecemos el nombre del stored procedure
                        oComando.CommandText = "consulta_borrar";

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
