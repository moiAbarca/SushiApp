﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class VentasSushi : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIntranet_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaginaAdmin/LoginAdmin.aspx");
        }
    }
}