using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SushiApp.PaginaUsuario
{
    public partial class TempuraPankoRolls1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();

        DataTable dtb;
        DataTable carrito = new DataTable();
        
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarListViewProductos();
                CargarDetalle();
            }

            //cargarListViewProductos();
            //mostrarModal();

        }

        //Este método inicializa un Datatable para que al momento de ir agregándole las
        // filas (DataRow), no se caiga la app.
        public void CargarDetalle()
        {
            if (Session["Pedido"] == null)
            {
                dtb = new DataTable("Carrito");
                dtb.Columns.Add("ID_PRODUCTO", System.Type.GetType("System.Int32"));
                dtb.Columns.Add("NOMBRE_PRODUCTO", System.Type.GetType("System.String"));
                dtb.Columns.Add("PRECIO_PRODUCTO", System.Type.GetType("System.Int32"));
                dtb.Columns.Add("IMAGEN_PRODUCTO", System.Type.GetType("System.String"));
                dtb.Columns.Add("CANTIDAD_PRODUCTO", System.Type.GetType("System.Int32"));
                dtb.Columns.Add("SUBTOTAL", System.Type.GetType("System.Int32"));

                //Declaramos una variable de tipo Session en donde agregaremos el DataTable recién creado
                Session["Pedido"] = dtb;
            }
        }

        public void AgregarItem(int id, string nombre, int precio, string imagen, int cantidad)
        {
            String _id;
            int subtotal;
            //int cantidad;
            //subtotal = precio * cantidad;

            // Pasamos a una variable de tipo DataTable (Inicializada al comienzo) la Session y
            // luego le creamos una nueva fila a ese DataTable con el método .NewRow();
            carrito = (DataTable)Session["Pedido"];


            //var rows = carrito.Select("PRODUCTO_ID == id");
            DataRow dRow = carrito.AsEnumerable().Where(p => p.Field<Int32>(0) == id).FirstOrDefault();
            if (dRow!=null)
            {
                
                carrito.AsEnumerable().ToList<DataRow>().ForEach
                   (r =>
                   {
                       if (String.Compare(r["ID_PRODUCTO"].ToString(), id.ToString()) == 0)
                           r["CANTIDAD_PRODUCTO"] = cantidad++;
                   }
                   );

            }
            else
            {
                DataRow fila = carrito.NewRow();
                fila[0] = id;
                fila[1] = nombre;
                fila[2] = precio;
                fila[3] = imagen;
                fila[4] = (int)cantidad;
                fila[5] = precio * cantidad;

                // Le pasamos la instancia del DataRow (fila) al DataTable carrito
                carrito.Rows.Add(fila);
            }
            
           
            
               
            

            //foreach (DataRow filas in carrito.Rows)
            //{
            //    foreach (DataColumn columnas in carrito.Columns)
            //    {
            //        filas["ID_PRODUCTO"] = id;
            //    }
            //}

            
            // Le pasamos todo el DataTable "carrito" a la Session.
            Session["Pedido"] = carrito;
        }

        private void cargarListViewProductos()
        {
            try
            {

                //wsProducto.producto[] productos = productoClient.obtenerProducto();       
                //ProductsListView.DataSource = productos;
                //ProductsListView.DataBind();

                var listadto = productoClient.obtenerProducto();
                var nuevolistadto = (from o in listadto
                                     orderby o.productoId
                                     where o.categoriaProductoId == 3 //Puedes comprobar los id cambiando este valor
                                     select new
                                     {
                                         Id = o.productoId,
                                         Nombre = o.nombreProducto,
                                         Imagen = o.imagenProdcuto,
                                         Porciones = o.porcionesProdcuto,
                                         Precio = o.precioProducto,
                                         Descripcion = o.descripcionProducto,
                                         Disponibilidad = o.disponibilidadProducto
                                     }).ToList();
                ProductsListView.DataSource = nuevolistadto;
                ProductsListView.DataBind();
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

                    //String id = e.CommandArgument.ToString();
                    int _productoId;
                    String _nombreProducto = null, _imagenProducto = null;
                    int _precioUnitario = 0;
                    int _cantidad = 1;

                    //Response.Write(id);

                    _productoId = Convert.ToInt32(e.CommandArgument.ToString());
                    _nombreProducto = ((Label)e.Item.FindControl("lblNombreProducto")).Text;
                    _imagenProducto = ((Image)e.Item.FindControl("imgImagenProducto")).ImageUrl;
                    _precioUnitario = Convert.ToInt32(((Label)e.Item.FindControl("lblPrecioProducto")).Text);

                    //_descuento = 
                    //_precioTotal;

                    AgregarItem(_productoId, _nombreProducto, _precioUnitario, _imagenProducto, _cantidad);

                    Session["prueba"] = "Sesión usuario prueba";
                    //Carro prodCarro = new Carro();
                    //prodCarro.ProductoId = _productoId;
                    //prodCarro.NombreProducto = _nombreProducto;
                    //prodCarro.ImagenProducto = _imagenProducto;
                    //prodCarro.PrecioUnitario = _precioUnitario;


                }
            }
            catch (Exception)
            {
                return;
            }

        }
    }
}