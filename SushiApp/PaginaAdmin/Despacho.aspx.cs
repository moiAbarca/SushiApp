using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.IO;
using System.Collections;
using System.Net;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using iTextSharp.text.html.simpleparser;

namespace SushiApp.PaginaAdmin
{
    public partial class Despacho : System.Web.UI.Page
    {
        wsCliente.ServiceClienteClient clienteClient = new wsCliente.ServiceClienteClient();
        wsPedidoCabecera.ServicePedidoCabeceraClient cabeceraClient = new wsPedidoCabecera.ServicePedidoCabeceraClient();
        wsPedidoCabecera.pedidoCabecera auxCabecera = new wsPedidoCabecera.pedidoCabecera();
        wsPedidoDetalle.ServicePedidoDetalleClient detalleClient = new wsPedidoDetalle.ServicePedidoDetalleClient();
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridDepacho();
        }

        private void cargarGridDepacho()
        {
            try
            {
                var listaCliente = clienteClient.obtenerCliente();
                var listaCabecera = cabeceraClient.obtenerPedidoCabecera();
                var listaDetalle = detalleClient.obtenerPedidoDetalle();
                var listaProducto = productoClient.obtenerProducto();
                var nuevolistadtoDespacho = (from det in listaDetalle
                                             join pr in listaProducto on det.productoId equals pr.productoId
                                             join cab in listaCabecera on det.pedidoCabeceraId equals cab.pedidoCabeceraId
                                             join cl in listaCliente on cab.clienteId equals cl.clienteId
                                             where cab.estadoPedido == "Pagado"
                                             select new
                                             {
                                                 Id = cab.pedidoCabeceraId,
                                                 Producto = pr.nombreProducto,
                                                 Cantidad = det.cantidad,
                                                 Fecha = cab.fechaPedido,
                                                 Nombre = cl.nombre,
                                                 Apellido = cl.apellido,
                                                 Dirección = cl.direccion,
                                                 Comuna = cl.comuna,
                                                 Teléfono = cl.telefono,
                                                 Total = det.total
                                             }).ToList();

                gvDespacho.DataSource = nuevolistadtoDespacho;
                gvDespacho.DataBind();

            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView');</script>");
            }
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            HtmlForm form = new HtmlForm();
            form.Controls.Add(gvDespacho);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hTextWriter = new HtmlTextWriter(sw);
            form.Controls[0].RenderControl(hTextWriter);
            string html = sw.ToString();
            Document Doc = new Document();

            //PdfWriter.GetInstance
            //(Doc, new FileStream(Request.PhysicalApplicationPath 
            //+ "\\AmitJain.pdf", FileMode.Create));

            PdfWriter.GetInstance
            (Doc, new FileStream(Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop)
            + "\\Despacho.pdf", FileMode.Create));
            Doc.Open();

            Chunk c = new Chunk
            ("Orden de despacho \n\n",
            FontFactory.GetFont("Verdana", 15));
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(c);
            Chunk chunk1 = new Chunk
            ("Fecha: "+ DateTime.Now + "\n\n",
            FontFactory.GetFont("Verdana", 8));
            Paragraph p1 = new Paragraph();
            p1.Alignment = Element.ALIGN_RIGHT;
            p1.Add(chunk1);

            Doc.Add(p);
            Doc.Add(p1);

            HTMLWorker worker = new HTMLWorker(Doc);
            worker.Parse(new StringReader(html));
            Doc.Close();
            string Path = Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop)
            + "\\Despacho.pdf";


            ShowPdf(Path);


        }

        private void ShowPdf(string strS)
        {
            Response.ClearContent();
            Response.ClearHeaders();
            Response.ContentType = "application/pdf";
            Response.AddHeader
            ("Content-Disposition", "attachment; filename=" + strS);
            Response.TransmitFile(strS);
            Response.End();
            //Response.WriteFile(strS);
            Response.Flush();
            Response.Clear();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxCabecera = cabeceraClient.buscarPedidoCabecera(Convert.ToInt32(txtId.Text));
                var listaCliente = clienteClient.obtenerCliente();
                var listaCabecera = cabeceraClient.obtenerPedidoCabecera();
                var listaDetalle = detalleClient.obtenerPedidoDetalle();
                var listaProducto = productoClient.obtenerProducto();
                var nuevolistadtoDespacho = (from det in listaDetalle
                                             join pr in listaProducto on det.productoId equals pr.productoId
                                             join cab in listaCabecera on det.pedidoCabeceraId equals cab.pedidoCabeceraId
                                             join cl in listaCliente on cab.clienteId equals cl.clienteId
                                             where auxCabecera.clienteId == cab.pedidoCabeceraId
                                             select new
                                             {
                                                 Id = cab.pedidoCabeceraId,
                                                 Producto = pr.nombreProducto,
                                                 Cantidad = det.cantidad,
                                                 Nombre = cl.nombre,
                                                 Apellido = cl.apellido,
                                                 Dirección = cl.direccion,
                                                 Comuna = cl.comuna,
                                                 Teléfono = cl.telefono,
                                                 Total = det.total
                                             }).ToList();

                gvDespacho.DataSource = nuevolistadtoDespacho;
                gvDespacho.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }
    }
}