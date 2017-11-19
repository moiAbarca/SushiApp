using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SushiApp.Models
{
    public class ButtonProducto : Button
    {
        public Producto producto { get; set; }
    }
}