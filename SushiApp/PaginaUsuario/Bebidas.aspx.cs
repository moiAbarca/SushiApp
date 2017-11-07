using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class Bebidas1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient ProductoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();

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

            }
        }
    }
}