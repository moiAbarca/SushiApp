using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class PagoOk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                mostrarDivLogin();
                Response.Redirect("Inicio.aspx");
            }
            else
            {

                Thread.Sleep(7000);
                Response.Redirect("CuentaUsuario.aspx");
            }
           
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