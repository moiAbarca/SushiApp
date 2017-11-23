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

        }

        protected void btnIntranet_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnLoginModal_Click(object sender, EventArgs e)
        {
            String mail = txtMailModal.Text;
            String password = txtPasswordModal.Text;

            //wsUsuario.usuario[] usuarios = UsuarioClient.obtenerUsuario();

            

            var listadto = UsuarioClient.obtenerUsuario();
            var nuevolistadto = (from o in listadto
                                 where o.usuario1 == mail
                                 && o.pass == password
                                 select
                                     o.usuario1
                                 ).ToString();

            if (nuevolistadto == mail)
            {
                Response.Redirect("~/PaginaAdmin/LoginAdmin.aspx");
            }
            else
            {
                Response.Redirect("~/PaginaUsuario/Bebidas.aspx");
            }
            

        }

       
    }
}