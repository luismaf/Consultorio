using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Consultorio.Site
{
    public partial class Consultas : System.Web.UI.Page
    {
        #region Propiedades
        
        // Propiedad que utiliza sesión para almacenar el Id de paciente actual
        // No se recomienda usar variables de session cuando no es necesario. Aqui se usa a modo de ejemplo.
        public int IdPaciente
        {
            get { return Convert.ToInt32(Session["IdPaciente"]); }
            set { Session["IdPaciente"] = value; }
        }

        #endregion

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Almanceno en sesion el valor del paciente actual
                // utilizo el esquema de propiedades para simplificar y organizar el uso de la misma
                this.IdPaciente = Convert.ToInt32(Request.QueryString["Id"]);

                Business.Entities.Consultas oConsultas = new Business.Entities.Consultas();
                Business.Logic.Consulta oConsultaNegocio = new Business.Logic.Consulta();

                // Busco la información del paciente
                oConsultas = oConsultaNegocio.Listar(this.IdPaciente);
                lblConsultas.Text = "Consultas de " + IdPaciente.ToString();
                oConsultas = null;
                oConsultas = null;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Busca las consultas segun la opcion
            Buscar();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            // Volvemos a la página inicial
            Response.Redirect("default.aspx");
        }

        protected void cmbTipoConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Visualizamos u ocultamos el calendario
            CalendarCtl.Visible = cmbTipoConsultas.Items[1].Selected;
        }

        protected void GridViewCtl_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Asignamos el indice de pagina a visualizar 
            Buscar();
            grdConsultas.PageIndex = e.NewPageIndex;
            grdConsultas.DataBind();
        }

        #endregion

        #region Metodos

        // Busca consultas en funcion de lo datos de filtro
        private void Buscar()
        {
            Business.Entities.Consultas oConsultas = new Business.Entities.Consultas();
            Business.Logic.Consulta oConsultaNegocio = new Business.Logic.Consulta();
            DateTime FechaInicial;
            DateTime FechaFinal;

            try
            {
                lblErrores.Visible = false;

                // Verifico si traigo todas o por fecha
                if (cmbTipoConsultas.Items[0].Selected)
                {
                    // Todas
                    oConsultas = oConsultaNegocio.Listar(IdPaciente);
                }
                else
                {
                    // Por fecha
                    FechaInicial = new DateTime(CalendarCtl.SelectedDate.Year, CalendarCtl.SelectedDate.Month, CalendarCtl.SelectedDate.Day, 0, 0, 0);
                    FechaFinal = new DateTime(CalendarCtl.SelectedDate.Year, CalendarCtl.SelectedDate.Month, CalendarCtl.SelectedDate.Day, 23, 59, 59);
                    oConsultas = oConsultaNegocio.ListarIntervalo(IdPaciente, FechaInicial, FechaFinal);
                }

                // Muestro la grilla si es la primera vez que busca
                if (!grdConsultas.Visible)
                    grdConsultas.Visible = true;

                // Asigno data source
                grdConsultas.DataSource = oConsultas;
                grdConsultas.DataBind();
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
                lblErrores.Visible = true;
            }
            finally
            {
                // Libero memoria
                oConsultas = null;
                oConsultaNegocio = null;
            }
        }

        #endregion

    }
}