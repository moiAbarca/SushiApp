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
    public partial class ReporteVentas : System.Web.UI.Page
    {
        decimal _Total = 0;
        decimal subtotal = 0;
        
        wsPedidoCabecera.ServicePedidoCabeceraClient cabeceraClient = new wsPedidoCabecera.ServicePedidoCabeceraClient();        
        wsPedidoDetalle.ServicePedidoDetalleClient detalleClient = new wsPedidoDetalle.ServicePedidoDetalleClient();
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridReporte();
        }

        private void cargarGridReporte()
        {
            try
            {
                
                var listaCabecera = cabeceraClient.obtenerPedidoCabecera();
                var listaDetalle = detalleClient.obtenerPedidoDetalle();
                var listaProducto = productoClient.obtenerProducto();
                var nuevolistadtoDespacho = (from det in listaDetalle
                                             join pr in listaProducto on det.productoId equals pr.productoId
                                             join cab in listaCabecera on det.pedidoCabeceraId equals cab.pedidoCabeceraId
                                             where cab.estadoPedido == "Pagado" || cab.estadoPedido == "Entregado"
                                             select new
                                             {
                                                 Id = cab.pedidoCabeceraId,
                                                 Producto = pr.nombreProducto,
                                                 Fecha = cab.fechaPedido,
                                                 PrecioProducto = pr.precioProducto,
                                                 Cantidad = det.cantidad,
                                                 TotalProducto = det.total
                                             }).ToList();

                gvReporteVentas.DataSource = nuevolistadtoDespacho;
                gvReporteVentas.DataBind();

            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView');</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            HtmlForm form = new HtmlForm();
            form.Controls.Add(gvReporteVentas);
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
            + "\\Reporte.pdf", FileMode.Create));
            Doc.Open();

            Chunk c = new Chunk
            ("Reporte Ventas \n\n",
            FontFactory.GetFont("Verdana", 15));
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(c);
            Chunk chunk1 = new Chunk
            ("Fecha: " + DateTime.Now + "\n\n",
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
            + "\\Reporte.pdf";


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

        protected void gvReporteVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    _Total += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "TotalProducto"));
                }
                else if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[4].Text = "TOTAL:";
                    e.Row.Cells[5].Text = _Total.ToString();
                    e.Row.Cells[5].HorizontalAlign = HorizontalAlign.Right;
                    e.Row.Font.Bold = true;
                }
            }
            catch (Exception err)
            {
                string error = err.Message.ToString() + " - " + err.Source.ToString();
            }

        }
    }
}