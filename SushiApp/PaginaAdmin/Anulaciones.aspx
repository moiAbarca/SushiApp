
<%@ Page Language="C#"  MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="Anulaciones.aspx.cs" Inherits="SushiApp.PaginaAdmin.Anulaciones" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Anulaciones de Compra</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Anulaciones</a>
                </li>
                <li class="active">
                    <strong>Anulaciones</strong>
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
                            <h2>Cambiar estado a Pedidos</h2>
                            <div class="clients-list">                        
                                        <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <div class="input-group">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                    <asp:TextBox CssClass="input form-control" placeholder="Ingrese nº de Pedido" ID="txtId" runat="server"></asp:TextBox>
                                                   <span class="input-group-btn">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                     <asp:Button CssClass="btn btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />
                                                   </span>
                                                </div>
                                      <div class="client-detail">
                                        <div class="full-height-scroll">
                                            <br />
                                            <asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Cambiar Estado Pedido" OnClick="btnEditar_Click" />
                                            <br />
                                            <br />
                                            <strong>Información:</strong>
                                            
                                            <ul class="list-group clear-list">                                                
                                                <li class="list-group-item fist-item">
                                                    <span class="pull-right" id="prEstablecimiento"><asp:TextBox readonly="true"  ID="txtEstablecimiento" runat="server"></asp:TextBox></span>
                                                    Establecimiento:
                                                </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prCliente"><asp:TextBox ID="txtCliente" readonly="true"  runat="server"></asp:TextBox></span>
                                                    Cliente:
                                                    
                                                </li>                                                
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prFecha"><asp:TextBox ID="txtFecha" Text='<%# Convert.ToDateTime(Eval("Birthdate")).ToString("MM/dd/yyyy") %>' readonly="true"  runat="server"></asp:TextBox></span>
                                                    Fecha de Pedido:
                                                    
                                                </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prHora"><asp:TextBox ID="txtHora" readonly="true"  runat="server"></asp:TextBox></span>
                                                    Hora:                                                    
                                                </li>  
                                                <hr />
                                                <li>
                                                    <span class="pull-right">                                                    
                                                    <asp:DropDownList ID="ddlSexo" CssClass="form-control" runat="server">
                                                        <asp:ListItem>Seleccione...</asp:ListItem>
                                                        <asp:ListItem>Anulado</asp:ListItem>
                                                        <asp:ListItem>Pagado</asp:ListItem>
                                                        <asp:ListItem>Entregado</asp:ListItem>
                                                        <asp:ListItem>Por Confirmar</asp:ListItem>
                                                    </asp:DropDownList>
                                                    </span>
                                                    Estado:                                                    
                                                </li>
                                
                                           </ul>   
                                            <br /><br />
                                                  <!--GV cliente-->                                               
                                                  <asp:GridView ID="gvAnulaciones" CssClass="footable table table-stripped toggle-arrow-tiny" runat="server"></asp:GridView>                                                
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
