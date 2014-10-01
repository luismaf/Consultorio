using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    internal partial class frmMain : Form
    {
    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    #region Constructores


        // Instanciamos la Coleccion de Pacientes y Consultas
        public Business.Entities.Pacientes oPacientes = new Business.Entities.Pacientes();
        public Business.Entities.Consultas oConsultas = new Business.Entities.Consultas();

        //Instanciamos las colecciones Practicas y Diagnosticos
        public Business.Entities.Practicas oPracticas = new Business.Entities.Practicas();
        public Business.Entities.Diagnosticos oDiagnosticos = new Business.Entities.Diagnosticos();

        //Instanciamos Paciente y Consulta
        public Business.Entities.Paciente oPaciente;
        public Business.Entities.Consulta oConsulta;

        public bool SeHanRealizadoCambios = false;
        public frmMain()
        {
            InitializeComponent();
        }

        #endregion
    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    #region Eventos

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //ValidarUsuario();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LlenarControles();
            SeHanRealizadoCambios = false;
        }

        // ///////////////////////////////////////////////////////////////////////////////
        #region Eventos del Paciente

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            CargarPaciente(null);
        }
        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            EditarPaciente();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Implementación en 2º Etapa
            Imprimir();
        }
        private void btnInformes_Click(object sender, EventArgs e)
        {
            //Implementación en 2º Etapa
            Informes();
        }
        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }
        
        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            GuardarPaciente();
        }

        private void btnDescartarPaciente_Click(object sender, EventArgs e)
        {
            CargarPaciente(null);
        }
        private void btnAgregarObrasSociales_Click(object sender, EventArgs e)
        {
            AgregarObrasSociales();
        }
        private void btnEliminarObraSocial_Click(object sender, EventArgs e)
        {
            EliminarObraSocial();
        }
        private void lstPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditarPaciente();
        }
        private void tabMain_MouseClick(object sender, MouseEventArgs e)
        {

            if (tabMain.SelectedTab == txtBuscarPractica)
            {
                if (AlgunPacienteSelecionado())
                {
                    int IdPaciente = Convert.ToInt32(lstPacientes.SelectedItems[0].Text);
                    //si no es el mismo que ya se esta editando
                    if (oPaciente == null || oPaciente.Id != IdPaciente)
                        // Muestro la pestaña paciente, y la cargo con los datos del paciente
                        CargarPaciente(IdPaciente);
                }
                else
                    // Muestro la pestaña paciente, vacia.
                    CargarPaciente(null);
            }
        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    // Crea un nuevo Paciente
                    CargarPaciente(null);
                    break;
                case Keys.Return:
                    // Edita un Paciente y sus Consultas
                    EditarPaciente();
                    break;
                case Keys.Delete:
                    // Elimina un Paciente
                    EliminarPaciente();
                    break;
                case Keys.F5:
                    // Actualiza el listado de Pacientes
                    CargarPacientes();
                    break;
                default:
                    break;
            }
        }
        #endregion

        // ///////////////////////////////////////////////////////////////////////////////
        #region Eventos de la Consulta

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            GuardarConsulta();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            CargarConsulta(null);
        }

        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            EditarConsulta();
        }

        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            EliminarConsulta();
        }

        private void EliminarConsulta()
        {
            throw new NotImplementedException();
        }

        private void btnDescartarConsulta_Click(object sender, EventArgs e)
        {
            CargarConsulta(null);
        }

        private void tabConsultas_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabConsultas.SelectedTab == tabConsulta)
            {
                if (AlgunaConsultaSelecionada())
                {
                    int IdConsulta = Convert.ToInt32(lstConsultas.SelectedItems[0].Text);
                    //si no es el mismo que ya se esta editando
                    if (oConsulta == null || oConsulta.Id != IdConsulta)
                        // Muestro la pestaña consulta, y la cargo con los datos del paciente
                        CargarConsulta(IdConsulta);
                }
                else
                    // Muestro la pestaña consulta, vacia.
                    CargarConsulta(null);
            }

        }
        #endregion

        // ///////////////////////////////////////////////////////////////////////////////
        #region Eventos para etección de Cambios (edición)

        private void cbxGrupoSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void cbxFactorSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void cbxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void cbxDiagnostico_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void dtpFechaConsulta_ValueChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtDetalleConsulta_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void rdbUltimoMes_CheckedChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }
        private void txtNroCalle_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }
        private void txtPiso_TextChanged(object sender, EventArgs e)
        {
            string TextoSinLetras = Utilidades.Herramientas.soloNumeros(txtPiso.Text);
            //si el texto ha cambiado
            if (!TextoSinLetras.Equals(txtPiso.Text))
                txtPiso.Text = TextoSinLetras;

            SeHanRealizadoCambios = true;
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtNumeroDoc_TextChanged(object sender, EventArgs e)
        {
            string TextoSinLetras = Utilidades.Herramientas.soloNumeros(txtNumeroDoc.Text);
            //si el texto ha cambiado
            if (!TextoSinLetras.Equals(txtNumeroDoc.Text))
                txtNumeroDoc.Text = TextoSinLetras;

            SeHanRealizadoCambios = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtProblemas_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }

        private void txtNotas_TextChanged(object sender, EventArgs e)
        {
            SeHanRealizadoCambios = true;
        }
        #endregion


    #endregion
    // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    #region Metodos

        // ///////////////////////////////////////////////////////////////////////////////
        #region Metodos asociados a Controles
        /// <summary>
        /// Llena los controles con valores de la Base de Datos o Enumeradores correspondientes a las Entidades
        /// </summary>
        private void LlenarControles()
        {
            CargarTiposDoc();
            CargarGruposSanguineos();
            CargarFactoresSanguineos();
            CargarPracticas(); //(practicas de consulta)
            CargarDiagnosticos();
            //Carga el listado de Pacientes
            CargarPacientes();
        }
        /// <summary>
        /// Valida el igreso a la aplicacion
        /// </summary>
        private void ValidarUsuario()
        {
            // Crea instancia del cuadro de dialogo "Ingreso"
            frmIngreso ofrmIngreso = new frmIngreso();

            // Muestro el formulario de manera modal
            ofrmIngreso.ShowDialog();

            // Cierro formulario
            ofrmIngreso.Close();

            // Elimino instancia del formulario
            ofrmIngreso = null;
        }

        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        private void Salir()
        {
            this.Dispose();
            Application.Exit();
        }
        /// <summary>
        /// Agrega Obras Sociales a un Paciente
        /// </summary>
        private void AgregarObrasSociales()
        {
            // Instanciamos el cuadro de dialogo frmObrasSociales
            frmObrasSociales ofrmObrasSociales = new frmObrasSociales();

            //Business.Entities.ObrasSociales frmObrasSociales.nuevasObrasSociales = new Business.Entities.ObrasSociales();

            // Mostramos el formulario modal
            ofrmObrasSociales.ShowDialog();

            //Si se han agregado obras sociales:
            if (frmObrasSociales.nuevasObrasSociales != null && frmObrasSociales.nuevasObrasSociales.Count > 0)
            {
                if (oPaciente.Afiliados != null)
                {
                    //recorre la colección de obras sociales del paciente en edición (incluso aquellas que aun no se han almacenado en la base de datos).
                    foreach (Business.Entities.Afiliado AfiliadoExistente in oPaciente.Afiliados)
                    {
                        frmObrasSociales.nuevasObrasSociales.Remove(frmObrasSociales.nuevasObrasSociales.Find(
                                delegate(Business.Entities.ObraSocial oObraSocialTemp)
                                {
                                    return oObraSocialTemp.Id == AfiliadoExistente.ObraSocial.Id;
                                }
                                ));
                        //elimina de la colección de nuevas obras sociales, aquellas previamente agregadas.
                        //if (frmObrasSociales.nuevasObrasSociales.Contains(AfiliadoExistente.ObraSocial.Id))
                        //   frmObrasSociales.nuevasObrasSociales.Remove(AfiliadoExistente.ObraSocial);
                    }
                }
                foreach (Business.Entities.ObraSocial NuevaObraSocial in frmObrasSociales.nuevasObrasSociales)
                {
                    //Instanciamos oAfiliado y agregamos cada Obra Social
                    Business.Entities.Afiliado oAfiliado = new Business.Entities.Afiliado();

                    oAfiliado.Id = null;
                    oAfiliado.ObraSocial = NuevaObraSocial;

                    //Agregamos el afiliado a la colección de afiliados del Paciente.
                    oPaciente.Afiliados.Add(oAfiliado);
                    oAfiliado = null;
                }

                //Actualizo el listado de Obras Sociales
                CargarObrasSociales();

                SeHanRealizadoCambios = true;
            }
            // Cierro formulario
            ofrmObrasSociales.Close();
        }

        /// <summary>
        /// Muestra la información de un Paciente y sus Consultas en la pestaña "Paciente"
        /// </summary>
        private void EditarPaciente()
        {
            //Verifica que exista algun elemento seleccionado
            if (AlgunPacienteSelecionado())
            {
                int IdPaciente = Convert.ToInt32(lstPacientes.SelectedItems[0].Text);
                //si no es el mismo que ya se esta editando
                if (oPaciente == null || oPaciente.Id != IdPaciente)
                    // Muestro la pestaña paciente, y la cargo con los datos del paciente
                    CargarPaciente(IdPaciente);
                else tabMain.SelectTab("tabPaciente");
            }
            else
            {
                // Informo que no se ha seleccionado un Paciente
                MessageBox.Show("Por favor, seleccione un Paciente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Muestra la información de un Paciente y sus Consultas en la pestaña "Paciente"
        /// </summary>
        private void EditarConsulta()
        {
            //Verifica que exista algun elemento seleccionado
            if (AlgunaConsultaSelecionada())
            {
                int IdConsulta = Convert.ToInt32(lstConsultas.SelectedItems[0].Text);
                //si no es el mismo que ya se esta editando
                if (oConsulta == null || oConsulta.Id != IdConsulta)
                    // Muestro la pestaña Consulta, y la cargo con los datos del Consulta
                    CargarConsulta(Convert.ToInt32(lstConsultas.SelectedItems[0].Text));
                else tabConsultas.SelectTab("tabConsulta");
            }
            else
            {
                // Informo que no se ha seleccionado un Consulta
                MessageBox.Show("Por favor, seleccione un Consulta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Verifica si hay un Paciente seleccionado
        /// </summary>
        /// <returns>True si un Paciente fue seleccionado, de lo contrario False</returns>
        private bool AlgunPacienteSelecionado()
        {
            return (lstPacientes.SelectedItems.Count > 0);
        }

        /// <summary>
        /// Verifica si hay alguna Consulta seleccionada
        /// </summary>
        /// <returns>True si una Consulta fue seleccionado, de lo contrario False</returns>
        private bool AlgunaConsultaSelecionada()
        {
            return (lstConsultas.SelectedItems.Count > 0);
        }

        /// <summary>
        /// Verifica si hay alguna Obra Social seleccionada
        /// </summary>
        /// <returns>True si una Obra Social fue seleccionado, de lo contrario False</returns>
        private bool AlgunaObraSocialSelecionada()
        {
            return (lstObrasSocialesPaciente.SelectedItems.Count > 0);
        }

        /// <summary>
        /// Imprime la lista de Pacientes
        /// </summary>
        private void Imprimir()
        {
            try
            {
                //imprimir a un archivo: System.IO.StreamReader streamToPrint = new System.IO.StreamReader("C:\\Archivo.txt");
                try
                {
                    System.Drawing.Printing.PrintDocument oPrintDocument = new System.Drawing.Printing.PrintDocument();
                    oPrintDocument.DocumentName = "Pacientes";
                    oPrintDocument.Print();
                }
                finally
                {
                    //streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Instancia el formulario frmInformes, (Informes de Pacientes)
        /// </summary>
        private void Informes()
        {
            //Se Implementará en la 2º Etapa del Proyecto
        }
        #endregion

        // ///////////////////////////////////////////////////////////////////////////////
        #region Metodos asociados a la Carga de Datos

        /// <summary>
        /// Recupera los "Pacientes" de la Base de Datos (y llena el control)
        /// </summary>
        private void CargarPacientes()
        {
            string ObrasSocialesTexto;
            //Instancio la clase Paciente de la capa de Negocios
            Business.Logic.Paciente oPacienteNegocio = new Business.Logic.Paciente();

            //try
            //{
            //Recupero todos los Pacientes y los almaceno en el objeto Paciente
            oPacientes = oPacienteNegocio.Listar();

            // No actualizamos el control hasta que finalice la operación (carga mas rapido)
            lstPacientes.BeginUpdate();

            // Eliminamos los datos de la lista
            lstPacientes.Items.Clear();

            if (oPacientes != null && oPacientes.Count > 0)
            {
                //Agrego los datos de cada paciente a la lista de Pacientes
                foreach (Business.Entities.Paciente oPacienteTmp in oPacientes)
                {
                    ObrasSocialesTexto = "";
                    ListViewItem oItem;
                    oItem = lstPacientes.Items.Add(oPacienteTmp.Id.ToString());
                    oItem.SubItems.Add(oPacienteTmp.TipoDoc.ToString() + ": " + oPacienteTmp.NumeroDoc.ToString());
                    oItem.SubItems.Add(oPacienteTmp.Apellido);
                    oItem.SubItems.Add(oPacienteTmp.Nombre);
                    //recupero las obras sociales del paciente
                    if (oPacienteTmp.Afiliados != null && oPacienteTmp.Afiliados.Count > 0)
                    {

                        foreach (Business.Entities.Afiliado oAfiliado in oPacienteTmp.Afiliados)
                        {
                            ObrasSocialesTexto += oAfiliado.ObraSocial.Nombre + " / ";
                        }
                        //elimina el ultimo "/" de la lista de obras sociales
                        oItem.SubItems.Add(ObrasSocialesTexto.Substring(0, ObrasSocialesTexto.Length - 3));
                    }
                    else oItem.SubItems.Add("(no posee)");

                    oItem.SubItems.Add(oPacienteTmp.Telefono.ToString() + (Utilidades.Herramientas.esVacio(oPacienteTmp.Celular.ToString()) ? "" : oPacienteTmp.Celular.ToString()));
                    //oItem.SubItems.Add(oPaciente.Celular);

                    oItem.SubItems.Add(oPacienteTmp.Domicilio);
                    //oItem.SubItems.Add(oPaciente.Email);
                }
            }
            else lstPacientes.Items.Clear();

            // Le indico a listview que puede renderizar el control
            lstPacientes.EndUpdate();

            /*}
            catch (Exception ex)
            {
                // Si hay errores, mostrar:
                MessageBox.Show(ex.Message, this.Text + ": Error al Cargar Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oPacientes = null;
            }//*/
        }

        /// <summary>
        /// Recupera los "Consultas" de la Base de Datos (y llena el control)
        /// </summary>
        private void CargarConsultas()
        {
            //Instancio la clase Consulta de la capa de Negocios
            Business.Logic.Consulta oConsultaNegocio = new Business.Logic.Consulta();
            try
            {
                // No actualizamos el control hasta que finalice la operación (carga mas rapido)
                lstConsultas.BeginUpdate();

                if (oPaciente.Id != null)
                {
                    //Recupero todos los Consultas y los almaceno en el objeto Consulta
                    oConsultas = oConsultaNegocio.Listar((int)oPaciente.Id);

                    // Vaciamos el Listado de Consultas
                    lstConsultas.Items.Clear();

                    //Agrego los datos de cada Consulta al Listado de Consultas
                    foreach (Business.Entities.Consulta oConsulta in oConsultas)
                    {
                        ListViewItem oItem;
                        oItem = lstConsultas.Items.Add(oConsulta.Id.ToString());
                        oItem.SubItems.Add(oConsulta.Fecha.ToString());
                        oItem.SubItems.Add(oConsulta.Practica.Nombre);
                        oItem.SubItems.Add(oConsulta.Diagnostico.Nombre);
                        oItem.SubItems.Add(oConsulta.Detalle);
                    }
                }
                else //Se trata de un nuevo Paciente
                {
                    lstConsultas.Items.Clear();
                }

                tabConsultas.SelectTab("tabListadoConsultas");

                // Le indico a listview que puede renderizar el control
                lstConsultas.EndUpdate();

            }
            catch (Exception ex)
            {
                // Si hay errores, mostrar:
                MessageBox.Show(ex.Message, this.Text + ": Error al Cargar Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oConsultaNegocio = null;
            }
        }

        /// <summary>
        /// Recupera los "Practicas" de la Base de Datos (y llena el control)
        /// </summary>
        private void CargarPracticas()
        {
            //Instancio la clase de la capa de Entidades y Negocios
            //Business.Entities.Practicas oPracticas = new Business.Entities.Practicas();
            Business.Logic.Practica oPracticaNegocio = new Business.Logic.Practica();

            //try
            //{
            //Recupero la colección y lleno el ComboBox
            oPracticas = oPracticaNegocio.Listar();
            lstPracticas.DataSource = oPracticas;
            /*}
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text + ": Error al Cargar Practicas de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oObraSocialNegocio = null;
            }//*/
        }

        /// <summary>
        /// Recupera los "Diagnosticos" de la Base de Datos (y llena el control)
        /// </summary>
        private void CargarDiagnosticos()
        {
            //Instancio la clase de la capa de Entidades y Negocios
            //Business.Entities.Diagnosticos oDiagnosticos = new Business.Entities.Diagnosticos();
            Business.Logic.Diagnostico oDiagnosticoNegocio = new Business.Logic.Diagnostico();

            //try
            //{
            //Recupero la colección y lleno el ComboBox
            oDiagnosticos = oDiagnosticoNegocio.Listar();
            cbxDiagnostico.DataSource = oDiagnosticos;
            /*}
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text + ": Error al Cargar Obras Sociales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oObraSocialNegocio = null;
            }//*/
        }

        /// <summary>
        /// Recupera los "Grupos Sanguineos" de la Capa de Entidades (y llena el control)
        /// </summary>
        private void CargarGruposSanguineos()
        {
            cbxGrupoSanguineo.DataSource = Enum.GetValues(typeof(Business.Entities.Paciente.GruposSanguineos));
        }

        /// <summary>
        /// Recupera los "Factores Sanguineos" de la Capa de Entidades (y llena el control)
        /// </summary>
        private void CargarFactoresSanguineos()
        {
            cbxFactorSanguineo.DataSource = Enum.GetValues(typeof(Business.Entities.Paciente.FactoresSanguineos));
        }

        /// <summary>
        /// Recupera los "Tipos de Documento" de la Capa de Entidades
        /// </summary>
        private void CargarTiposDoc()
        {
            cbxTipoDoc.DataSource = Enum.GetValues(typeof(Business.Entities.Paciente.TiposDoc));
        }

        /// <summary>
        /// Inicializa la Pestaña Paciente (buscando en la colección oPacientes, en caso de pacientes existentes).
        /// </summary>
        private void CargarPaciente(Nullable<int> Id)
        {
            if (SeHanRealizadoCambios)
            {
                //Muestro la Pestaña Paciente para que el usuario vea los datos del Paciente actual
                tabMain.SelectTab("tabPaciente");

                //Antes de borrar los datos cargardos en la pestaña Paciente, consulto si desea guardar los cambios
                DialogResult RespuestaUsuario = MessageBox.Show(
                "Ha realizado actualizado la información del paciente. Deseea gardar los cambios?",
                this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (RespuestaUsuario == System.Windows.Forms.DialogResult.Cancel) return;
                if (RespuestaUsuario == System.Windows.Forms.DialogResult.Yes) GuardarPaciente();

            }

            if (Id != null)
            {
                //Carga los datos de un usuario
                oPaciente = oPacientes.Find(
                                delegate(Business.Entities.Paciente oPacienteTemp)
                                {
                                    return oPacienteTemp.Id == Id;
                                }
                                );
                cbxTipoDoc.SelectedItem = oPaciente.TipoDoc;
                cbxGrupoSanguineo.SelectedItem = oPaciente.GrupoSanguineo;
                cbxFactorSanguineo.SelectedItem = oPaciente.Factor;
            }
            else
            {
                //Paciente Nuevo:
                oPaciente = new Business.Entities.Paciente();
                oPaciente.Afiliados = new Business.Entities.Afiliados();
                cbxTipoDoc.SelectedItem = cbxTipoDoc.Items[0];
                cbxGrupoSanguineo.SelectedItem = cbxGrupoSanguineo.Items[0];
                cbxFactorSanguineo.SelectedItem = cbxFactorSanguineo.Items[0];

            }
            // Lleno la pestaña Paciente con la información almacenada en oPaciente
            txtNombre.Text = oPaciente.Nombre;
            txtApellido.Text = oPaciente.Apellido;
            txtNumeroDoc.Text = oPaciente.NumeroDoc.ToString();
            dtpFechaConsulta.Text = oPaciente.FechaNac.ToString();
            txtDomicilio.Text = oPaciente.Domicilio;
            txtTelefono.Text = oPaciente.Telefono;
            txtCelular.Text = oPaciente.Celular;
            txtEmail.Text = oPaciente.Email;
            txtProblemas.Text = oPaciente.Problemas;
            txtNotas.Text = oPaciente.Notas;

            //Cargamos las obras sociales
            CargarObrasSociales();

            //Cargamos las Consultas del Paciente
            CargarConsultas();

            //Muestro la Pestaña Paciente
            tabMain.SelectTab("tabPaciente");

            SeHanRealizadoCambios = false;
        }

        /// <summary>
        /// Inicializa la Pestaña oConsulta (buscando en la colección oConsulta, en caso de consultas existentes).
        /// </summary>
        private void CargarConsulta(Nullable<int> IdConsulta)
        {
            if (SeHanRealizadoCambios)
            {
                //Muestro la Pestaña Consulta para que el usuario vea los datos de la consulta no guardada.
                tabConsultas.SelectTab("tabConsulta");

                //Antes de borrar los datos cargardos en la pestaña Paciente, consulto si desea guardar los cambios
                DialogResult RespuestaUsuario = MessageBox.Show(
                "Ha realizado cambios en la consulta. Deseea gardarlos?",
                this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (RespuestaUsuario == System.Windows.Forms.DialogResult.Cancel) return;
                if (RespuestaUsuario == System.Windows.Forms.DialogResult.Yes) GuardarConsulta();

            }

            if (IdConsulta != null)
            {
                //Carga los datos de la consulta
                oConsulta = oConsultas.Find(
                                delegate(Business.Entities.Consulta oConsultaTmp)
                                {
                                    return oConsultaTmp.Id == IdConsulta;
                                }
                                );
                oConsulta.Practica = oPracticas.Find(
                                    delegate(Business.Entities.Practica oPracticaTmp)
                                    {
                                        return oPracticaTmp.Id == Convert.ToInt32(oConsulta.Practica.Id); //practica.id_practica
                                    }
                                );
                //cambiarlo por datasource 
                lstDiagnosticoConsulta.DataSource = oConsulta.Diagnostico;
                lstPracticas.SelectedItem = oConsulta.Practica;
            }
            else
            {
                //Nueva Consulta:
                oConsulta = new Business.Entities.Consulta();
                oConsulta.Diagnostico = new Business.Entities.Diagnostico();
                oConsulta.Practica = new Business.Entities.Practica();

                cbxDiagnostico.SelectedItem = cbxDiagnostico.Items[0];
                lstPracticas.SelectedItem = lstPracticas.Items[0];

            }

            // Lleno la pestaña Consulta con la información almacenada en oConsulta
            //txtPractica.Text = oConsulta.DetallePractica;
            txtDetalleConsulta.Text = oConsulta.Detalle;

            //Muestro la Pestaña Consulta
            tabConsultas.SelectTab("tabConsulta");

            SeHanRealizadoCambios = false;
        }

        /// <summary>
        /// Inicializa el listado de "Obras Sociales" de un Paciente (con valores asignados en la instancia oPaciente)
        /// </summary>
        private void CargarObrasSociales()
        {
            //Instanciamos una colección temporal de obras sociales
            Business.Entities.ObrasSociales oObrasSocialesTmp = new Business.Entities.ObrasSociales();

            if (oPaciente.Afiliados != null)
            {
                foreach (Business.Entities.Afiliado oAfiliado in oPaciente.Afiliados)
                {
                    oObrasSocialesTmp.Add(oAfiliado.ObraSocial);
                }
                lstObrasSocialesPaciente.BeginUpdate();
                lstObrasSocialesPaciente.DataSource = oObrasSocialesTmp;
                lstObrasSocialesPaciente.DisplayMember = "Nombre";
                lstObrasSocialesPaciente.ValueMember = "Id";
                lstObrasSocialesPaciente.EndUpdate();
            }
            else
            {
                //si no tiene ninguna obra social, limpio el listado de obras sociales.
                lstObrasSocialesPaciente.DataSource = null;
                txtNroAfiliado.Text = "";
            }
        }

        /// <summary>
        /// Guarda la información de un Paciente
        /// </summary>
        private void GuardarPaciente()
        {
            string ErrorDeValidacion = ErrorDeValidacionPaciente();

            if (ErrorDeValidacion == null)
            {
                //llenamos oPaciente con la información ingresada/modificada
                oPaciente.Nombre = txtNombre.Text.Trim();
                oPaciente.Apellido = txtApellido.Text.Trim();
                oPaciente.TipoDoc = (Business.Entities.Paciente.TiposDoc)cbxTipoDoc.SelectedItem;
                oPaciente.NumeroDoc = Convert.ToInt32(txtNumeroDoc.Text);
                //oPaciente.FechaNac = dtpFechaNac.Value;
                oPaciente.GrupoSanguineo = (Business.Entities.Paciente.GruposSanguineos)cbxGrupoSanguineo.SelectedItem;
                oPaciente.Factor = (Business.Entities.Paciente.FactoresSanguineos)cbxFactorSanguineo.SelectedItem;
                oPaciente.Domicilio = txtDomicilio.Text.Trim();
                oPaciente.Telefono = txtTelefono.Text.Trim();
                oPaciente.Celular = txtCelular.Text.Trim();
                oPaciente.Email = txtEmail.Text.Trim();
                oPaciente.Problemas = txtProblemas.Text.Trim();
                oPaciente.Notas = txtNotas.Text.Trim();

                //las obras sociales ya se encuentran en opaciente.afiliados, se agregan a la colección al cargarse/agregarse.
                Business.Logic.Paciente oPacienteNegocio = new Business.Logic.Paciente();

                //Actualizamos la base de datos. Si es un paciente nuevo, devuelve el Id del Paciente.
                oPaciente.Id = oPacienteNegocio.Actualizar(oPaciente);

                //si el paciente es afiliado de 1 o mas obras sociales:
                if (oPaciente.Afiliados != null && oPaciente.Afiliados.Count > 0)
                {
                    //ahora utlizaremos ei Id del Paciente para actualizar los Afiliados del mismo.
                    Business.Logic.Afiliado oAfiliadoNegocio = new Business.Logic.Afiliado();
                    oAfiliadoNegocio.Actualizar((int)oPaciente.Id, oPaciente.Afiliados);
                }
                // Recargar listado de Pacientes
                CargarPacientes();

                SeHanRealizadoCambios = false;
            }
            else
            {
                //muestra el error:
                MessageBox.Show(null, "Atención: El campo '" + ErrorDeValidacion + "' no puede ser nulo", "Error al Guardar el Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Guarda la información de una "Consulta"
        /// </summary>
        private string ErrorDeValidacionPaciente()
        {
            //llenamos oPaciente con la información ingresada/modificada
            if (Utilidades.Herramientas.esVacio(txtNombre.Text)) return "Nombre";
            if (Utilidades.Herramientas.esVacio(txtApellido.Text)) return "Apellido";
            if (Utilidades.Herramientas.esVacio(txtNumeroDoc.Text)) return "NumeroDoc";
            //if(dtpFechaNac.Value==null) return "Fecha";
            if (cbxGrupoSanguineo.SelectedItem == null) return "cbxGrupoSanguineo";
            if (cbxFactorSanguineo.SelectedItem == null) return "cbxFactorSanguineo";
            if (Utilidades.Herramientas.esVacio(txtDomicilio.Text)) return "Domicilio";
            if (Utilidades.Herramientas.esVacio(txtTelefono.Text)) return "Telefono";
            if (Utilidades.Herramientas.esVacio(txtCelular.Text)) return "Celular";
            if (Utilidades.Herramientas.esVacio(txtEmail.Text)) return "Email";
            if (Utilidades.Herramientas.esVacio(txtProblemas.Text)) return "Problemas";
            if (Utilidades.Herramientas.esVacio(txtNotas.Text)) return "Notas";

            //si no hay problemas, devuevle null
            return null;
        }
        /// <summary>
        /// Guarda la información de una "Consulta"
        /// </summary>
        private void GuardarConsulta()
        {
            if (oConsulta == null) oConsulta = new Business.Entities.Consulta();

            //llenamos oConsulta con la información ingresada/modificada
            oConsulta.Detalle = txtDetalleConsulta.Text.Trim();
            oConsulta.Diagnostico = (Business.Entities.Diagnostico)cbxDiagnostico.SelectedItem;
            oConsulta.Practica = (Business.Entities.Practica)lstPracticas.SelectedItem;
            oConsulta.Fecha = dtpFechaConsulta.Value;

            if (oPaciente.Id == null)
            {
                //al ser un paciente nuevo, es necesario guardar el paciente para poder guardar la consulta.
                DialogResult RespuestaUsuario = MessageBox.Show(
                "Para guardar la consulta, primero debe guardar el nuevo Paciente. Deseea gardarlo?",
                this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                if (RespuestaUsuario == System.Windows.Forms.DialogResult.Cancel) return;
                if (RespuestaUsuario == System.Windows.Forms.DialogResult.OK) GuardarPaciente();
            }
            //Instanciamos la clase Paciente de la capa lógica.
            Business.Logic.Consulta oConsultaNegocio = new Business.Logic.Consulta();

            //Actualizamos la base de datos. Si es un Consulta nuevo, devuelve el Id del Consulta.
            oConsulta.Id = oConsultaNegocio.Actualizar((int)oPaciente.Id, oConsulta);

            /*
            //si la Consulta es tiene 1 o mas practicas:
            if (oConsulta.Practicas != null && oConsulta.Practicas.Count > 0)
            {
                //ahora utlizaremos ei Id del Consulta para actualizar las Practicas del mismo.
                Business.Logic.Practicas oPracticasNegocio = new Business.Logic.Practicas();
                oAfiliadoNegocio.Actualizar((int)oConsulta.Id, oConsulta.Practicas);
            }
            //*/

            // Recargar listado de Consultas
            CargarConsultas();

            SeHanRealizadoCambios = false;
        }

        /// <summary>
        /// Elimina un Paciente
        /// </summary>
        private void EliminarPaciente()
        {
            // Antes de eliminar verifica que exista algun elemento seleccionado
            if (AlgunPacienteSelecionado())
            {
                // Antes de eliminar preguntamos al usuario
                if (MessageBox.Show(
                    "Esta seguro que desea eliminar el Paciente seleccionado? También se eliminarán todas sus Consultas!",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    // Instancio la Clase Pacientes de la capa de Negocios
                    Business.Logic.Paciente oPacienteNegocio = new Business.Logic.Paciente();

                    try
                    {
                        //Elimino el Paciente
                        // (el Id del Paciente a eliminar es el 1º de la coleccion de seleccionados)
                        oPacienteNegocio.Borrar(Convert.ToInt32(lstPacientes.SelectedItems[0].Text));

                        //Mensaje de exito
                        //MessageBox.Show("El paciente ha sido eliminado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar listado de Pacientes
                        CargarPacientes();
                    }
                    catch (Exception ex)
                    {
                        // Mensaje de error
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero recursos
                        oPacienteNegocio = null;
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado un Paciente:
                MessageBox.Show("Debe seleccionar el Paciente que desea eliminar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Elimina una Obra Social
        /// </summary>
        private void EliminarObraSocial()
        {
            // Antes de eliminar verifica que exista algun elemento seleccionado
            if (AlgunaObraSocialSelecionada())
            {
                // Antes de eliminar preguntamos al usuario
                if (MessageBox.Show(
                    "Esta seguro que desea eliminar la Obra Social seleccionada?", //También se eliminarán todas las Recetas asociadas a la misma!",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    == System.Windows.Forms.DialogResult.Yes)
                {

                    //recorre la colección de obras sociales del paciente en edición (incluso aquellas que aun no se han almacenado en la base de datos).
                    foreach (Business.Entities.Afiliado AfiliadoExistente in oPaciente.Afiliados)
                    {
                        //elimina la obra social coincidente
                        if (AfiliadoExistente.ObraSocial == lstObrasSocialesPaciente.SelectedItem)
                        {
                            oPaciente.Afiliados.Remove(AfiliadoExistente);
                            break;
                        }
                    }
                    //Recargo el listado de Obras Sociales
                    CargarObrasSociales();
                }
            }
            else
            {
                // Si no se ha seleccionado un Paciente:
                MessageBox.Show("Debe seleccionar la Obra Social a eliminar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CargarNroAfiliado()
        {
            //Business.Logic.Afiliado oAfiliadoNegocio = new Business.Logic.Afiliado;
            txtNroAfiliado.Text = oPaciente.Afiliados.Find(
                                 delegate(Business.Entities.Afiliado oAfiliadoTmp)
                                 {
                                     return oAfiliadoTmp.ObraSocial == lstObrasSocialesPaciente.SelectedItem;
                                 }
                                 ).Id.ToString();
        }
        private void ActualizarNroAfiliado()
        {
            string TextoSinLetras = Utilidades.Herramientas.soloNumeros(txtNroAfiliado.Text);
            //si el texto ha cambiado
            if (!TextoSinLetras.Equals(txtNroAfiliado.Text))
                txtNroAfiliado.Text = TextoSinLetras;
            if (!Utilidades.Herramientas.esVacio(TextoSinLetras) && oPaciente.Afiliados != null && oPaciente.Afiliados.Count > 0)
            {
                oPaciente.Afiliados.Find(
                                     delegate(Business.Entities.Afiliado oAfiliadoTmp)
                                     {
                                         return oAfiliadoTmp.ObraSocial == lstObrasSocialesPaciente.SelectedItem;
                                     }
                                     ).Id = Convert.ToInt32(TextoSinLetras);
            }
            SeHanRealizadoCambios = true;

        }


        private void lstObrasSocialesPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarNroAfiliado();
        }

        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            ActualizarNroAfiliado();
        }

        #endregion

        private void grpDatosConsulta_Enter(object sender, EventArgs e)
        {

        }


    #endregion

    }
}