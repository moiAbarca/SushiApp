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

            wsUsuario.usuario user = UsuarioClient.buscarLogin(mail);
            if (user.usuario1 == mail && user.pass==password)
            {

                Session["Usuario"] = user;
                Response.Redirect("~/PaginaUsuario/CuentaUsuario.aspx");
            }
            else
            {
                Response.Redirect("~/PaginaUsuario/RegistroUsuario.aspx");
            }
            

        }

    }
}