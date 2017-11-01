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
        wsAdministrador.ServiceAdministradorClient administradorClient = new wsAdministrador.ServiceAdministradorClient();
        wsAdministrador.administrador auxAdministrador = new wsAdministrador.administrador();
        protected void Page_Load(object sender, EventArgs e)
        {

            //cargarGVAdministrador();
            cargarGVCliente();
           
        }

        public void cargarGVCliente()
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

        //public void cargarGVAdministrador()
        //{
        //    //grid View de administrador
        //    var listadtoAdministrador = administradorClient.obtenerAdministrador();
        //    var nuevolistadtoAdministrador = (from o in listadtoAdministrador
        //                                          //orderby o.clienteId
        //                                      select new
        //                                      {
        //                                          Id = o.administradorId,
        //                                          Nombre = o.nombreAdmin,
        //                                          Apellido = o.apellidoAdmin,
        //                                          Email = o.corrreoAdmin,
        //                                          Rut = o.telefonoAdmin,

        //                                      }).ToList();

        //    gvAdministrador.DataSource = nuevolistadtoAdministrador;
        //    gvAdministrador.DataBind();
        //}
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
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
            
        }

        protected void btnBuscarAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                auxAdministrador = administradorClient.buscarAdministrador(Convert.ToInt32(txtIdAdministrador.Text));
                txtNombreAdmin.Text = auxAdministrador.nombreAdmin;
                txtApellidoAdmin.Text = auxAdministrador.apellidoAdmin;
                txtEmailAdmin.Text = auxAdministrador.corrreoAdmin;
                txtTelAdmin.Text = auxAdministrador.telefonoAdmin;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }
    }
}