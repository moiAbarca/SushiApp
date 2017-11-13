<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_ofertas.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_ofertas1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Ofertas</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Ofertas</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <!-- INICIO OFERTAS -->
    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">
            <div class="row">
                <div class="col-lg-12">
                    <div class="tabs-container">
                        <ul class="nav nav-tabs">
                            <li class="active"><a data-toggle="tab" href="#tab-1">Oferta</a></li>
                        </ul>
                        <div class="tab-content">
                        </div>
                        <div id="tab-1" class="tab-pane active">
                            <div class="panel-body">

                                <div class="table-responsive">
                                    <table class="table table-stripped table-bordered">

                                        <thead>

                                            <tr>
                                                <th>Id
                                                    </th>
                                                <th>Descuento
                                                    </th>
                                                <th style="width: 15%">Fecha de inicio
                                                    </th>
                                                <th style="width: 15%">Fecha de termino
                                                    </th>
                                                <th>Acción
                                                    </th>
                                            </tr>

                                        </thead>

                                        <tbody>

                                            <tr>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtId" runat="server"></asp:TextBox>
                                                    <!--
                                                    <asp:DropDownList ID="dlCategoria" AutoPostBack="false" runat="server">
                                                    </asp:DropDownList>
                                                   
                                                    <select class="form-control">
                                                        <option selected>Seleccione</option>
                                                        <option>Hand Roll</option>
                                                        <option>Tempura</option>
                                                        <option>Sashimi</option>
                                                    </select>
                                                    -->
                                                </td>
                                                <td>
                                                    <%--<input type="text" class="form-control" placeholder="% 0">--%>
                                                    <asp:TextBox CssClass="form-control" ID="txtOferta" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <div class="input-group date">
                                                        <asp:Calendar ID="calFechaInicio" runat="server"></asp:Calendar> 
                                                    </div>
                                                </td>
                                                <td>
                                                    <div class="input-group date">
                                                        <asp:Calendar ID="calFechaTermino" runat="server"></asp:Calendar> 
                                                    </div>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnBuscar" CssClass="btn btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/><hr />
                                                    <asp:Button ID="btnAgregar"  CssClass="btn btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" /><hr />
                                                    <asp:Button ID="btnEditar" CssClass="btn btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" /><hr />
                                                    <asp:Button ID="btnEliminar" CssClass="btn btn btn-primary"  runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                                    <!--
                                                    <button class="btn btn-white"><i class="fa fa-trash"></i></button>
                                                    <button class="btn btn-white"><i class="fa fa-trash"></i></button>
                                                    <button class="btn btn-white"><i class="fa fa-trash"></i></button>
                                                    -->
                                                </td>
                                            </tr>

                                        </tbody>

                                    </table>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- FIN OFERTAS -->
</asp:Content>
