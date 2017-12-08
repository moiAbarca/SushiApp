using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantenedor_clientes1 : System.Web.UI.Page
    {
        wsCliente.ServiceClienteClient clienteClient = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            cargarGVCliente();                     
        }
        
        public void cargarGVCliente()
        {
            try
            {
                var listadto = clienteClient.obtenerCliente();
                var nuevolistadto = (from o in listadto
                                     orderby o.clienteId
                                     select new
                                     {
                                         Id = o.clienteId,
                                         Nombre = o.nombre,
                                         Apellido = o.apellido,
                                         Email = o.email,
                                         Rut = o.rut,
                                         Fecha_Nacimiento = o.fechaNacimiento
                                     }).ToList();

                gvCliente.DataSource = nuevolistadto;
                gvCliente.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView Cliente');</script>");
            }
            
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                auxCliente = clienteClient.buscarCliente(Convert.ToInt32(txtId.Text));
                txtRut.Text = auxCliente.rut;
                txtNombre.Text = auxCliente.nombre;
                txtEmail.Text = auxCliente.email;
                txtApellido.Text = auxCliente.apellido;
                txtDireccion.Text = auxCliente.direccion;
                txtSexo.Text = auxCliente.sexo;
                calFechaNacimiento.SelectedDate = Convert.ToDateTime(auxCliente.fechaNacimiento);
                txtTelefono.Text = Convert.ToString(auxCliente.telefono);                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
            
        }

        protected void btnBuscarAdministrador_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = clienteClient.buscarCliente(Convert.ToInt32(this.txtId.Text)).clienteId;
                    if (id2 == 0)
                    {
                        auxCliente.clienteId = Convert.ToInt32(this.txtId.Text);
                        auxCliente.nombre = this.txtNombre.Text;
                        auxCliente.apellido = this.txtApellido.Text;
                        auxCliente.email = this.txtEmail.Text;
                        auxCliente.telefono = Convert.ToInt32(this.txtTelefono.Text);
                        auxCliente.direccion = txtDireccion.Text;
                        auxCliente.rut = txtRut.Text;
                        auxCliente.sexo = txtSexo.Text;
                        auxCliente.fechaNacimiento = calFechaNacimiento.SelectedDate.ToString("yyyyMMdd");

                        auxCliente.usuarioId = 1;
                        auxCliente.comuna = "Maipu";
                        
                        clienteClient.agregarCliente(auxCliente);
                        Response.Write("<script>alert('Agregado correctamente');</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                cargarGVCliente();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteClient.eliminarCliente(Convert.ToInt32(txtId.Text));
                Response.Write("<script>alert('Eliminado Administrador');</script>");
                cargarGVCliente();
                limpiar();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo eliminar');</script>");
                
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = clienteClient.buscarCliente(Convert.ToInt32(this.txtId.Text)).clienteId;
                    if (id2 != 0)
                    {
                        auxCliente.clienteId = Convert.ToInt32(this.txtId.Text);
                        auxCliente.nombre = this.txtNombre.Text;
                        auxCliente.apellido = this.txtApellido.Text;
                        auxCliente.email = this.txtEmail.Text;
                        auxCliente.telefono = Convert.ToInt32(this.txtTelefono.Text);
                        auxCliente.direccion = txtDireccion.Text;
                        auxCliente.rut = txtRut.Text;
                        auxCliente.sexo = txtSexo.Text;
                        auxCliente.fechaNacimiento = calFechaNacimiento.SelectedDate.ToString("yyyyMMdd");

                        auxCliente.usuarioId = 1;
                        auxCliente.comuna = "Maipu";

                        clienteClient.modificarCliente(auxCliente);
                        Response.Write("<script>alert('Modificado correctamente');</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                cargarGVCliente();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo editar');</script>");
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
            txtRut.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtSexo.Text = string.Empty;
            calFechaNacimiento.SelectedDates.Clear();
            this.txtId.Focus();
            return cad;
        }
    }
}