using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SushiApp.Models;

namespace SushiApp.PaginaUsuario
{
    public partial class Bebidas1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient ProductoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();

        int _productoId;
        String _nombreProducto;
        String _imagenProducto;
        int _precioUnitario;
        int _cantidad;
        int _descuento;
        int _precioTotal;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListadoProductos();
            }
            
        }

        public void ListadoProductos()
        {
            try
            {
                var listadto = ProductoClient.obtenerProducto();
                var auxListadto = (from o in listadto
                                   orderby o.productoId
                                   where o.categoriaProductoId == 7
                                   select new
                                   {
                                       IdProducto = o.productoId,
                                       NombreProducto = o.nombreProducto,
                                       PorcionesProducto = o.porcionesProdcuto,
                                       PrecioProducto = o.precioProducto,
                                       DescripcionProducto = o.descripcionProducto,
                                       ImagenProducto = o.imagenProdcuto,
                                       DisponibilidadProducto = o.disponibilidadProducto
                                   }).ToList();

                dtlProductos.DataSource = auxListadto;
                dtlProductos.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }



        protected void dtlProductos_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {

                string id = e.CommandArgument.ToString();

                Response.Write(id);

                _productoId = Convert.ToInt32(e.CommandArgument.ToString());
                _nombreProducto = ((Label)e.Item.FindControl("lblNombreProducto")).Text;
                _imagenProducto = ((Image)e.Item.FindControl("imgImagenProducto")).ImageUrl;
                _precioUnitario = Convert.ToInt32(((Label)e.Item.FindControl("lblPrecioProducto")).Text);
                _cantidad = 1;
                //_descuento = 
                //_precioTotal;

                Carro prodCarro = new Carro();
                prodCarro.ProductoId = _productoId;
                prodCarro.NombreProducto = _nombreProducto;
                prodCarro.ImagenProducto = _imagenProducto;
                prodCarro.PrecioUnitario = _precioUnitario;



            }
        }
    }
}