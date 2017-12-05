using SushiApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class ShopBasket1 : System.Web.UI.Page
    {

        DataTable carrito = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarCarrito();
            }

            if (Session["Usuario"] == null)
            {
                mostrarDivLogin();
            }
            else
            {
                ocultarDivLogin();
                Label us = (Label)Master.FindControl("lblUsuario");
                us.Text = (String)Session["UserName"];
            }
        }

        public void cargarCarrito()
        {
            //GridView GV = new GridView();
            // Le pasamos la Session al DataSource del GridView para cargar el listado comprado
            GVCanasta.DataSource = Session["Pedido"];
            GVCanasta.DataBind();
            lblSubtotal.Text = Convert.ToString(TotalCarrito((DataTable)Session["Pedido"]));
            lblTotalSinTip.Text = lblSubtotal.Text;
            double aux = int.Parse(lblSubtotal.Text)*0.1;
            lblPropina.Text = aux.ToString();
            lblTotal.Text = (aux + int.Parse(lblSubtotal.Text)).ToString();
            //Button1_Click(Button1, null);

            carrito = (DataTable)Session["Pedido"];
            try
            {
                int car = carrito.AsEnumerable().Count();
                lblProductosActuales.Text = car.ToString();
            }
            catch (ArgumentNullException ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorCargaDatos()", true);
                return;
            }
            

        }

        public int TotalCarrito(DataTable dt)
        {
            if ((Session["Usuario"] == null))
            {
                return 0;
            }
            else
            {
                int tot = 0;
                foreach (DataRow item in dt.Rows)
                {
                    tot += Convert.ToInt32(item[5]);
                }
                return tot;
            }
            
        }

        protected void btnIr1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout1.aspx");
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