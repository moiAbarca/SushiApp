﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantenedor_ofertas1 : System.Web.UI.Page
    {
        wsOferta.ServiceOfertaClient ofertaClient = new wsOferta.ServiceOfertaClient();
        wsOferta.oferta auxOferta = new wsOferta.oferta();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGVOfertas();
        }

        public void cargarGVOfertas()
        {
            try
            {
                var listadto = ofertaClient.obtenerOferta();
                var nuevolistadto = (from o in listadto
                                     orderby o.ofertaId
                                     select new
                                     {
                                         Id = o.ofertaId,
                                         Nombre = o.nombre,
                                         Porcentaje = o.porcentajeOferta,
                                         Inicio = o.fechaInicio,
                                         Término = o.fechaTermino
                                     }).ToList();

                gvOfertas.DataSource = nuevolistadto;
                gvOfertas.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView Ofertas');</script>");
            }
        }

            protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtOferta.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = ofertaClient.buscarOferta(Convert.ToInt32(this.txtOferta.Text)).ofertaId;
                    if (id2 == 0)
                    {
                        auxOferta.ofertaId = Convert.ToInt32(this.txtId.Text);
                        auxOferta.nombre = this.txtNombre.Text;
                        auxOferta.porcentajeOferta = Convert.ToInt32(this.txtOferta.Text);
                        auxOferta.fechaInicio = calFechaInicio.SelectedDate.ToString("yyyyMMdd");
                        auxOferta.fechaTermino = calFechaTermino.SelectedDate.ToString("yyyyMMdd");

                        ofertaClient.agregarOferta(auxOferta);
                        Response.Write("<script>alert('Agregado correctamente');</script>");
                        limpiar();                        
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }

            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo guardar');</script>");
            }
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtOferta.Text = string.Empty;
            calFechaInicio.SelectedDates.Clear();
            calFechaTermino.SelectedDates.Clear();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0 || txtOferta.Text.Trim().Length == 0 )
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = ofertaClient.buscarOferta(Convert.ToInt32(this.txtId.Text)).ofertaId;
                    if (id2 != 0)
                    {
                        auxOferta.ofertaId = Convert.ToInt32(this.txtId.Text);
                        auxOferta.nombre = this.txtNombre.Text;
                        auxOferta.porcentajeOferta = Convert.ToInt32(this.txtOferta.Text);
                        auxOferta.fechaInicio = calFechaInicio.SelectedDate.ToString("yyyyMMdd");
                        auxOferta.fechaTermino = calFechaTermino.SelectedDate.ToString("yyyyMMdd");

                        ofertaClient.modificarOferta(auxOferta);                        
                        Response.Write("<script>alert('Modificado correctamente');</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }                
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo editar');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ofertaClient.eliminarOferta(Convert.ToInt32(txtId.Text));
                Response.Write("<script>alert('Eliminado Administrador');</script>");                
                limpiar();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo eliminar');</script>");

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxOferta = ofertaClient.buscarOferta(Convert.ToInt32(txtId.Text));
                txtNombre.Text = auxOferta.nombre;
                txtOferta.Text = Convert.ToString(auxOferta.porcentajeOferta);               
                calFechaInicio.SelectedDate = Convert.ToDateTime(auxOferta.fechaInicio);
                calFechaTermino.SelectedDate = Convert.ToDateTime(auxOferta.fechaTermino);                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }
    }
}