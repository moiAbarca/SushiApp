using SushiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class ShopBasket1 : System.Web.UI.Page
    {
        //public CarroCollection CarroCompra
        //{
        //    get
        //    {
        //        return (CarroCollection)Session["_carroCompra"];
        //    }
        //    set
        //    {
        //        Session["_carroCompra"] = value;
        //    }

        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarCarrito();
            }
        }

        public void cargarCarrito()
        {
            //GridView GV = new GridView();
            // Le pasamos la Session al DataSource del GridView para cargar el listado comprado
            GVCanasta.DataSource = Session["Pedido"];
            GVCanasta.DataBind();
            //Button1_Click(Button1, null);
        }

        protected void btnIr1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout1.aspx");
        }
    }
}