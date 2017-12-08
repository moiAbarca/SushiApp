using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.ComponentModel;
using System.Data;

namespace SushiApp.Models
{
    public class Email
    {
        public Email() { }

        private bool EmailConfirmación(string mail)

        {
            string nombre = "Señor(a): "; //+ lblNombreUsuario.Text + " " + lblApellidoP.Text;
            string fecha = "Fecha:" + DateTime.Now.ToString();
            Usuario auxUsuario = new Usuario();
            string correoTO = mail;
            //string cargo = "Usuario: " + lblTipoUsuario.Text;
            //string idA = "N° ID: " + lblIdApoderado.Text;
            //string cantDepositos = "Cantidad de depósitos: " + lblCantidadDepositos.Text;
            //string totalDep = "Monto que lleva Depositado hasta la fecha: $" + lblMontoTotal.Text;
            //string metaDep = "Meta para el el Tour: $" + lblMetaDeposito.Text;
            //string falta = "Para completar la meta a usted le faltan: $" + lblfalta.Text;



            MailMessage msg = new MailMessage();
            msg.To.Add(correoTO);
            msg.From = new MailAddress("fukusukesushi7@gmail.com", "sushi123", System.Text.Encoding.UTF8);
            msg.Subject = "Mail de Confirmación";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = nombre;

            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false; //Si vas a enviar un correo con contenido html entonces cambia el valor a true
                                    //Aquí es donde se hace lo especial

            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("fukusukesushi7@gmail.com", "sushi123");

            client.Port = 587;

            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail

            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

            try

            {
                client.Send(msg);

                return true;
            }

            catch (Exception ex)

            {
                return false;
            }

        }

        private bool EmailBoleta(string mail, string boleta)

        {
            string nombre = "Señor(a): "; //+ lblNombreUsuario.Text + " " + lblApellidoP.Text;
            string fecha = "Fecha:" + DateTime.Now.ToString();
            Usuario auxUsuario = new Usuario();
            string correoTO = mail;            
            string boleta2 = "Su boleta actual es de: \n" + boleta;


            MailMessage msg = new MailMessage();
            msg.To.Add(correoTO);
            msg.From = new MailAddress("fukusukesushi7@gmail.com", "sushi123", System.Text.Encoding.UTF8);
            msg.Subject = "Mail de Confirmación";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = nombre;

            msg.BodyEncoding = System.Text.Encoding.UTF8;

            msg.IsBodyHtml = false; //Si vas a enviar un correo con contenido html entonces cambia el valor a true
                                    //Aquí es donde se hace lo especial

            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("fukusukesushi7@gmail.com", "sushi123");

            client.Port = 587;

            client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail

            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

            try

            {
                client.Send(msg);

                return true;
            }

            catch (Exception ex)

            {
                return false;
            }

        }

    }
}