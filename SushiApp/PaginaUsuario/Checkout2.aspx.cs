using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout21 : System.Web.UI.Page
    {
        wsCliente.ServiceClienteClient clienteCliente = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtieneValoresCliente();
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

        protected void btnDireccion_Click(object sender, EventArgs e)
        {
            Session["Direccion"] = txtDireccion.Text;
            Session["DetalleDireccion"] = txtDetalle.Text;

            Response.Redirect("Checkout3.aspx");
            
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

        private void ObtieneValoresCliente()
        {
            int auxIdUsuario = (int)Session["UserId"];
            var listadto = clienteCliente.obtenerCliente();
            var nuevolistadto = (from o in listadto
                                 orderby o.clienteId
                                 where o.usuarioId == auxIdUsuario
                                 select new
                                 {
                                     clienteId = o.clienteId,
                                     usuarioId = o.usuarioId,
                                     rut = o.rut,
                                     nombre = o.nombre,
                                     apellido = o.apellido,
                                     direccion = o.direccion,
                                     fechaNac = o.fechaNacimiento,
                                     sexo = o.sexo,
                                     email = o.email,
                                     telefono = o.telefono,
                                     comuna = o.comuna
                                 }).ToList();

            foreach (var v in nuevolistadto)
            {
               
                txtDireccion.Text = v.direccion;
                
                ddlComuna.SelectedValue = v.comuna;
            }
            int totCarrito = (int)Session["TotalCarrito"];

            lblSubtotal.Text = totCarrito.ToString();
            lblPropina.Text = (totCarrito * 0.1).ToString();
            lblTotalSinTip.Text = totCarrito.ToString();
            lblTotal.Text = (totCarrito + (totCarrito * 0.1)).ToString();
            
        }
    }
}