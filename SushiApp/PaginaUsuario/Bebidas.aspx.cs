using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SushiApp.Models;
using System.Data;

namespace SushiApp.PaginaUsuario
{
    public partial class Bebidas1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient ProductoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();

        //int _productoId;
        //String _nombreProducto;
        //String _imagenProducto;
        //int _precioUnitario;
        //int _cantidad;
        //int _descuento;
        //int _precioTotal;

        DataTable dtb;
        

        public void CargarDetalle()
        {
            dtb = new DataTable("Carrito");
            dtb.Columns.Add("ID_PRODUCTO", System.Type.GetType("System.Int32"));
            dtb.Columns.Add("NOMBRE_PRODUCTO", System.Type.GetType("System.String"));
            dtb.Columns.Add("PRECIO_PRODUCTO", System.Type.GetType("System.Int32"));
            dtb.Columns.Add("IMAGEN_PRODUCTO", System.Type.GetType("System.String"));
            dtb.Columns.Add("SUBTOTAL", System.Type.GetType("System.Int32"));
            dtb.Columns.Add("CANTIDAD_PRODUCTO", System.Type.GetType("System.Int32"));

            Session["Pedido"] = dtb;
        }

        public void AgregarItem(int id, string nombre, int precio, string imagen)
        {
            int total;
            int cantidad = 1;
            total = precio * cantidad;
            DataTable Carrito = (DataTable)Session["Pedido"];
            //if ((DataTable)Session["Pedido"] == null)
            //{
            //    Carrito = new DataTable();
            //}
            //else
            //{
            //    Carrito = (DataTable)Session["Pedido"];
            //}

            
            DataRow fila = Carrito.NewRow();
            fila[0] = id;
            fila[1] = imagen;
            fila[2] = nombre;
            fila[3] = precio;
            fila[4] = (int)cantidad;
            fila[5] = total;
            Carrito.Rows.Add(fila);
            Session["Pedido"] = Carrito;
        }


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

                //String id = e.CommandArgument.ToString();
                int _productoId;
                String _nombreProducto = null, _imagenProducto = null;
                int _precioUnitario = 0;
                //int _cantidad = 1;

                //Response.Write(id);

                _productoId = Convert.ToInt32(e.CommandArgument.ToString());
                _nombreProducto = ((Label)e.Item.FindControl("lblNombreProducto")).Text;
                _imagenProducto = ((Image)e.Item.FindControl("imgImagenProducto")).ImageUrl;
                _precioUnitario = Convert.ToInt32(((Label)e.Item.FindControl("lblPrecioProducto")).Text);
                
                //_descuento = 
                //_precioTotal;

                AgregarItem(_productoId, _nombreProducto, _precioUnitario, _imagenProducto);
                Session["prueba"] = "Sesión usuario prueba";

                //Carro prodCarro = new Carro();
                //prodCarro.ProductoId = _productoId;
                //prodCarro.NombreProducto = _nombreProducto;
                //prodCarro.ImagenProducto = _imagenProducto;
                //prodCarro.PrecioUnitario = _precioUnitario;





            }
        }
    }
}