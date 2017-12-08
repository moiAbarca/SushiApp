using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SushiApp
{
    /// <summary>
    /// Descripción breve de wsEmail2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
     [System.Web.Script.Services.ScriptService]
    public class wsEmail2 : System.Web.Services.WebService
    {

        [WebMethod]
        public void EmailConfirmacion(string email)
        {
            EmailConfirmacion(email);
        }

        [WebMethod]
        public void EmailBoleta(string email, string boleta)
        {
            EmailBoleta(email, boleta);
        }
    }
}
