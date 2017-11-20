<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="SpecialRolls.aspx.cs" Inherits="SushiApp.PaginaUsuario.SpecialRolls1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!-- *** LEFT COLUMN ***
			_________________________________________________________ -->

        <div class="col-sm-3">

            <!-- *** MENUS AND FILTERS ***
 _________________________________________________________ -->
            <div class="panel panel-default sidebar-menu">

                <div class="panel-heading">
                    <h3 class="panel-title">Categorías</h3>
                </div>

                <div class="panel-body">
                    <ul class="nav nav-pills nav-stacked category-menu">
                        <li class="active">
                            <a href="SpecialRolls.aspx">Special Rolls <span class="badge pull-right">9</span></a>
                            </li>
                        <li>
                            <a href="NikkeiRolls.aspx">Nikkei Rolls</a>
                            </li>
                        <li>
                            <a href="TempuraPankoRolls.aspx">Tempura & Panko Rolls</a>
                            </li>
                        <li>
                            <a href="CaliforniaRolls.aspx">California Rolls</a>
                            </li>
                        <li>
                            <a href="HosomakiNigiri.aspx">Hosomaki & Nigiri</a>
                            </li>
                        <li>
                            <a href="Postres.aspx">Postres</a>
                            </li>
                        <li>
                            <a href="Bebidas.aspx">Bebidas</a>
                        </li>

                    </ul>

                </div>
            </div>

            <!-- *** MENUS AND FILTERS END *** -->

            <div class="banner">
                <a href="shop-category.html">
                    <img src="img/banner.jpg" alt="sales 2014" class="img-responsive">
                </a>
            </div>
            <!-- /.banner -->

        </div>
        <!-- /.col-md-3 -->

        <!-- *** LEFT COLUMN END *** -->

        <!-- *** RIGHT COLUMN ***
			_________________________________________________________ -->

        <p class="text-muted lead"></p>
            <div class="row products">
                <div class=".col-md-8">

                    <asp:DataList ID="dtlProductos" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False" OnItemCommand="dtlProductos_ItemCommand1">

                        <ItemTemplate>
                            <div class="product">
                                <div class="image">
                                    <asp:Image ID="imgImagenProducto" runat="server" CssClass="img-responsive image1" ImageUrl='<%# Eval("IMAGENPRODUCTO") %>' />
                                </div>
                            </div>
                            <div class="text">
                                <h5>
                                    <asp:Label ID="lblNombreProducto" runat="server" CssClass="btn-template-primary" Text='<%# Eval("NOMBREPRODUCTO") %>'></asp:Label></h5>
                                <asp:Label ID="lblPrecioProducto" runat="server" Text='<%# Eval("PRECIOPRODUCTO") %>'></asp:Label>
                            </div>

                            <div class="buttons">
                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar al carro" CommandName="Agregar" CommandArgument='<%# Eval("IDPRODUCTO")%>' />
                            </div>
                        </ItemTemplate>

                    </asp:DataList>

                </div>
            </div>
        <!-- /.col-md-9 -->

        <!-- *** RIGHT COLUMN END *** -->
    </div>
</asp:Content>
