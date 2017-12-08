using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using SushiApp.Models;

namespace SushiApp.PaginaUsuario
{
    public partial class Checkout11 : System.Web.UI.Page
    {        
        wsUsuario.ServiceUsuarioClient usuarioClient = new wsUsuario.ServiceUsuarioClient();
        wsUsuario.usuario auxUsuario = new wsUsuario.usuario();

        wsCliente.ServiceClienteClient clienteCliente = new wsCliente.ServiceClienteClient();
        wsCliente.cliente auxCliente = new wsCliente.cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {

                    auxCliente.rut = "";
                    auxCliente.direccion = "";
                    auxCliente.apellido = txtApellido.Text;
                    auxCliente.comuna = String.Empty;
                    auxCliente.telefono = 1;
                    auxCliente.email = txtEmail.Text;
                    auxCliente.usuarioId = 1;
                    auxCliente.nombre = txtNombre.Text;
                    auxCliente.fechaNacimiento = "19900101";
                    auxCliente.sexo = "";

                    clienteCliente.agregarCliente(auxCliente);
                    limpiar();
                    Response.Redirect("Checkout2.aspx");
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo registrar');</script>");
            }
            
        }

        private void limpiar()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //prueba 5
            //var listadto = usuarioClient.obtenerUsuario();
            //var nuevolistadto = (from o in listadto
            //                     where o.usuario1 == txtEmailLogin.Text && o.pass == txtPasswordLogin.Text
            //                     select new
            //                     {
            //                         Id = o.usuarioId,
            //                         Usuario = o.usuario1,
            //                         password = o.pass
            //                     }).ToList();

            //PropertyDescriptorCollection properties =
            //   TypeDescriptor.GetProperties(typeof(T));
            //DataTable table = new DataTable();
            //foreach (PropertyDescriptor prop in properties)
            //    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            //foreach (T item in nuevolistadto)
            //{
            //    DataRow row = table.NewRow();
            //    foreach (PropertyDescriptor prop in properties)
            //        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            //    table.Rows.Add(row);
            //}
            //return nuevolistadto;

            //prueba 4
            //DataTable dataTable = new DataTable();
            //bool columnsAdded = false;
            //foreach (string row in nuevolistadto.Split('$'))
            //{
            //    DataRow dataRow = dataTable.NewRow();
            //    foreach (string cell in row.Split('|'))
            //    {
            //        string[] keyValue = cell.Split('~');
            //        if (!columnsAdded)
            //        {
            //            DataColumn dataColumn = new DataColumn(keyValue[0]);
            //            dataTable.Columns.Add(dataColumn);
            //        }
            //        dataRow[keyValue[0]] = keyValue[0];
            //    }
            //    columnsAdded = true;
            //    dataTable.Rows.Add(dataRow);
            //}

            //if (dataTable.Rows.Count == 0)
            //{
            //    Response.Write("<script>alert('No existe usuario');</script>");
            //}
            //else
            //{
            //    Response.Redirect("Checkout2.aspx");
            //}

            //prueba 3
            //var listadto = usuarioClient.obtenerUsuario();
            //var nuevolistadto = (from o in listadto
            //                     where o.usuario1 == txtEmailLogin.Text && o.pass == txtPasswordLogin.Text
            //                     select new
            //                     {
            //                         Id = o.usuarioId,
            //                         Nombre = o.usuario1,
            //                         Apellido = o.pass
            //                     }).ToList();
            //XmlNode nodeListItems = nuevolistadto.GetListItems(_ListName, null, null, null, null, null, null);

            //xmlDoc.LoadXml(nodeListItems.OuterXml);

            //XmlNodeReader xmlReader = new XmlNodeReader(xmlDoc);

            //ds.ReadXml(xmlReader);

            ////prueba 2
            //// Fill the DataSet.
            //DataSet ds = new DataSet();
            //ds.Locale = CultureInfo.InvariantCulture;
            //FillDataSet(ds);

            //DataTable orders = ds.Tables["Usuario"];

            //// Query the SalesOrderHeader table for orders placed 
            //// after August 8, 2001.
            //var listadto = usuarioClient.obtenerUsuario();
            //var nuevolistadto = (from o in listadto
            //                     where o.usuario1 == txtEmailLogin.Text && o.pass == txtPasswordLogin.Text
            //                     select new
            //                     {
            //                         Id = o.usuarioId,
            //                         Nombre = o.usuario1,
            //                         Apellido = o.pass
            //                     });

            //// Create a table from the query.
            //DataTable boundTable = nuevolistadto.CopyToDataTable<DataRow>();

            //// Bind the table to a System.Windows.Forms.BindingSource object, 
            //// which acts as a proxy for a System.Windows.Forms.DataGridView object.
            //bindingSource.DataSource = boundTable;


            //prueba1
            //try
            //{                
            //    var listadto = usuarioClient.obtenerUsuario();
            //    var nuevolistadto = (from o in listadto
            //                         where o.usuario1 == txtEmailLogin.Text && o.pass == txtPasswordLogin.Text
            //                         select new
            //                         {
            //                             Id = o.usuarioId,
            //                             Nombre = o.usuario1,
            //                             Apellido = o.pass
            //                         });

            //    DataTable _myDataTable = new DataTable();

            //    // create columns
            //    for (int i = 0; i < nuevolistadto.Count(); i++)
            //    {
            //        _myDataTable.Columns.Add();
            //    }

            //    for (int j = 0; j < nuevolistadto.Count(); j++)
            //    {
            //        // create a DataRow using .NewRow()
            //        DataRow row = _myDataTable.NewRow();

            //        // iterate over all columns to fill the row
            //        for (int i = 0; i < nuevolistadto.Count(); i++)
            //        {
            //            row[i] = nuevolistadto;
            //        }

            //        // add the current row to the DataTable
            //        _myDataTable.Rows.Add(row);
            //    }

            //    if (_myDataTable.Rows.Count == 0)
            //    {
            //        Response.Write("<script>alert('No existe usuario');</script>");
            //    }
            //    else
            //    {
            //        Response.Redirect("Checkout2.aspx");
            //    }
            //}
            //catch (Exception)
            //{

            //    Response.Write("<script>alert('No se pudo realizar la acción solicitada');</script>");
            //}

        }
    }
}