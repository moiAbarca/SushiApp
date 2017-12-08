<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_categoria.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_categoria1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Categorias</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Categorias</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">

            <!-- INICIO FILTROS DE BUSQUEDA -->
           <div class="ibox-content m-b-sm border-bottom">                
                <div class="row">
                    <h2>Categoría-Producto</h2>
                     <div class="clients-list">                        
                                        <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <div class="input-group">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                    <asp:TextBox CssClass="input form-control" placeholder="ID Categoria" ID="txtIdCategoria" runat="server"></asp:TextBox><br /><br />
                                                     <asp:TextBox CssClass="input form-control" placeholder="Nombre de la Categoria" ID="txtNombreCategoria" runat="server"></asp:TextBox>                                                   
                                                </div>
                                      <div class="client-detail">
                                        <div class="full-height-scroll">
                                            <br />
                                            <asp:Button CssClass="btn btn btn-primary" ID="btnBuscarCategoria" runat="server" Text="Buscar" OnClick="btnBuscarCategoria_Click" />
                                            &nbsp;&nbsp;<asp:Button ID="btnAgregarCategoria" CssClass="btn btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregarCategoria_Click" />
                                            &nbsp; <asp:Button ID="btnEliminar" CssClass="btn btn btn-primary" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                            &nbsp;&nbsp;<asp:Button ID="btnEditar" CssClass="btn btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                                            <br />
                                            <br />                                                                                                                                   
                                                  <!--GV cliente-->                                               
                                                  <asp:GridView ID="gv1" runat="server" CssClass="footable table table-stripped toggle-arrow-tiny"></asp:GridView>
                                                  <!--FIN GV cliente-->                                                                                                                                                                                              
                                        </div>                                                   
                                     </div>                                                
                                 </div>
                              </div>                      
                            </div>


                </div>
            </div>
            <!-- FIN DE FILTROS DE BUSQUEDA -->
        </div>
    </div>
</asp:Content>
