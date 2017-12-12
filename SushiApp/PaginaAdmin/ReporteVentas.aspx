<%@ Page Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="ReporteVentas.aspx.cs" Inherits="SushiApp.PaginaAdmin.ReporteVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Reporte Ventas</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Reporte</a>
                </li>
                <li class="active">
                    <strong>Reporte Ventas</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->
     <!-- INICIO DE Administrador -->
    <div class="m-t" >
        <div class="wrapper wrapper-content  animated fadeInRight ecommerce">              
            <div class="ibox-content m-b-sm border-bottom">                
                <div class="row">
                            <h2>Reporte Ventas</h2>
                            <div class="clients-list">                        
                              <div class="full-height-scroll">
                                 <div class="table-responsive">
                                                <div class="input-group">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                    <asp:TextBox CssClass="input form-control" placeholder="Ingrese Id" ID="txtId" runat="server"></asp:TextBox>
                                                   <span class="input-group-btn">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                     <asp:Button CssClass="btn btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                                   </span>
                                                </div>
                                      <div class="client-detail">
                                        <div class="full-height-scroll">
                                            <br />
                                            <asp:Button CssClass="btn btn btn-primary" ID="btnExportar" runat="server" Text="Exportar" OnClick="btnExportar_Click"  />
                                            
                                            <br />
                                            <br />
                                            <strong>Información:</strong>
                                            
                                                                                                                               
                                                  <!--GV cliente-->                                               
                                                  <asp:GridView ID="gvReporteVentas" CssClass="footable table table-stripped toggle-arrow-tiny" runat="server" OnRowDataBound="gvReporteVentas_RowDataBound" ShowFooter="True"></asp:GridView>                                                
                                                  <!--FIN GV cliente-->                                                                                                                                                                                              
                                        </div>                                                   
                                     </div>                                                
                                 </div>
                              </div>                      
                            </div>
                        </div>
                    </div>
                </div>                
             </div>
    <!-- FIN DE CLIENTES -->

    </asp:Content>
