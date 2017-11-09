<%@ Page Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantendor_Administrador.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantendor_Administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    &nbsp;<!-- INICIO DE BREADCRUMB --><div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Administrador</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Administrador</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->
    <!-- INICIO DE CLIENTES -->
    <div class="m-t" >
        <div class="wrapper wrapper-content  animated fadeInRight">
            <div class="row">
                <div class="col-sm-10">
                    <div class="ibox">
                        <div class="ibox-content">
                            <h2>Administradores</h2>

                            

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
                                            <asp:Button CssClass="btn btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"  />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
                                            &nbsp;
                                            <br />
                                            <br />
                                            <strong>Información:</strong>
                                            <br />
                                            
                                            <ul class="list-group clear-list">                                                
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prNombre"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></span>
                                                    Nombre:
                                                    
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prApellido"><asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></span>
                                                    Apellido:
                                                    
                                            </li>
                                                
                                                
                                                
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prEmail"><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></span>
                                                    Email:
                                                    
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prTelefono"><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></span>
                                                    Teléfono:
                                                    
                                            </li>
                                                <li class="list-group-item">
                                                    <span  id="prGridView">
                                             <!--GV cliente-->
                                                        <div class="row">
                                                            <div class="col-lg-12">
                                                                <div class="ibox">
                                                                    <div class="ibox-content">
                                                                        <asp:GridView ID="gvAdministrador" CssClass="footable table table-stripped toggle-arrow-tiny" runat="server"></asp:GridView> 
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                             <!--FIN GV cliente-->
                                                    </span>
                                                                                                        
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