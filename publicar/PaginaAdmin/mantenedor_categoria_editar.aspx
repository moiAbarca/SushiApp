<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_categoria_editar.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_categoria_editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Eliminar Categoria</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li>
                    <a href="mantenedor_categoria.aspx">Categoria</a>
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

    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">

            <!-- INICIO EDITAR -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="tabs-container">
                        <ul class="nav nav-tabs">
                            <li class="active"><a data-toggle="tab" href="#tab-1">Detalle Categoria</a></li>
                        </ul>
                        <div class="tab-content">

                            <!-- INICIO EDITAR DETALLE PRODUCTO -->
                            <div id="tab-1" class="tab-pane active">
                                <div class="panel-body">

                                    <fieldset class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">ID Categoria:</label>
                                            <%--<button type="button" class="btn btn btn-guardar">Guardar</button>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="txtId" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Categoria:</label>
                                            <%--<button type="button" class="btn btn btn-guardar">Guardar</button>--%>
                                            <div class="col-sm-10">
                                                <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <span class="input-group-btn">
                                                    <%--<button type="button" class="btn btn btn-guardar">Guardar</button>--%>
                                                    <asp:Button CssClass="btn btn btn-guardar" ID="Button1" runat="server" Text="Eliminar" OnClick="Button1_Click" />
                                                </span>
                                            </div>
                                        </div>

                                    </fieldset>

                                </div>
                            </div>
                            <!-- FIN EDITAR DETALLE PRODUCTO -->
                        </div>
                    </div>
                </div>
            </div>
            <!-- FIN EDITAR -->

        </div>
    </div>
</asp:Content>
