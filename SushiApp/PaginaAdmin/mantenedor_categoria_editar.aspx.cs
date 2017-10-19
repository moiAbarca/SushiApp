using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantenedor_categoria_editar : System.Web.UI.Page
    {
        wsCategoria.ServiceCategoriaProductoClient categoriaCliente = new wsCategoria.ServiceCategoriaProductoClient();
        wsCategoria.categoriaProducto auxCategoria = new wsCategoria.categoriaProducto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool limpiar()
        {
            bool cad = true;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            this.txtId.Focus();
            return cad;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int id2 = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(this.txtId.Text)).categoriaProductoId;
                    if (id2 == 0)
                    {
                        Response.Write("<script>alert('No se pudo eliminar');</script>");
                        return;
                    }

                    else
                    {
                        categoriaCliente.eliminarCategoriaProducto(Convert.ToInt32(txtId.Text));
                        limpiar();
                        Response.Write("<script>alert('Eliminado correctamente');</script>");
                        this.txtId.Focus();
                    }
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('No se pudo eliminar');</script>");

                    return;
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
            
        }
            
        
    }
}