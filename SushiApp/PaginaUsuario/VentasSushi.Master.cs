using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    
    public partial class VentasSushi : System.Web.UI.MasterPage
    {
        wsUsuario.ServiceUsuarioClient UsuarioClient = new wsUsuario.ServiceUsuarioClient();
        wsUsuario.usuario auxUsuario = new wsUsuario.usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                
            }
            else
            {
                
            }
        }

        protected void btnIntranet_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaginaAdmin/LoginAdmin.aspx");
        }

        protected void btnLoginModal_Click(object sender, EventArgs e)
        {
            String mail = txtMailModal.Text;
            String password = txtPasswordModal.Text;
            if (txtMailModal.Text.Trim().Length == 0 || txtPasswordModal.Text.Trim().Length == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                return;
            }
            wsUsuario.usuario user = UsuarioClient.buscarLogin(mail);
            if (user.usuarioId==0)
            {
                ScriptManager.RegisterStartupScript(this.Page , Page.GetType(), "mensajeUser", "usuarioNoExiste()", true); 
                return;
            }
            if (user.usuario1 == mail)
            {
                if (user.pass == password)
                {
                    Session["Usuario"] = user;
                    Session["UserName"] = mail;
                    Session["UserId"] = user.usuarioId;
                    Response.Redirect("~/PaginaUsuario/Bebidas.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorContraseña()", true);
                    return;
                }
            }
        }

    }
}