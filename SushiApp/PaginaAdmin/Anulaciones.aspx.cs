using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace SushiApp.PaginaAdmin
{
    public partial class Anulaciones : System.Web.UI.Page
    {
        wsPedidoCabecera.ServicePedidoCabeceraClient cabeceraClient = new wsPedidoCabecera.ServicePedidoCabeceraClient();
        wsPedidoCabecera.pedidoCabecera auxPedidoCabecera = new wsPedidoCabecera.pedidoCabecera();

        wsEstablecimiento.ServiceEstablecimientoClient establecimientoClient = new wsEstablecimiento.ServiceEstablecimientoClient();
        wsEstablecimiento.establecimiento auxEstablecimiento = new wsEstablecimiento.establecimiento();

        wsCliente.ServiceClienteClient clienteClient = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGVPedidoCabecera();
        }

        private void cargarGVPedidoCabecera()
        {
            try
            {
                var listaDTOCabecera = cabeceraClient.obtenerPedidoCabecera();
                var listaEstablecimiento = establecimientoClient.obtenerEstablecimiento();
                var listaCliente = clienteClient.obtenerCliente();
                var nuevolistadtoAnulaciones = (from trns in listaDTOCabecera
                                                join st in listaEstablecimiento on trns.establecimientoId equals st.establecimientoId
                                                  join pt in listaCliente on trns.clienteId equals pt.clienteId
                                                  select new
                                                  {
                                                      Id = trns.pedidoCabeceraId,
                                                      Establecimiento = st.nombreLocal,
                                                      Cliente = pt.rut,
                                                      Fecha = trns.fechaPedido,
                                                      Hora = trns.horaPedido,
                                                      Estado = trns.estadoPedido

                                                  }).ToList();

                gvAnulaciones.DataSource = nuevolistadtoAnulaciones;
                gvAnulaciones.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView');</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxPedidoCabecera = cabeceraClient.buscarPedidoCabecera(Convert.ToInt32(txtId.Text));
                txtCliente.Text = Convert.ToString(auxPedidoCabecera.clienteId);
                txtEstablecimiento.Text = Convert.ToString(auxPedidoCabecera.establecimientoId);
                txtEstado.Text = auxPedidoCabecera.estadoPedido;
                txtFecha.Text = auxPedidoCabecera.fechaPedido;
                txtHora.Text = auxPedidoCabecera.horaPedido;
                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }
    

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtCliente.Text.Trim().Length == 0 || txtEstablecimiento.Text.Trim().Length == 0 || txtEstado.Text.Trim().Length == 0 || txtFecha.Text.Trim().Length == 0 || txtHora.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Debe Buscar primero el pedido, antes de cambiar el Estado');</script>");
                    return;
                }
                else
                {
                    int id2 = cabeceraClient.buscarPedidoCabecera(Convert.ToInt32(this.txtId.Text)).pedidoCabeceraId;
                    if (id2 != 0)
                    {

                        DateTime dtHora = Convert.ToDateTime(txtHora.Text);
                        string hora = dtHora.ToString("HH24:MI");

                        DateTime dtFecha = Convert.ToDateTime(txtFecha.Text);
                        string fecha = dtHora.ToString("yyyymmdd");

                        auxPedidoCabecera.pedidoCabeceraId = Convert.ToInt32(this.txtId.Text);
                        auxPedidoCabecera.establecimientoId = Convert.ToInt32(this.txtEstablecimiento.Text);
                        auxPedidoCabecera.clienteId = Convert.ToInt32(this.txtCliente.Text);
                        auxPedidoCabecera.estadoPedido = this.txtEstado.Text;
                        auxPedidoCabecera.fechaPedido = fecha;
                        auxPedidoCabecera.horaPedido = hora;

                        cabeceraClient.modificarPedidoCabecera(auxPedidoCabecera);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo actualizar Cargo');</script>");
                        return;
                    }
                }
                cargarGVPedidoCabecera();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }

        private bool limpiar()
        {
            bool cad = true;
            txtCliente.Text = string.Empty;
            txtEstablecimiento.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtHora.Text = string.Empty;
            txtId.Text = string.Empty;
            this.txtId.Focus();
            return cad;
        }
    }
}