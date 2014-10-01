using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmObrasSociales : Form
    {
        #region Constructores

        public Business.Entities.ObrasSociales oObrasSociales = new Business.Entities.ObrasSociales();
        public static Business.Entities.ObrasSociales nuevasObrasSociales { get; set; }

        public frmObrasSociales()
        {
            InitializeComponent();
        }
    #endregion
        #region Eventos de Formulario

        private void frmObrasSociales_Load(object sender, EventArgs e)
        {
            //recupera el listado de obras sociales
            CargarObrasSociales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void btnAgregarObrasSociales_Click(object sender, EventArgs e)
        {
            AgregarObrasSociales();
            Salir();
        }
        #endregion
        #region Metodos de Formulario
        private void CargarObrasSociales()
        {
            //Instancio la clase Obra Social de la capa de Negocios
            Business.Logic.ObraSocial oObraSocialNegocio = new Business.Logic.ObraSocial();

            //try
            //{
            //Recupero la colección de todos las Obras Sociales
            oObrasSociales = oObraSocialNegocio.Listar();
            InicializarObrasSociales(oObrasSociales);
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
        private void InicializarObrasSociales(Business.Entities.ObrasSociales oObrasSociales)
        {
            lstObrasSociales.BeginUpdate();
            lstObrasSociales.DataSource = oObrasSociales;
            lstObrasSociales.DisplayMember = "Nombre";
            lstObrasSociales.ValueMember = "Id";
            lstObrasSociales.EndUpdate();
        }
        private void AgregarObrasSociales()
        {
            Business.Entities.ObrasSociales oObrasSocialesTmp = new Business.Entities.ObrasSociales();

            foreach (Business.Entities.ObraSocial NuevaObraSocial in lstObrasSociales.SelectedItems)
            {
                oObrasSocialesTmp.Add(NuevaObraSocial);
            }
            //seteo la Propiedad
            nuevasObrasSociales = oObrasSocialesTmp;
        }
        private void Salir()
        {
            this.Dispose();
        }

        #endregion

        private void lstObrasSociales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Agrega las Obras Sociales Seleccionadas
            AgregarObrasSociales();
            Salir();
        }

        private void frmObrasSociales_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    // Agrega las Obras Sociales Seleccionadas
                    AgregarObrasSociales();
                    break;
                case Keys.F5:
                    // Actualiza lista de Obras Sociales
                    CargarObrasSociales();
                    break;
                default:
                    break;
            }
        }
    }
}
