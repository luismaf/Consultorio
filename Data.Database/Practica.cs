using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient; // para utlizalo debemos agregar una referencia a "MySql.Data"
//previamente debe instalarse el conector particular para MySQL, descargalo desde aqui: http://www.mysql.com/downloads/connector/net/


namespace Data.Database
{
    public class Practica : Adapter
    {
        /// <summary>
        /// Recupera el catalogo de Practicas de Consulta
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Una colección de Practicas de Consulta</returns>
        public Business.Entities.Practicas Listar()
        {
            //Instanciamos la conexión
            MySqlConnection oConexion = Data.Database.Adapter.NuevaConexion();
            DataSet result = new DataSet();
           // try
           // {
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
                        oComando.CommandText = "practica_listar";

                        //Instanciamos la coleccion de Practicas
                        Business.Entities.Practicas oPracticas = new Business.Entities.Practicas();

                        //Ejecutamos el oComando y retornamos los valores
                        MySqlDataReader oLector = oComando.ExecuteReader();
                        using (oLector)
                        {
                            //si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            while (oLector.Read())
                            {
                                //Instancio obra social y el Practica
                                Business.Entities.Practica oPractica = new Business.Entities.Practica();

                                oPractica.Id = Convert.ToInt32(oLector["id_practica"]); //Practica.id_Practica
                                oPractica.Nombre = Convert.ToString(oLector["nombre"]); //Practica.nombre

                                //Agregamos el objeto Practica a la coleccion de Practicas
                                oPracticas.Add(oPractica);
                                oPractica = null;
                            }
                        }
                        //retornamos la coleccion
                        return oPracticas;
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
