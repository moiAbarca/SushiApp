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
        protected void Page_Load(object sender, EventArgs e)
        {
            string fecha = string.Empty;
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
                txtTelefono.Text = Convert.ToString(auxCliente.telefono);
                txtFechaNacimiento.Text = auxCliente.fechaNacimiento;


                //txtId.Text = Convert.ToString(auxUsuario.);
                //txtNombre.Text = auxCategoria.nombreCategoria;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
            
        }
    }
}