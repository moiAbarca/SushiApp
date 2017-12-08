using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class Ofertas_Productos : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();

        wsOferta.ServiceOfertaClient ofertaClient = new wsOferta.ServiceOfertaClient();
        wsOferta.oferta auxOferta = new wsOferta.oferta();

        wsOfertaProducto.ServiceOfertaProductoClient ofertaProductoClient = new wsOfertaProducto.ServiceOfertaProductoClient();
        wsOfertaProducto.ofertaProducto auxOfertaProducto = new wsOfertaProducto.ofertaProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGVOfertaProductos();
            llenadoDropDownList();
        }

        private void llenadoDropDownList()
        {
            try
            {
                //DL de productos
                var listadto = productoClient.obtenerProducto();
                dlProducto.DataSource = (from o in listadto
                                          orderby o.productoId
                                         select new { o.nombreProducto, o.productoId });
                dlProducto.DataTextField = "nombreProducto";
                dlProducto.DataValueField = "productoId";
                dlProducto.DataBind();

                //DL de oferta
                var listadto2 = ofertaClient.obtenerOferta();
                dlOferta.DataSource = (from o in listadto2
                                          orderby o.ofertaId
                                          select new { o.porcentajeOferta, o.ofertaId });
                dlOferta.DataTextField = "porcentajeOferta";
                dlOferta.DataValueField = "ofertaId";
                dlOferta.DataBind();


            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar DropdownList');</script>");
            }
        }

        private void cargarGVOfertaProductos()
        {
            try
            {
                var listadtoAdministrador = ofertaProductoClient.obtenerOfertaProducto();
                var nuevolistadtoAdministrador = (from o in listadtoAdministrador
                                                      //orderby o.clienteId
                                                  select new
                                                  {
                                                      Id = o.ofertas_producto_Id,
                                                      Oferta = o.ofertaId,
                                                      Producto = o.productoId,
                                                    

                                                  }).ToList();

                gvOfertaProducto.DataSource = nuevolistadtoAdministrador;
                gvOfertaProducto.DataBind();
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
                try
                {
                    auxOfertaProducto = ofertaProductoClient.buscarOfertaProducto(Convert.ToInt32(txtId.Text));
                    dlProducto.SelectedValue = Convert.ToString(auxOfertaProducto.ofertas_producto_Id);
                    dlOferta.SelectedValue = Convert.ToString(auxOfertaProducto.productoId);
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('No se pudo buscar');</script>");
                    return;
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error al realizar la operación solicitada');</script>");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || dlOferta.SelectedIndex == -1 || dlProducto.SelectedIndex == -1)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = ofertaProductoClient.buscarOfertaProducto(Convert.ToInt32(this.txtId.Text)).ofertas_producto_Id;
                    if (id2 == 0)
                    {
                        auxOfertaProducto.ofertas_producto_Id = Convert.ToInt32(this.txtId.Text);
                        auxOfertaProducto.ofertaId = Convert.ToInt32(dlOferta.SelectedValue);
                        auxOfertaProducto.productoId = Convert.ToInt32(dlProducto.SelectedValue);

                        ofertaProductoClient.agregarOfertaProducto(auxOfertaProducto);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                cargarGVOfertaProductos();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error al efectuar la operación');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int id2 = ofertaProductoClient.buscarOfertaProducto(Convert.ToInt32(this.txtId.Text)).ofertas_producto_Id;
                    if (id2 == 0)
                    {
                        Response.Write("<script>alert('No se pudo eliminar');</script>");
                        return;
                    }

                    else
                    {
                        ofertaProductoClient.eliminarOfertaProducto(Convert.ToInt32(txtId.Text));
                        limpiar();
                        Response.Write("<script>alert('Eliminado correctamente');</script>");
                        this.txtId.Focus();
                    }
                    cargarGVOfertaProductos();
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('No se pudo eliminar');</script>");

                    return;
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error al efectuar la operación');</script>");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || dlOferta.SelectedIndex == -1 || dlProducto.SelectedIndex == -1)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = ofertaProductoClient.buscarOfertaProducto(Convert.ToInt32(this.txtId.Text)).ofertas_producto_Id;
                    if (id2 != 0)
                    {
                        auxOfertaProducto.ofertas_producto_Id = Convert.ToInt32(this.txtId.Text);
                        auxOfertaProducto.ofertaId = Convert.ToInt32(dlOferta.SelectedValue);
                        auxOfertaProducto.productoId = Convert.ToInt32(dlProducto.SelectedValue);

                        ofertaProductoClient.modificarOfertaProducto(auxOfertaProducto);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo actualizar Cargo');</script>");
                        return;
                    }
                }
                cargarGVOfertaProductos();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error al efectuar la operación');</script>");
            }
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            dlOferta.SelectedIndex = -1;
            dlProducto.SelectedIndex = -1;
        }
    }
}