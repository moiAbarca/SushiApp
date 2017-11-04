using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class CaliforniaRolls1 : System.Web.UI.Page
    {
        public CarroCollection CarroCompra
        {
            get
            {
                return (CarroCollection)Session["_carroCompra"];
            }
            set
            {
                Session["_carroCompra"] = value;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCaliforniaVeggieAgrega_Click(object sender, EventArgs e)
        {

        }

        protected void btnCaliforniaCheeseAgrega_Click(object sender, EventArgs e)
        {

        }

        protected void btnCaliforniaCapresseAgrega_Click(object sender, EventArgs e)
        {

        }
    }
}