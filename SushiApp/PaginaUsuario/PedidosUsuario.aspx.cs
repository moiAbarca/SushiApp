using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class PedidosUsuario : System.Web.UI.Page
    {

        wsPedidoCabecera.ServicePedidoCabeceraClient cabeceraClient = new wsPedidoCabecera.ServicePedidoCabeceraClient();
        wsPedidoDetalle.ServicePedidoDetalleClient detalleClient = new wsPedidoDetalle.ServicePedidoDetalleClient();
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();

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

        //private void cargarGridReporte()
        //{
        //    try
        //    {

        //        var listaCabecera = cabeceraClient.obtenerPedidoCabecera();
        //        var listaDetalle = detalleClient.obtenerPedidoDetalle();
        //        var listaProducto = productoClient.obtenerProducto();
        //        var nuevolistadtoDespacho = (from det in listaCabecera
        //                                     where det.clienteId = 
        //                                     join pr in listaProducto on det.productoId equals pr.productoId
        //                                     join cab in listaCabecera on det.pedidoCabeceraId equals cab.pedidoCabeceraId
        //                                     select new
        //                                     {
        //                                         Id = cab.pedidoCabeceraId,
        //                                         Producto = pr.nombreProducto,
        //                                         Fecha = cab.fechaPedido,
        //                                         PrecioProducto = pr.precioProducto,
        //                                         Cantidad = det.cantidad,
        //                                         TotalProducto = det.total
        //                                     }).ToList();

        //        ComprasListView.DataSource = nuevolistadtoDespacho;
        //        ComprasListView.DataBind();

        //    }
        //    catch (Exception)
        //    {

        //        Response.Write("<script>alert('No se pudo cargar GridView');</script>");
        //    }
        //}
    }
}