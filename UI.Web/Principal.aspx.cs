using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Consultorio.Site
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                // Si es la primera vez que se soliconsulta la pagina cargamos el Listado de Pacientes
                CargarPacientes();
        }

        private void CargarPacientes()
        {
            // Obtener Pacientes desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            Business.Entities.Pacientes oPacientes;
            Business.Logic.Paciente oPacienteNegocio = new Business.Logic.Paciente();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                lblErrores.Text = "";
                lblErrores.Visible = false;

                // Le pido a la capa de negocios los pacientes existentes
                oPacientes = oPacienteNegocio.Listar();

                // Agrega datos y realiza Databinding al listado de Pacientes 
                grdPacientes.DataSource = oPacientes;
                grdPacientes.DataBind();
            }
            catch (Exception ex)
            {
                // Si hay errores, mostrar:
                lblErrores.Text = ex.Message;
                lblErrores.Visible = true;
            }
            finally
            {
                // Libero memoria de objetos
                oPacientes = null;
                oPacientes = null;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualiza el listado manualmente
            CargarPacientes();
        }

        protected void grdPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Segun el botón Clickeado en la grilla realizo distintas acciones
            // en este caso verificamos si podemos ver las consultas del paciente
            switch (e.CommandName)
	        {
                case "VerConsultas":
                    Response.Redirect("Consultas.aspx?Id=" + e.CommandArgument);
                    break;
	        }
        }

        protected void grdPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Asigna el nuevo indice de página a visualizar
            CargarPacientes();
            grdPacientes.PageIndex = e.NewPageIndex;
            grdPacientes.DataBind();
        }
        protected void grdPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
}
}