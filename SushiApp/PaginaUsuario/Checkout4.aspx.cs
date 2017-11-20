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
        }

        public void cargarCarrito()
        {
            //GridView GV = new GridView();
            // Le pasamos la Session al DataSource del GridView para cargar el listado comprado
            GVCanasta.DataSource = Session["Pedido"];
            GVCanasta.DataBind();
            //Button1_Click(Button1, null);
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            // En este evento se debe hacer persistir la compra y enviar el correo si la compra está ok

            // Una vez persistido, llamamos al método enviar mail
            SendEmail(sender, e);
            this.Response.Write("<script language='JavaScript'>window.alert('PROCESO TERMINADO CORRECTAMENTE')</script>");
            Response.Redirect("Inicio.aspx");
        }

        protected void SendEmail(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
            correo.From = new System.Net.Mail.MailAddress("best_will16@hotmail.com");
            // ***** Agregar el correo del usuario y descomentar *****
            correo.To.Add("wilinho21@gmail.com");
            correo.Subject = "Pedido de Compra";

            string cod, des;
            int cant;
            var items = (DataTable)Session["Pedido"];
            decimal total, prec, subtotal, igv;
            des = "";
            for (int i = 0; i < GVCanasta.Rows.Count; i++)
            {
                cod = (GVCanasta.Rows[i].Cells[1].Text);
                //\
                cant = Convert.ToInt16(GVCanasta.Rows[i].Cells[4].Text);
                prec = Decimal.Parse(GVCanasta.Rows[i].Cells[3].Text);
                des += "\r\n" + (GVCanasta.Rows[i].Cells[2].Text) + " " + "(" + cant + ")" + " " + Convert.ToString(prec) + "\r\n";
                //Actualiza la canasta

                foreach (DataRow objDR in items.Rows)
                {
                    if (objDR["ID_PRODUCTO"].ToString() == cod)
                    {
                        break;
                    }
                }

            }

            correo.Body = "Hola " + " Usted ha realizado un pedido por la cantidad de : S/. " + "\r\n" + des;

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
    }
}