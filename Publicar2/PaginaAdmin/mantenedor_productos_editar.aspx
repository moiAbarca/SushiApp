<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_productos_editar.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_productos_editar1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Editar Producto</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li>
                    <a href="mantenedor_productos.aspx">Productos</a>
                </li>
                <li class="active">
                    <strong>Editar</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <form class="m-t" role="form">
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">

            <!-- INICIO EDITAR -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="tabs-container">
                        <ul class="nav nav-tabs">
                            <li class="active"><a data-toggle="tab" href="#tab-1">Detalle Producto</a></li>
                            <li class=""><a data-toggle="tab" href="#tab-2">Imagen</a></li>
                            <li class=""><a data-toggle="tab" href="#tab-3">Descuento</a></li>
                        </ul>
                        <div class="tab-content">

                            <!-- INICIO EDITAR DETALLE PRODUCTO -->
                            <div id="tab-1" class="tab-pane active">
                                <div class="panel-body">

                                    <fieldset class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Producto:</label>
                                            <%--<div class="col-sm-10"><input type="text" class="form-control" placeholder="Nombre del producto"></div>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="producto" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Categoria:</label>
                                            <div class="col-sm-10">
                                                <select class="form-control">
                                                    <option selected>Seleccione</option>
                                                    <option>Hand Roll</option>
                                                    <option>Tempura</option>
                                                    <option>Sashimi</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Descripción:</label>
                                            <%--<div class="col-sm-10"><input type="text" class="form-control" placeholder="Breve descripción del producto"></div>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="descripcion" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Porciones:</label>
                                            <%--<div class="col-sm-10"><input type="text" class="form-control" placeholder="Porciones por producto"></div>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="prociones" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Precio:</label>
                                            <%--<div class="col-sm-10"><input type="text" class="form-control" placeholder="Valor en moneda local"></div>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="precio" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Estado:</label>
                                            <div class="col-sm-10">
                                                <select class="form-control">
                                                    <option selected>Seleccione</option>
                                                    <option>Disponible</option>
                                                    <option>No Disponible</option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <span class="input-group-btn">
                                                    <%--<button type="button" class="btn btn btn-guardar">Guardar</button>--%>
                                                    <asp:Button CssClass="btn btn btn-guardar" ID="Button1" runat="server" Text="Guardar" />
                                                </span>
                                            </div>
                                        </div>

                                    </fieldset>

                                </div>
                            </div>
                            <!-- FIN EDITAR DETALLE PRODUCTO -->

                            <!-- INICIO EDITAR IMAGEN PRODUCTO -->
                            <div id="tab-2" class="tab-pane">
                                <div class="panel-body">

                                    <div class="table-responsive">
                                        <table class="table table-bordered table-stripped">

                                            <thead>
                                                <tr>
                                                    <th>Imagen
                                                    </th>
                                                    <th>Buscar
                                                    </th>
                                                    <th>Acción
                                                    </th>
                                                </tr>
                                            </thead>

                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <input type="text" class="form-control" disabled value="image1.png">
                                                    </td>
                                                    <td>
                                                        <%--<button class="btn btn-white">Importar</button>--%>
                                                        <asp:Button CssClass="btn btn-white" ID="Button2" runat="server" Text="Importar" />
                                                    </td>
                                                    <td>
                                                        <button class="btn btn-white"><i class="fa fa-trash"></i></button>
                                                    </td>
                                                </tr>
                                            </tbody>

                                        </table>
                                    </div>

                                </div>
                            </div>
                            <!-- FIN EDITAR IMAGEN PRODUCTO -->

                            <!-- INICIO EDITAR OFERTA PRODUCTO -->
                            <div id="tab-3" class="tab-pane">
                                <div class="panel-body">

                                    <div class="table-responsive">
                                        <table class="table table-stripped table-bordered">

                                            <thead>

                                                <tr>
                                                    <th>Descuento
                                                    </th>
                                                    <th style="width: 20%">Fecha de inicio
                                                    </th>
                                                    <th style="width: 20%">Fecha de termino
                                                    </th>
                                                    <th>Acción
                                                    </th>
                                                </tr>

                                            </thead>

                                            <tbody>

                                                <tr>
                                                    <td>
                                                        <input type="text" class="form-control" placeholder="% 0">
                                                    </td>
                                                    <td>
                                                        <div class="input-group date">
                                                            <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                            <input type="text" class="form-control" value="07/01/2014">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div class="input-group date">
                                                            <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                            <input type="text" class="form-control" value="07/01/2014">
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <button class="btn btn-white"><i class="fa fa-trash"></i></button>
                                                    </td>
                                                </tr>

                                            </tbody>

                                        </table>
                                    </div>

                                </div>
                            </div>
                            <!-- FIN EDITAR OFERTA PRODUCTO -->

                        </div>
                    </div>
                </div>
            </div>
            <!-- FIN EDITAR -->

        </div>
    </form>
</asp:Content>
