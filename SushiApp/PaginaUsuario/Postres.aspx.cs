using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SushiApp.PaginaUsuario
{

    public partial class Postres1 : System.Web.UI.Page
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

            if (Session["Usuario"] == null)
            {
                mostrarDivLogin();
            }
            else
            {
                ocultarDivLogin();
                Label us = (Label)Master.FindControl("lblUsuario");
                us.Text = (String)Session["UserName"];
            }

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

        public void AgregarItem(int id, string nombre, int precio, string imagen)
        {
            String _id;
            int subtotal;
            //int cantidad;
            //subtotal = precio * cantidad;

            // Pasamos a una variable de tipo DataTable (Inicializada al comienzo) la Session y
            // luego le creamos una nueva fila a ese DataTable con el método .NewRow();
            carrito = (DataTable)Session["Pedido"];

            DataRow dRow = carrito.AsEnumerable().Where(p => p.Field<Int32>(0) == id).FirstOrDefault();

            if (dRow != null)
            {
                if (dRow.Field<Int32>(0) == id)
                {
                    int cant = dRow.Field<Int32>(4) + 1;
                    DataRow auxDRow = dRow;
                    dRow.Delete();
                    auxDRow[0] = id;
                    auxDRow[1] = nombre;
                    auxDRow[2] = precio;
                    auxDRow[3] = imagen;
                    auxDRow[4] = cant;
                    auxDRow[5] = precio * cant;

                    carrito.Rows.Add(auxDRow);
                    //carrito.AsEnumerable().ToList<DataRow>().ForEach
                    //   (r =>
                    //   {
                    //       if (String.Compare(r["ID_PRODUCTO"].ToString(), id.ToString()) == 0)
                    //           r["CANTIDAD_PRODUCTO"] = cantidad++;

                    //   });
                }

            }
            else
            {
                int cant = 1;
                DataRow fila = carrito.NewRow();
                fila[0] = id;
                fila[1] = nombre;
                fila[2] = precio;
                fila[3] = imagen;
                fila[4] = cant;
                fila[5] = precio * cant;
                // Le pasamos la instancia del DataRow (fila) al DataTable carrito
                carrito.Rows.Add(fila);
            }
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
                                     where o.categoriaProductoId == 6 //Puedes comprobar los id cambiando este valor
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
                lblCantProd.Text = nuevolistadto.Count().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: (" + ex.Message + ")");
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
                    //int _cantidad = 1;
                    //Response.Write(id);
                    _productoId = Convert.ToInt32(e.CommandArgument.ToString());
                    _nombreProducto = ((Label)e.Item.FindControl("lblNombreProducto")).Text;
                    _imagenProducto = ((Image)e.Item.FindControl("imgImagenProducto")).ImageUrl;
                    _precioUnitario = Convert.ToInt32(((Label)e.Item.FindControl("lblPrecioProducto")).Text);

                    AgregarItem(_productoId, _nombreProducto, _precioUnitario, _imagenProducto);

                    //Carro prodCarro = new Carro();
                    //prodCarro.ProductoId = _productoId;
                    //prodCarro.NombreProducto = _nombreProducto;
                    //prodCarro.ImagenProducto = _imagenProducto;
                    //prodCarro.PrecioUnitario = _precioUnitario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: (" + ex.Message + ")");
            }

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
    }
}