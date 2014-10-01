using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Paciente: Adapter
    {
        /// <summary>
        /// Obtiene la información de todos los Pacientes
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Coleccion de Pacientes</returns>
        public Business.Entities.Pacientes Listar()
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
                        oComando.CommandText = "paciente_listar";

                        //asignamos parámetros
                        //oComando.Parameters.AddWithValue("@_id_paciente", Id);

                        //Instanciamos la coleccion de Pacientes
                        Business.Entities.Pacientes oPacientes = new Business.Entities.Pacientes();

                        //Instanciamos el Objeto Afiliado de la capa de datos para agregar los Afiliados al Paciente
                        Data.Database.Afiliado oAfiliadoData = new Data.Database.Afiliado();

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instanciamos al Paciente y la coleccion de Afiliados
                                Business.Entities.Paciente oPaciente = new Business.Entities.Paciente();
                                //Business.Entities.Afiliados oAfiliados = new Business.Entities.Afiliados();
                                
                                oPaciente.Id = Convert.ToInt32(oLector["id_paciente"]);
                                oPaciente.Nombre = Convert.ToString(oLector["nombre"]);
                                oPaciente.Apellido = Convert.ToString(oLector["apellido"]);
                                oPaciente.TipoDoc = (Business.Entities.Paciente.TiposDoc) Convert.ToInt32(oLector["tipo_doc"]);
                                oPaciente.NumeroDoc = Convert.ToInt32(oLector["numero_doc"]);
                                if (oLector["fecha_nac"] is DBNull)
                                    oPaciente.FechaNac = null;
                                else 
                                    oPaciente.FechaNac = Convert.ToDateTime(oLector["fecha_nac"]);
                                oPaciente.GrupoSanguineo = (Business.Entities.Paciente.GruposSanguineos) Convert.ToInt32(oLector["grupo_sanguineo"]);
                                oPaciente.Factor = (Business.Entities.Paciente.FactoresSanguineos) Convert.ToInt32(oLector["factor_sanguineo"]);
                                oPaciente.Domicilio = Convert.ToString(oLector["domicilio"]);
                                oPaciente.Telefono = Convert.ToString(oLector["telefono"]);
                                oPaciente.Celular = Convert.ToString(oLector["celular"]);
                                oPaciente.Email = Convert.ToString(oLector["email"]);
                                oPaciente.Problemas = Convert.ToString(oLector["problemas"]);
                                oPaciente.Notas = Convert.ToString(oLector["notas"]);

                                //recupero y asigno la colección de Afiliados de cada Pacientes
                                oPaciente.Afiliados = oAfiliadoData.Listar((int)oPaciente.Id);


                                /* MySqlDataReader LectorAnidado = oLector.GetDataReader(1);
                                while (oLector.NextResult())
                                {
                                    //Inicializo obra social y el afiliado
                                    
                                    Business.Entities.Afiliado oAfiliado = new Business.Entities.Afiliado();

                                    oAfiliado.Id = Convert.ToInt32(oLector["nro_afiliado"]); //afiliado.nro_afiliado
                                    oAfiliado.Estado = (Business.Entities.Afiliado.Estados) oLector["estado"]; //afiliado.estado

                                    //buscamos y agregamos la obra social al objeto oAfiliado
                                    oAfiliado.ObraSocial = oObrasSociales.Find(
                                    delegate(Business.Entities.ObraSocial oObraSocial)
                                    {
                                        return oObraSocial.Id == Convert.ToInt32(oLector["id_obrasocial"]); //obrasocial.id_obrasocial
                                    }
                                    );
                                    //Agregamos el objeto Afiliado a la coleccion de Afiliados del Paciente
                                    oPaciente.Afiliados.Add(oAfiliado);
                                    //oAfiliados.Add(oAfiliado);
                                    oAfiliado = null;
                                 
                                    //Agregamos el objeto a la coleccion
                                    oPacientes.Add(oPaciente);
                                    oPaciente = null;
                                }//*/

                                //Agregamos el objeto a la coleccion
                                oPacientes.Add(oPaciente);
                                oPaciente = null;

                            }
                        }
                        //retornamos la coleccion
                        return oPacientes;
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
        /// Agrega o Actualiza la información de un Paciente a la base de datos
        /// </summary>
        /// <param name="item">Un objetto Paciente de clase Business.Entities</param>
        /// <returns>Un entero correspondiente al ID del nuevo Paciente agregado</returns>
        public int Actualizar (Business.Entities.Paciente item)
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
                        oComando.CommandText = "paciente_actualizar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", item.Id).Direction = ParameterDirection.InputOutput; ;
                        oComando.Parameters.AddWithValue("@_nombre", item.Nombre);
                        oComando.Parameters.AddWithValue("@_apellido", item.Apellido);
                        oComando.Parameters.AddWithValue("@_tipo_doc", (int) item.TipoDoc.Value);
                        oComando.Parameters.AddWithValue("@_numero_doc", item.NumeroDoc);
                        oComando.Parameters.AddWithValue("@_fecha_nac", item.FechaNac);
                        oComando.Parameters.AddWithValue("@_grupo_sanguineo", (int) item.GrupoSanguineo.Value);
                        oComando.Parameters.AddWithValue("@_factor_sanguineo", (int) item.Factor.Value);
                        oComando.Parameters.AddWithValue("@_domicilio", item.Domicilio);
                        oComando.Parameters.AddWithValue("@_telefono", item.Telefono);
                        oComando.Parameters.AddWithValue("@_celular", item.Celular);
                        oComando.Parameters.AddWithValue("@_email", item.Email);
                        oComando.Parameters.AddWithValue("@_problemas", item.Problemas);
                        oComando.Parameters.AddWithValue("@_notas", item.Notas);
	                    
                        //ejecutamos el oComando
                        oComando.ExecuteNonQuery();
                         //Si no existe, el parametro de entrada/salida devuelve el nuevo Id, sino null
                        if (! string.IsNullOrEmpty(oComando.Parameters["@_id_paciente"].Value.ToString()))
                            item.Id = Convert.ToInt32(oComando.Parameters["@_id_paciente"].Value);
                        //de todos modos, siempre retornamos el id.
                        return (int)item.Id;
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
            }*/           
        }


        /// <summary>
        /// Elimina un Paciente de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        public int Borrar(int Id)
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
                    //Paciente en la base de datos
                    MySqlCommand oComando = oConexion.CreateCommand();
                    using (oComando)
                    {
                        //asignamos la conexion de trabajo
                        oComando.Connection = oConexion;

                        //utilizamos stored procedures
                        oComando.CommandType = CommandType.StoredProcedure;

                        //establecemos el nombre del stored procedure
                        oComando.CommandText = "paciente_borrar";

                        //asignamos parámetros
                        oComando.Parameters.AddWithValue("@_id_paciente", Id);

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
            }*/
        }
    }
}
