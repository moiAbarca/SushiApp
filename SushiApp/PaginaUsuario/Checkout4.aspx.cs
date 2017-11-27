using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout41 : System.Web.UI.Page
    {
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
            //GridView GV = new GridView();
            // Le pasamos la Session al DataSource del GridView para cargar el listado comprado
            GVCanasta.DataSource = Session["Pedido"];
            GVCanasta.DataBind();
            lblSubtotal.Text = Convert.ToString(TotalCarrito((DataTable)Session["Pedido"]));
            lblTotalSinTip.Text = lblSubtotal.Text;
            double aux = int.Parse(lblSubtotal.Text) * 0.1;
            lblPropina.Text = aux.ToString();
            lblTotal.Text = (aux + int.Parse(lblSubtotal.Text)).ToString();
            //Button1_Click(Button1, null);
        }

        public int TotalCarrito(DataTable dt)
        {
            int tot = 0;
            foreach (DataRow item in dt.Rows)
            {
                tot += Convert.ToInt32(item[5]);
            }
            return tot;
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            // En este evento se debe hacer persistir la compra y enviar el correo si la compra está ok

            // Una vez persistido, llamamos al método enviar mail
            SendEmail(sender, e);
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "mensajeUser", "ventaOk()", true);

            Response.Redirect("Inicio.aspx");
        }

        protected void SendEmail(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
            correo.From = new System.Net.Mail.MailAddress("best_will16@hotmail.com");
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

            correo.Body = "Hola " + auxCorreo +  " Usted ha realizado un pedido por la cantidad de : $ " + lblSubtotal.Text + "\r\n" + des;

            correo.IsBodyHtml = false;
            correo.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            //smtp.Host = "smtp.gmail.com"  'para gmail
            smtp.Host = "smtp.live.com"; //para hotmail
            smtp.Port = 587;
            //Completar con  las credenciales del correo ingresado arriba
            smtp.Credentials = new System.Net.NetworkCredential("best_will16@hotmail.com", "166938198");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(correo);
                this.Response.Write("<script language='JavaScript'>window.alert('Venta Enviada Correctamente')</script>");
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