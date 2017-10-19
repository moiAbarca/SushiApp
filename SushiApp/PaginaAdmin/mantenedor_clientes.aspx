<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_clientes.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_clientes1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Usuarios</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Usuarios</strong>
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
                <div class="col-sm-8">
                    <div class="ibox">
                        <div class="ibox-content">
                            <h2>Usuarios</h2>

                            <div class="input-group">
                                <%--<button type="button" class="btn btn btn-primary"> <i class="fa fa-search"></i> Buscar</button>--%>
                                <asp:TextBox CssClass="input form-control" ID="TextBox1" runat="server"></asp:TextBox>
                                <span class="input-group-btn">
                                <%--<button type="button" class="btn btn-primary btn-sm btn-block"> Enviar mensaje</button>--%>
                                    <asp:Button CssClass="btn btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                </span>
                            </div>

                            <div class="clients-list">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a data-toggle="tab" href="#tab-1"><i class="fa fa-user"></i>Cliente</a></li>
                                    <li class=""><a data-toggle="tab" href="#tab-2"><i class="fa fa-briefcase"></i>Administrador</a></li>
                                </ul>
                                <div class="tab-content">
                                    <div id="tab-1" class="tab-pane active">
                                        <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <table class="table table-striped table-hover">
                                                    <tbody>
                                                        <tr>
                                                            <td><a data-toggle="tab" href="#usuario" class="client-link">Usuario</a></td>
                                                            <td>Run</td>
                                                            <td>Nombre</td>
                                                            <td>Apellido</td>
                                                            <td class="contact-type"><i class="fa fa-envelope"></i></td>
                                                            <td>Correo electrónico</td>
                                                            <td class="client-status"><span class="label label-primary">Activado</span></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="tab-2" class="tab-pane active">
                                        <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <table class="table table-striped table-hover">
                                                    <tbody>
                                                        <tr>
                                                            <td><a data-toggle="tab" href="#administrador" class="client-link">Administrador</a></td>
                                                            <td>Run</td>
                                                            <td>Nombre</td>
                                                            <td>Apellido</td>
                                                            <td class="contact-type"><i class="fa fa-envelope"></i></td>
                                                            <td>Correo electrónico</td>
                                                            <td class="client-status"><span class="label label-primary">Activado</span></td>
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
                <div class="col-sm-4">
                    <div class="ibox ">

                        <div class="ibox-content">
                            <div class="tab-content">

                                <div id="usuario" class="tab-pane active">
                                    <div class="row m-b-lg">
                                        <div class="col-lg-4 text-center">
                                            <h2>Usuario</h2>
                                        </div>
                                    </div>
                                    <div class="row m-b-lg">
                                        <div class="col-lg-8">
                                            <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                            <asp:Button CssClass="btn btn-primary btn-sm btn-block" ID="Button2" runat="server" Text="Enviar mensaje" />
                                        </div>
                                    </div>
                                    <div class="client-detail">
                                        <div class="full-height-scroll">

                                            <strong>Información:</strong>

                                            <ul class="list-group clear-list">
                                                <li class="list-group-item fist-item">
                                                    <span class="pull-right" id="prRut">insertar dato </span>
                                                    Run:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prNombre">insertar dato </span>
                                                    Nombre:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prApellido">insertar dato </span>
                                                    Apellido:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prDireccion">insertar dato </span>
                                                    Dirección:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prFechaNacimiento">insertar dato </span>
                                                    Fecha de nacimiento:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prSexo">insertar dato </span>
                                                    Sexo:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prEmail">insertar dato </span>
                                                    Email:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prTelefono">insertar dato </span>
                                                    Teléfono:
                                            </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>

                                <div id="administrador" class="tab-pane active">
                                    <div class="row m-b-lg">
                                        <div class="col-lg-4 text-center">
                                            <h2>Administrador</h2>
                                        </div>
                                    </div>
                                    <div class="row m-b-lg">
                                        <div class="col-lg-8">
                                            <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                            <asp:Button CssClass="btn btn-primary btn-sm btn-block" ID="Button3" runat="server" Text="Enviar mensaje" />
                                        </div>
                                    </div>
                                    <div class="client-detail">
                                        <div class="full-height-scroll">

                                            <strong>Información:</strong>

                                            <ul class="list-group clear-list">
                                                <li class="list-group-item fist-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Run:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Nombre:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Apellido:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Dirección:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Fecha de nacimiento:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Sexo:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Email:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right">insertar dato </span>
                                                    Teléfono:
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
    <!-- FIN DE CLIENTES -->
</asp:Content>
