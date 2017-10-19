<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_productos.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_productos1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Productos</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Productos</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <form class="m-t" role="form">
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">

            <!-- INICIO FILTROS DE BUSQUEDA -->
            <div class="ibox-content m-b-sm border-bottom">
                <div class="row">
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="product_name">ID Producto</label>
                            <%--<input type="text" id="product_name" name="idproducto" value="" placeholder="ID Producto" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="idproducto" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <label class="control-label" for="price">Producto</label>
                            <%--<input type="text" id="price" name="producto" value="" placeholder="Nombre del producto" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="producto" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <label class="control-label" for="quantity">Categoria</label>
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="categoria" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="status">Estado</label>
                            <select name="status" id="status" class="form-control">
                                <option value="1" selected>Disponible</option>
                                <option value="0">No Disponible</option>
                            </select>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="quantity">Acción</label>
                            <span class="input-group-btn">
                                <%--<button type="button" class="btn btn btn-primary"> Buscar</button>--%>
                                <asp:Button CssClass="btn btn btn-primary" ID="Button1" runat="server" Text="Buscar" />
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

                            <table class="footable table table-stripped toggle-arrow-tiny" data-page-size="15">

                                <thead>
                                    <tr>
                                        <th data-toggle="true">ID</th>
                                        <th data-toggle="phone,tablet">Categoria</th>
                                        <th data-toggle="true">Producto</th>
                                        <th data-toggle="phone,tablet">Porciones</th>
                                        <th data-toggle="phone,tablet">Precio</th>
                                        <th data-hide="all">Descripción</th>
                                        <th data-toggle="phone,tablet">Estado</th>
                                        <th class="text-right" data-sort-ignore="true"></th>
                                        <th class="text-right" data-sort-ignore="true"></th>
                                    </tr>
                                </thead>

                                <tbody>
                                    <tr>
                                        <td>001
                                        </td>
                                        <td>Hand Roll
                                        </td>
                                        <td>Samurai
                                        </td>
                                        <td>8
                                        </td>
                                        <td>$8.900
                                        </td>
                                        <td>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                        tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                        quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                        </td>
                                        <td>
                                            <span class="label label-primary">Disponible</span>
                                        </td>
                                        <td class="text-right">
                                            <div class="btn-group">
                                                <%--<button class="btn-white btn btn-xs"><a href="mantenedor_productos_ver.html">Ver</a></button>--%>
                                                <asp:Button CssClass="btn-white btn btn-xs" ID="Button2" runat="server" Text="Ver" />
                                            </div>
                                        </td>
                                        <td class="text-right">
                                            <div class="btn-group">
                                                <%--<button class="btn-white btn btn-xs"><a href="mantenedor_productos_editar.html">Editar</a></button>--%>
                                                <asp:Button CssClass="btn-white btn btn-xs" ID="Button5" runat="server" Text="Editar" />
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>

                            </table>

                        </div>
                    </div>
                </div>
            </div>
            <!-- FIN LISTA DE PRODUCTOS -->

        </div>
    </form>
</asp:Content>
