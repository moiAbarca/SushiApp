using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class CuentaUsuario : System.Web.UI.Page
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
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                ocultarDivLogin();
                Label us = (Label)Master.FindControl("lblUsuario");
                us.Text = (String)Session["UserName"];
            }
        }

        protected void btnGuardar_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text.Trim().Length == 0 || txtNewPassword.Text.Trim().Length == 0 || txtNewPassword2.Text.Trim().Length == 0)
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                    return;
                }

                String pass = (String)Session["UserPass"];
                if (pass == txtOldPassword.Text)
                {
                    if (txtOldPassword.Text == txtNewPassword.Text || txtOldPassword.Text == txtNewPassword2.Text)
                    {
                        
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "samePassword()", true);
                        return;
                    }
                    else
                    {
                        if (txtNewPassword.Text == txtNewPassword2.Text)
                        {
                            try
                            {
                                auxUsuario.pass = txtNewPassword.Text;
                                auxUsuario.usuario1 = (String)Session["UserName"];
                                auxUsuario.usuarioId = (Int32)Session["UserId"];
                                auxUsuario.perfilId = 1;
                                UsuarioClient.modificarUsuario(auxUsuario);
                                Session["UserPass"] = txtNewPassword.Text;
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "contraModificada()", true);
                                return;
                            }
                            catch (Exception ex)
                            {
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", ex.ToString(), true);
                                return;
                            }

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                            return;
                        }
                    }
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorContraseña()", true);
                    return;
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                return;
            }
            
        }

        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1)); Response.Cache.SetNoStore();
            mostrarDivLogin();
            Response.Redirect("Inicio.aspx");
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