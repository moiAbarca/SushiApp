using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class ConfirmacionCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            item_precio.Value = TraerValor().ToString();
            cliente_email.Value = TraerUsuario();

        }
        public int TraerValor()
        {
            int valor = (int)Session["TotalCompra"];
            return valor;
        }

        public String TraerUsuario()
        {
            String user = (String)Session["UserName"];
            return user;
        }
    }
}