using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout11 : System.Web.UI.Page
    {
        
        wsCliente.ServiceClienteClient clienteCliente = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                mostrarDivLogin();
            }
            else
            {
                ocultarDivLogin();
                Response.Redirect("Checkout2.aspx");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {

                    auxCliente.rut = "";
                    auxCliente.direccion = "";
                    auxCliente.apellido = txtApellido.Text;
                    auxCliente.comunaId = 1;
                    auxCliente.telefono = 1;
                    auxCliente.email = txtEmail.Text;
                    auxCliente.usuarioId = 1;
                    auxCliente.nombre = txtNombre.Text;
                    auxCliente.fechaNacimiento = "19900101";
                    auxCliente.sexo = "";

                    clienteCliente.agregarCliente(auxCliente);
                    limpiar();
                    Response.Redirect("Checkout2.aspx");
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo registrar');</script>");
            }
            
        }

        private void limpiar()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout2.aspx");
        }

        private void ocultarDivLogin()
        {
            System.Web.UI.HtmlControls.HtmlGenericControl dvLogin = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divLogin");
            dvLogin.Style.Add("display", "none");
        }

        private void mostrarDivLogin()
        {
            System.Web.UI.HtmlControls.HtmlGenericControl dvLogin = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divLogin");
            dvLogin.Style.Add("display", "inline");
        }
    }
}