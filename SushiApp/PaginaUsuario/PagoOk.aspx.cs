using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class PagoOk : System.Web.UI.Page
    {
        wsPedidoCabecera.ServicePedidoCabeceraClient pedidoCabeceraClient = new wsPedidoCabecera.ServicePedidoCabeceraClient();
        wsPedidoCabecera.pedidoCabecera auxPedidoCabecera = new wsPedidoCabecera.pedidoCabecera();

        wsPedidoDetalle.ServicePedidoDetalleClient pedidoDetalleClient = new wsPedidoDetalle.ServicePedidoDetalleClient();
        wsPedidoDetalle.pedidoDetalle auxPedidoDetalle = new wsPedidoDetalle.pedidoDetalle();

        wsCliente.ServiceClienteClient clienteClient = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                PersisteCompra();
                Thread.Sleep(5000);
                Response.Redirect("CuentaUsuario.aspx");
            }

        }

        

        private void PersisteCompra()
        {
            
            DataTable dt1 = Session["Pedido"] as DataTable;
            int auxIdUsuario = (int)Session["UserId"];

            var listadto = clienteClient.obtenerCliente();
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
                auxPedidoCabecera.clienteId = v.clienteId;
            }

            auxPedidoCabecera.establecimientoId = 1;
            auxPedidoCabecera.fechaPedido = DateTime.Today.ToString("yyyyMMdd");
            auxPedidoCabecera.horaPedido = DateTime.Now.ToString("hh:mm");
            auxPedidoCabecera.estadoPedido = "Pagado";

            pedidoCabeceraClient.agregarPedidoCabecera(auxPedidoCabecera);

            var consulta = pedidoCabeceraClient.obtenerPedidoCabecera();
            var auxConsulta = (from o in consulta
                               where o.clienteId == auxIdUsuario
                               orderby o.pedidoCabeceraId ascending
                               select new
                               {
                                   cabeceraId = o.pedidoCabeceraId
                               }).ToList();
            foreach (var c in auxConsulta)
            {
                auxPedidoDetalle.pedidoCabeceraId = c.cabeceraId;
            }
            //auxPedidoDetalle.pedidoCabeceraId = Convert.ToInt32(auxConsulta);

            //auxPedidoDetalle.pedidoCabeceraId = Convert.ToInt32(auxConsulta.ToString());


            foreach (DataRow row in dt1.Rows)
            {
                auxPedidoDetalle.productoId = Convert.ToInt32(row["ID_PRODUCTO"].ToString());
                auxPedidoDetalle.cantidad = Convert.ToInt32(row["CANTIDAD_PRODUCTO"].ToString());
                auxPedidoDetalle.total = Convert.ToInt32(row["SUBTOTAL"].ToString());
                pedidoDetalleClient.agregarPedidoDetalle(auxPedidoDetalle);
            }



        }


    }

}
