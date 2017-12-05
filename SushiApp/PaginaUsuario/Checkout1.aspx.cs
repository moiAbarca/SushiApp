using System;
using System.Collections.Generic;
using System.Data;
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

        wsUsuario.ServiceUsuarioClient UsuarioClient = new wsUsuario.ServiceUsuarioClient();
        wsUsuario.usuario auxUsuario = new wsUsuario.usuario();

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
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
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
                    //auxCliente.usuarioId = 1;
                    auxCliente.nombre = txtNombre.Text;
                    auxCliente.fechaNacimiento = "19900101";
                    auxCliente.sexo = "";

                    try
                    {
                        int pos = UsuarioClient.obtenerUsuario().Count();
                        wsUsuario.usuario user = UsuarioClient.buscarLogin(txtEmail.Text);
                        if (user.usuarioId == 0)
                        {
                            user.usuarioId = pos + 1;
                            user.usuario1 = txtEmail.Text;
                            user.pass = txtPassword.Text;

                            UsuarioClient.agregarUsuario(user);
                            limpiar();
                            //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "UserCreateSuccess()", true);
                            //try
                            //{
                            int posCli = clienteCliente.obtenerCliente().Count();
                            auxCliente.usuarioId = user.usuarioId;
                            auxCliente.clienteId = posCli + 1;
                            clienteCliente.agregarCliente(auxCliente);

                            limpiar();
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "customerCreateSuccess()", true);
                            Session["Usuario"] = user;
                            Session["UserName"] = user.usuario1;
                            Session["UserId"] = user.usuarioId;
                            Session["UserPass"] = user.pass;
                            Response.Redirect("Checkout2.aspx");
                            //}
                            //catch (Exception ex)
                            //{
                            //    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", ex.ToString(), true);
                            //    return;
                            //}

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "usuarioExiste()", true);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", ex.ToString(), true);
                        return;
                    }


                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                return;
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
            String mail = txtEmailLogin.Text;
            String password = txtPasswordLogin.Text;
            if (txtEmailLogin.Text.Trim().Length == 0 || txtPasswordLogin.Text.Trim().Length == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                return;
            }
            wsUsuario.usuario user = UsuarioClient.buscarLogin(mail);
            if (user.usuarioId == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "usuarioNoExiste()", true);
                return;
            }
            if (user.usuario1 == mail)
            {
                if (user.pass == password)
                {
                    Session["Usuario"] = user;
                    Session["UserName"] = mail;
                    Session["UserId"] = user.usuarioId;
                    Session["UserPass"] = user.pass;
                    Response.Redirect("Checkout2.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorContraseña()", true);
                    return;
                }
            }

        }

        private void ocultarDivLogin()
        {
            System.Web.UI.HtmlControls.HtmlGenericControl dvLogin = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divLogin");
            dvLogin.Style.Add("display", "none");

            System.Web.UI.HtmlControls.HtmlGenericControl dvUser = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divUsuario");
            dvUser.Style.Add("display", "inline");
        }

        private void mostrarDivLogin()
        {
            System.Web.UI.HtmlControls.HtmlGenericControl dvLogin = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divLogin");
            dvLogin.Style.Add("display", "inline");

            System.Web.UI.HtmlControls.HtmlGenericControl dvUser = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("divUsuario");
            dvUser.Style.Add("display", "none");
        }
    }
}