using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantendor_Administrador : System.Web.UI.Page
    {
        wsAdministrador.ServiceAdministradorClient administradorClient = new wsAdministrador.ServiceAdministradorClient();
        wsAdministrador.administrador auxAdministrador = new wsAdministrador.administrador();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGVAdministrador();
            //txtId.Text = "Ingrese Id";
        }

        public void cargarGVAdministrador()
        {            
            try
            {
                var listadtoAdministrador = administradorClient.obtenerAdministrador();
                var nuevolistadtoAdministrador = (from o in listadtoAdministrador
                                                      //orderby o.clienteId
                                                  select new
                                                  {
                                                      Id = o.administradorId,
                                                      Nombre = o.nombreAdmin,
                                                      Apellido = o.apellidoAdmin,
                                                      Email = o.corrreoAdmin,
                                                      Rut = o.telefonoAdmin

                                                  }).ToList();

                gvAdministrador.DataSource = nuevolistadtoAdministrador;
                gvAdministrador.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView Administrador');</script>");
            }

        }

        protected void btnBuscarAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                auxAdministrador = administradorClient.buscarAdministrador(Convert.ToInt32(txtId.Text));
                txtNombre.Text = auxAdministrador.nombreAdmin;
                txtApellido.Text = auxAdministrador.apellidoAdmin;
                txtEmail.Text = auxAdministrador.corrreoAdmin;
                txtTelefono.Text = auxAdministrador.telefonoAdmin;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0 )
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = administradorClient.buscarAdministrador(Convert.ToInt32(this.txtId.Text)).administradorId;
                    if (id2 == 0)
                    {
                        auxAdministrador.administradorId = Convert.ToInt32(this.txtId.Text);
                        auxAdministrador.nombreAdmin = this.txtNombre.Text;
                        auxAdministrador.apellidoAdmin = this.txtApellido.Text;
                        auxAdministrador.corrreoAdmin = this.txtEmail.Text;
                        auxAdministrador.telefonoAdmin = this.txtTelefono.Text;
                        //falta llenar la tabla de administrador y averiguar si el 
                        //id=1 es de administrador
                        auxAdministrador.usuarioId = 1;

                        administradorClient.agregarAdministrador(auxAdministrador);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                cargarGVAdministrador();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }

        private bool limpiar()
        {
            bool cad = true;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            this.txtId.Focus();
            return cad;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxAdministrador = administradorClient.buscarAdministrador(Convert.ToInt32(txtId.Text));                
                txtNombre.Text = auxAdministrador.nombreAdmin;
                txtEmail.Text = auxAdministrador.corrreoAdmin;
                txtApellido.Text = auxAdministrador.apellidoAdmin;                
                txtTelefono.Text = Convert.ToString(auxAdministrador.telefonoAdmin);                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                administradorClient.eliminarAdministrador(Convert.ToInt32(txtId.Text));
                Response.Write("<script>alert('Eliminado Administrador');</script>");
                cargarGVAdministrador();
                limpiar();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo eliminar');</script>");
                return;
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = administradorClient.buscarAdministrador(Convert.ToInt32(this.txtId.Text)).administradorId;
                    if (id2 != 0)
                    {
                        auxAdministrador.administradorId = Convert.ToInt32(this.txtId.Text);
                        auxAdministrador.nombreAdmin = this.txtNombre.Text;
                        auxAdministrador.apellidoAdmin = this.txtApellido.Text;
                        auxAdministrador.corrreoAdmin = this.txtEmail.Text;
                        auxAdministrador.telefonoAdmin = this.txtTelefono.Text;
                        auxAdministrador.usuarioId = 1;

                        administradorClient.modificarAdministrador(auxAdministrador);
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo actualizar Cargo');</script>");
                        return;
                    }
                }
                cargarGVAdministrador();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }
    }
}