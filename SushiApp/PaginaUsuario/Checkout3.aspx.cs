using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout31 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtieneValores();
            }

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

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            if (!web.Checked && !efectivo.Checked)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                return;
            }
            if (web.Checked == true)
            {
                Session["FormaPago"] = "web";
            }
            else
            {
                Session["FormaPago"] = "efectivo";
            }
            Response.Redirect("Checkout4.aspx");
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

        private void ObtieneValores()
        {
            int totCarrito = (int)Session["TotalCarrito"];

            lblSubtotal.Text = totCarrito.ToString();
            lblPropina.Text = (totCarrito * 0.1).ToString();
            lblTotalSinTip.Text = totCarrito.ToString();
            lblTotal.Text = (totCarrito + (totCarrito * 0.1)).ToString();
        }
    }
}