using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantenedor_categoria1 : System.Web.UI.Page
    {
        wsCategoria.ServiceCategoriaProductoClient categoriaCliente = new wsCategoria.ServiceCategoriaProductoClient();
        wsCategoria.categoriaProducto auxCategoria = new wsCategoria.categoriaProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
                CargaGVCategoria();           
        }

        public void CargaGVCategoria()
        {
            gv1.DataSource = categoriaCliente.obtenerCategoriaProducto();            
            gv1.DataBind();
            gv1.HeaderRow.Cells[0].Text = "Id";
            gv1.HeaderRow.Cells[1].Text = "Nombre";

        }

        private bool limpiar()
        {
            bool cad = true;
            txtIdCategoria.Text = string.Empty;
            txtNombreCategoria.Text = string.Empty;
            this.txtIdCategoria.Focus();
            return cad;
        }

        protected void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            //String.IsNullOrEmpty(car.buscaCurso(this.txtCod_Curso.Text).Cod_Curso))
            try
            {
                if (txtIdCategoria.Text.Trim().Length == 0 || txtNombreCategoria.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(this.txtIdCategoria.Text)).categoriaProductoId;
                    if (id2 != 0)
                    {
                        auxCategoria.categoriaProductoId = Convert.ToInt32(this.txtIdCategoria.Text);
                        auxCategoria.nombreCategoria = this.txtNombreCategoria.Text;

                        categoriaCliente.modificarCategoriaProducto(auxCategoria);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo actualizar Cargo');</script>");
                        return;
                    }
                }
                CargaGVCategoria();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error al efectuar la operación');</script>");
            }

            
        }

        protected void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    auxCategoria = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(txtIdCategoria.Text));
                    txtIdCategoria.Text = Convert.ToString(auxCategoria.categoriaProductoId);
                    txtNombreCategoria.Text = auxCategoria.nombreCategoria;
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('No se pudo buscar');</script>");
                    return;
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
            
        }

        protected void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCategoria.Text.Trim().Length == 0 || txtNombreCategoria.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(this.txtIdCategoria.Text)).categoriaProductoId;
                    if (id2 == 0)
                    {
                        auxCategoria.categoriaProductoId = Convert.ToInt32(this.txtIdCategoria.Text);
                        auxCategoria.nombreCategoria = this.txtNombreCategoria.Text;

                        categoriaCliente.agregarCategoriaProducto(auxCategoria);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                CargaGVCategoria();
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
                    int id2 = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(this.txtIdCategoria.Text)).categoriaProductoId;
                    if (id2 == 0)
                    {
                        Response.Write("<script>alert('No se pudo eliminar');</script>");
                        return;
                    }

                    else
                    {
                        categoriaCliente.eliminarCategoriaProducto(Convert.ToInt32(txtIdCategoria.Text));
                        limpiar();
                        Response.Write("<script>alert('Eliminado correctamente');</script>");
                        this.txtIdCategoria.Focus();
                    }
                    CargaGVCategoria();
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
                if (txtIdCategoria.Text.Trim().Length == 0 || txtNombreCategoria.Text.Trim().Length == 0 )
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = categoriaCliente.buscarCategoriaProducto(Convert.ToInt32(this.txtIdCategoria.Text)).categoriaProductoId;
                    if (id2 != 0)
                    {
                        auxCategoria.categoriaProductoId = Convert.ToInt32(this.txtIdCategoria.Text);
                        auxCategoria.nombreCategoria = this.txtNombreCategoria.Text;
                        
                        categoriaCliente.modificarCategoriaProducto(auxCategoria);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                CargaGVCategoria();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }
    }
}