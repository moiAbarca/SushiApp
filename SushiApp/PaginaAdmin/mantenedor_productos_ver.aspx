<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_productos_ver.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_productos_ver1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Detalle de Producto</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.html">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li>
                    <a href="mantenedor_productos.aspx">Productos</a>
                </li>
                <li class="active">
                    <strong>Ver</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <!-- INICIO DETALLE PRODUCTO -->
    <form class="m-t" role="form">
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="row">
                <div class="col-lg-12">

                    <div class="ibox product-detail">
                        <div class="ibox-content">

                            <div class="row">
                                <div class="col-md-5">

                                    <div class="product-images">
                                        <div>
                                            <div class="image-imitation">
                                                [IMAGEN]
                                           
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="col-md-7">

                                    <h2 class="font-bold m-b-xs">Nombre de producto
                                    </h2>
                                    <small>Nombre Categoria</small>
                                    <div class="m-t-md">
                                        <h2 class="product-main-price">$9.999</h2>
                                    </div>
                                    <hr>

                                    <h4>Descripción</h4>
                                    <div class="small text-muted">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                                        tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                        quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
                                        consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
                                        cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
                                        proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                   
                                    </div>
                                    <dl class="small m-t-md">
                                        <dt>Cantidad:</dt>
                                        <dd>8 porciones</dd>
                                        <br>
                                        <dt>Estado:</dt>
                                        <dd>Disponible</dd>
                                    </dl>
                                    <hr>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- FIN DETALLE PRODUCTO -->
</asp:Content>
