using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout41 : System.Web.UI.Page
    {
        DataTable carrito = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarCarrito();
            }

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
            }
        }

        public void cargarCarrito()
        {
            carrito = (DataTable)Session["Pedido"];
            try
            {
                int car = carrito.AsEnumerable().Count();
                lblProductosActuales.Text = car.ToString();
            }
            catch (ArgumentNullException ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorCargaDatos()", true);
                return;
            }
            
            // Le pasamos la Session al DataSource del GridView para cargar el listado comprado
            GVCanasta.DataSource = Session["Pedido"];
            GVCanasta.DataBind();
            int auxSubtotal = Convert.ToInt32(TotalCarrito((DataTable)Session["Pedido"]));
            lblSubtotal.Text = String.Format("{0:C}", auxSubtotal);
            lblTotalSinTip.Text = String.Format("{0:C}", auxSubtotal);
            int aux = Convert.ToInt32(auxSubtotal * 0.1);
            lblPropina.Text = String.Format("{0:C}", aux);
            int totaliza = aux + auxSubtotal;
            lblTotal.Text = String.Format("{0:C}", auxSubtotal + aux);
            //Button1_Click(Button1, null);
        }

        public int TotalCarrito(DataTable dt)
        {
            try
            {
                int tot = 0;
                foreach (DataRow item in dt.Rows)
                {
                    tot += Convert.ToInt32(item[5]);
                }
                return tot;
            }
            catch (NullReferenceException ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorCargaDatos()", true);
                return 0;
            }
            
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            carrito = (DataTable)Session["Pedido"];
            int car = carrito.AsEnumerable().Count();
            if (car == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "shopBasketEmpty()", true);

                return;
            }
            // En este evento se debe hacer persistir la compra y enviar el correo si la compra está ok

            // Una vez persistido, llamamos al método enviar mail
            SendEmail(sender, e);
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "ventaOk()", true);

            Response.Redirect("Inicio.aspx");
        }

        protected void SendEmail(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
            correo.From = new System.Net.Mail.MailAddress("contactofukusukesushi@gmail.com");
            // ***** Agregar el correo del usuario y descomentar *****
            String auxCorreo = (String)Session["UserName"];
            correo.To.Add(auxCorreo);
            correo.Subject = "Pedido de Compra";

            string cod, des;
            int cant, prec;
            var items = (DataTable)Session["Pedido"];
            decimal total, subtotal, igv;
            des = "";
            for (int i = 0; i < GVCanasta.Rows.Count; i++)
            {
                cod = (GVCanasta.Rows[i].Cells[1].Text);
                //\
                cant = Convert.ToInt16(GVCanasta.Rows[i].Cells[3].Text);
                prec = Convert.ToInt32(GVCanasta.Rows[i].Cells[2].Text);
                des += "\r\n" + (GVCanasta.Rows[i].Cells[1].Text) + " " + "(" + cant + ")" + " " + Convert.ToString(prec) + "\r\n";
                //Actualiza la canasta

                foreach (DataRow objDR in items.Rows)
                {
                    if (objDR["ID_PRODUCTO"].ToString() == cod)
                    {
                        break;
                    }
                }

            }

            correo.Body = "Hola " + auxCorreo +  " Usted ha realizado una compra por la cantidad de : " + lblSubtotal.Text + "\r\n " + "De los siguientes productos en nuestra tienda online Fukusuke Sushi Delivery" +"\r\n " + des +  "\n" +  "Muchas gracias por su compra" + "\r\n " + "Equipo Fukusuke Sushi";

            correo.IsBodyHtml = false;
            correo.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";  //para gmail
            //smtp.Host = "smtp.live.com"; //para hotmail
            smtp.Port = 587;
            //Completar con  las credenciales del correo ingresado arriba
            smtp.Credentials = new System.Net.NetworkCredential("contactofukusukesushi@gmail.com", "fukusuke");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(correo);
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "ventaOk()", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorConexion()", true);
                return;

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

        protected void btnPagar_ServerClick(object sender, EventArgs e)
        {
            carrito = (DataTable)Session["Pedido"];
            if (carrito.AsEnumerable().Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "shopBasketEmpty()", true);
                return;
            }
            else
            {
                int totaliza = Int32.Parse(lblTotal.Text, NumberStyles.Currency);
                //SendEmail(sender, e);
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "ventaOk()", true);
                Session["TotalCompra"] = totaliza;
                //Response.Redirect("http://www.checkbox.cl/PaymentGateway/linkPayment.php?id_comercio=160&url_return=http://localhost:2205/PaginaUsuario/PagoOk.aspx&url_cancel=http://localhost:2205/PaginaUsuario/ErrorPago.aspx&item_nombre=" + "Pedido de " + auxCorreo + "&item_id=01" + "&item_precio=" + totaliza);
                Response.Redirect("PagoOk.aspx");
            }
        }

        protected void GVCanasta_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt1 = Session["Pedido"] as DataTable;

            int index = e.RowIndex;
            try
            {
                dt1.Rows[index].Delete();
            }
            catch (IndexOutOfRangeException)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "errorCargaDatos()", true);
                return;
            }

            Session["Pedido"] = dt1;
            GVCanasta.DataSource = dt1;
            GVCanasta.DataBind();
            cargarCarrito();
        }
    }
}