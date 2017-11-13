<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaAdmin/MenuInterior.Master"  CodeBehind="Ofertas-Productos.aspx.cs" Inherits="SushiApp.PaginaAdmin.Ofertas_Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    &nbsp;
    <!-- INICIO DE CLIENTES -->
    <div class="m-t" >
        <div class="wrapper wrapper-content  animated fadeInRight">
            <div class="row">
                <div class="col-sm-10">
                    <div class="ibox">
                        <div class="ibox-content">
                            <h2>Asociar Ofertas a Productos</h2>
                            <div class="clients-list">                        
                                <div class="tab-content">
                                    <div id="tab-1" class="tab-pane active">
                                        <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <div class="input-group">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                    <asp:TextBox CssClass="input form-control" placeholder="Ingrese Id" ID="txtId" runat="server"></asp:TextBox>
                                                    <span class="input-group-btn">
                                                                        <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                        <asp:Button CssClass="btn btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />
                                                    </span>

                                                </div>
                                                <div class="client-detail">
                                        <div class="full-height-scroll">
                                            <br />
                                            <asp:Button CssClass="btn btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"   />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
                                            &nbsp;
                                            <br />
                                            <br />
                                            <strong></strong>
                                            <br />
                                            
                                            <ul class="list-group clear-list">                                                                                                    
                                                <li class="list-group-item">                           
                                                    <span class="pull-right" id="prProducto">                                                        
                                                     <asp:DropDownList ID="dlProducto" AutoPostBack="false" runat="server">
                                                    </asp:DropDownList>
                                                     </span>    
                                                   Producto
                            
                                               </li>      
                                                <li class="list-group-item">                           
                                                    <span class="pull-right" id="prOferta">                                                        
                                                     <asp:DropDownList ID="dlOferta" AutoPostBack="false" runat="server">
                                                    </asp:DropDownList>%
                                                     </span>    
                                                   Oferta
                            
                                               </li>                                 
                                                <li class="list-group-item">                                                    
                                             <!--GV cliente-->                                                      
                                                <asp:GridView ID="gvOfertaProducto" CssClass="footable table table-stripped toggle-arrow-tiny" runat="server"></asp:GridView>                                                  
                                             <!--FIN GV cliente-->                                                                                                        
                                            </li>
                                            </ul>
                                           
                                        </div>
                                    </div>
                                      
                                                
                                            </div>
                                        </div>
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
