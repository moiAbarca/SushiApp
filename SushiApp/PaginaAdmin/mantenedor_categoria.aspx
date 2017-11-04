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
                    <div class="col-sm-4">
                        <div class="form-group">
                            <label class="control-label" for="product_name">ID Categoria</label><br />
                            <%--<input type="text" id="product_name" name="idproducto" value="" placeholder="ID Producto" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtIdCategoria" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <label class="control-label" for="quantity">Categoria</label><br />
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtNombreCategoria" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="form-group">
                            <label class="control-label" for="quantity">Acción</label>
                            <span class="input-group-btn">
                                <%--<button type="button" class="btn btn btn-primary"> Buscar</button>--%>
                                <asp:Button CssClass="btn btn btn-primary" ID="btnBuscarCategoria" runat="server" Text="Buscar" OnClick="btnBuscarCategoria_Click" />
                                &nbsp;&nbsp;<asp:Button ID="btnAgregarCategoria" CssClass="btn btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregarCategoria_Click" />
                                &nbsp; <asp:Button ID="btnEliminar" CssClass="btn btn btn-primary" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                &nbsp;&nbsp;<asp:Button ID="btnEditar" CssClass="btn btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <!-- FIN DE FILTROS DE BUSQUEDA -->

            <!-- LISTA DE PRODUCTOS -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="ibox">
                        <div class="ibox-content">
                            <div>

                                <asp:GridView ID="gv1" runat="server" CssClass="footable table table-stripped toggle-arrow-tiny">
                                </asp:GridView>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- FIN LISTA DE PRODUCTOS -->

        </div>
    </div>
</asp:Content>
