using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SushiApp.PaginaUsuario
{
    public partial class CuentaUsuario : System.Web.UI.Page
    {
        wsCliente.ServiceClienteClient clienteCliente = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();

        wsUsuario.ServiceUsuarioClient UsuarioClient = new wsUsuario.ServiceUsuarioClient();
        wsUsuario.usuario auxUsuario = new wsUsuario.usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                mostrarDivLogin();
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                ocultarDivLogin();
                Label us = (Label)Master.FindControl("lblUsuario");
                us.Text = (String)Session["UserName"];
                txtEmail.Text = (String)Session["UserName"];
            }
            if (!IsPostBack)
            {
                ObtieneValoresCliente();
            }
        }

        protected void btnGuardar_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text.Trim().Length == 0 || txtNewPassword.Text.Trim().Length == 0 || txtNewPassword2.Text.Trim().Length == 0)
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "modalLoginEmpty()", true);
                    return;
                }

                String pass = (String)Session["UserPass"];
                if (pass == txtOldPassword.Text)
                {
                    if (txtOldPassword.Text == txtNewPassword.Text || txtOldPassword.Text == txtNewPassword2.Text)
                    {
                        
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "samePassword()", true);
                        return;
                    }
                    else
                    {
                        if (txtNewPassword.Text == txtNewPassword2.Text)
                        {
                            try
                            {
                                auxUsuario.pass = txtNewPassword.Text;
                                auxUsuario.usuario1 = (String)Session["UserName"];
                                auxUsuario.usuarioId = (Int32)Session["UserId"];
                                
                                UsuarioClient.modificarUsuario(auxUsuario);
                                Session["UserPass"] = txtNewPassword.Text;
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "contraModificada()", true);
                                return;
                            }
                            catch (Exception ex)
                            {
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", ex.ToString(), true);
                                return;
                            }

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                            return;
                        }
                    }
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorContraseña()", true);
                    return;
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorIngreso()", true);
                return;
            }
            
        }

        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1)); Response.Cache.SetNoStore();
            mostrarDivLogin();
            Response.Redirect("Inicio.aspx");
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

        protected void ValidateDate(object sender, ServerValidateEventArgs e)
        {
            DateTime date = Convert.ToDateTime(txtFechaNacimiento.Text);

            if (DateTime.Today < date)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "fechaMenorFecha()", true);
                return;
            }
            if (Regex.IsMatch(txtFechaNacimiento.Text, "(((0|1)[0-9]|2[0-9]|3[0-1])\\/(0[1-9]|1[0-2])\\/((19|20)\\d\\d))$"))
            {
                DateTime dt;
                e.IsValid = DateTime.TryParseExact(e.Value, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
                if (e.IsValid)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Valid Date.');", true);
                }
            }
            else
            {
                e.IsValid = false;
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorFecha()", true);
                return;
            }
        }

        protected void btnGuardaDatos_ServerClick(object sender, EventArgs e)
        {
            
        }

        private void ObtieneValoresCliente()
        {
            
            int auxIdUsuario = (int)Session["UserId"];
            var listadto = clienteCliente.obtenerCliente();
            var nuevolistadto = (from o in listadto
                                 orderby o.clienteId
                                 where o.usuarioId == auxIdUsuario
                                 select new
                                 {
                                     clienteId = o.clienteId,
                                     usuarioId = o.usuarioId,
                                     rut = o.rut,
                                     nombre = o.nombre,
                                     apellido = o.apellido,
                                     direccion = o.direccion,
                                     fechaNac = o.fechaNacimiento,
                                     sexo = o.sexo,
                                     email = o.email,
                                     telefono = o.telefono,
                                     comuna = o.comuna
                                 }).ToList();
            foreach (var v in nuevolistadto)
            {
                txtNombre.Text = v.nombre;
                txtApellido.Text = v.apellido;
                txtDireccion.Text = v.direccion;
                ddlSexo.SelectedValue = v.sexo;
                txtFechaNacimiento.Text = "12/12/2017";
                txtRut.Text = v.rut;
                txtTelefono.Text = v.telefono.ToString();
            }

            List < wsCliente.cliente > cli = new List<wsCliente.cliente>();
            //cli.Add(nuevolistadto);

            //var consulta = nuevolistadto.Where(c => c.usuarioId == auxIdUsuario select)

            

            
            
        }
    }
}