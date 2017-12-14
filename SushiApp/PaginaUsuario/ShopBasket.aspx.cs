﻿using SushiApp.Models;
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
            Double auxSubtotal = Convert.ToDouble(TotalCarrito((DataTable)Session["Pedido"]));
            lblSubtotal.Text = String.Format("{0:C}", auxSubtotal);
            lblTotalSinTip.Text = String.Format("{0:C}", auxSubtotal);
            double aux = auxSubtotal * 0.1;
            lblPropina.Text = String.Format("{0:C}", aux);
            lblTotal.Text = String.Format("{0:C}", auxSubtotal + aux);
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
            int tot = 0;
            foreach (DataRow item in dt.Rows)
            {
                tot += Convert.ToInt32(item[5]);
            }

            Session["TotalCarrito"] = tot;
            return tot;

        }

        protected void btnIr1_Click(object sender, EventArgs e)
        {
            carrito = (DataTable)Session["Pedido"];
            if (carrito.AsEnumerable().Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "shopBasketEmpty()", true);
                return;
            }
            else
            {
                Response.Redirect("Checkout1.aspx");
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

        protected void GVCanasta_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt1 = Session["Pedido"] as DataTable;

            int index = e.RowIndex;
            try
            {
                dt1.Rows[index].Delete();
            }
            catch (IndexOutOfRangeException)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorCargaDatos()", true);
                return;
            }

            Session["Pedido"] = dt1;
            GVCanasta.DataSource = dt1;
            GVCanasta.DataBind();
            cargarCarrito();




        }


    }
}