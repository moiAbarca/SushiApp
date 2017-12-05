using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class RegistroUsuario : System.Web.UI.Page
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
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void btnRegistrarse_ServerClick(object sender, EventArgs e)
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
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "UserCreateSuccess()", true);
                            try
                            {
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
                                Response.Redirect("CuentaUsuario.aspx");
                            }
                            catch (Exception ex)
                            {
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                                return;
                            }
                            
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "usuarioExiste()", true);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
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

        protected void btnIngresar_ServerClick(object sender, EventArgs e)
        {
            String mail = txtEmailLogin.Text;
            String password = txtPasswordLogin.Text;
            if (txtEmailLogin.Text.Trim().Length == 0 || txtPasswordLogin.Text.Trim().Length == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                return;
            }
            try
            {
                wsUsuario.usuario user = UsuarioClient.buscarLogin(mail);
                try
                {
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
                            Response.Redirect("CuentaUsuario.aspx");
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorContraseña()", true);
                            return;
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                    return;
                }
                
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
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