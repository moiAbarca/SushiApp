using SushiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaUsuario
{
    public partial class TempuraPankoRolls1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarListViewProductos();                
            }

            //cargarListViewProductos();
            //mostrarModal();

        }

        private void cargarListViewProductos()
        {
            try
            {
                wsProducto.producto[] productos = productoClient.obtenerProducto();
                ProductsListView.DataSource = productos;
                ProductsListView.DataBind();

                //var listadto = productoClient.obtenerProducto();
                //var nuevolistadto = (from o in listadto
                //                     orderby o.productoId
                //                     where o.categoriaProductoId == 1 //Puedes comprobar los id cambiando este valor
                //                     select new
                //                     {
                //                         Id = o.productoId,
                //                         Nombre = o.nombreProducto,
                //                         Imagen = o.imagenProdcuto,
                //                         Porciones = o.porcionesProdcuto,
                //                         Precio = o.precioProducto,
                //                         Descripción = o.descripcionProducto,
                //                         Disponibilidad = o.disponibilidadProducto
                //                     }).ToList();
                //ProductsListView.DataSource = nuevolistadto;
                //ProductsListView.DataBind();
            }
            catch (Exception ex)
            {
                                
            }
        }

        protected void ProductsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ProductsListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Agregar")
                {
                    //ButtonProducto boton = (ButtonProducto)sender;
                    //Producto.Add(boton.producto);

                    // En el Control ASP:Button, se agrega la propiedad "CommandArgument", 
                    // la que toma los valores de IDPRODUCTO '<%# Eval("IDPRODUCTO") %>'
                    // Con esto ya tenemos que botón es el que seleccionó el usuario y por tanto podemos pasar
                    // ese ID al carrito
                    string id = e.CommandArgument.ToString();
                    Response.Write(id);
                    // El Id será visible al comienzo de la página...

                   


                }
            }
            catch (Exception)
            {

            }
           
        }
    }
}