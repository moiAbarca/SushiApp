<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Postres.aspx.cs" Inherits="SushiApp.PaginaUsuario.Postres1" %>

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
                        <li>
                            <a href="SpecialRolls.aspx">Special Rolls <span class="badge pull-right">42</span></a>
                            <a href="NikkeiRolls.aspx">Nikkei Rolls</a>
                            <a href="TempuraPankoRolls.aspx">Tempura & Panko Rolls</a>
                            <a href="CaliforniaRolls.aspx">California Rolls</a>
                            <a href="Postres.aspx">Postres</a>
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

        <div class="container-fluid">
            <p class="text-muted lead"></p>
            <div class="row products">
                <div class="col-md-4 col-sm-6">

                    <asp:DataList ID="dtlProducto" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False">

                        <ItemTemplate>
                            <div class="product">
                                <div class="image">

                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive image1" ImageUrl='<%# Eval("IMAGENPRODUCTO") %>' />

                                </div>

                                <div class="text">
                                <h5>
                                    <asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("NOMBREPRODUCTO") %>'></asp:Label></h5>
                                    </div>
                                </div>
                        </ItemTemplate>

                    </asp:DataList>

                </div>
            </div>
        </div>
    </div>




    <%--  <asp:DataList ID="dtlProductos" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="col-sm-9">
                    <div class="row products">
                        <div class="col-md-9 col-sm-9">
                            <div class="product">
                                <div class="image">
                                    <a href="#" data-toggle="modal" data-target="#modalProducto">
                                        <asp:Image ID="imgProducto" runat="server" CssClass="img-responsive image1"  ImageUrl='<%# Eval("IMAGENPRODUCTO") %>' Height="268px" />
                                    </a>
                                </div>
                                <div class="text">
                                    <h5><asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("NOMBREPRODUCTO") %>'></asp:Label></h5>
                                    <hr />
                                    <h6><asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("PRECIOPRODUCTO") %>'></asp:Label></h6>              
                                    <asp:Button ID="btnAgrega" runat="server" Text="Agregar" CssClass="btn btn-lg btn-success" CommandArgument='<%# Eval("IDPRODUCTO") %>'/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- *** Product MODAL *** -->

                <div class="modal fade" id="modalProducto" tabindex="-1" role="dialog" aria-hidden="true">
                    <div class="modal-dialog modal-sm">
                        <div class="modal-content">
                            <div class="modal-body">
                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                <h4> <asp:Label ID="lblMdlNombreProducto" runat="server" cssClass="modal-title" Text='<%# Eval("NOMBREPRODUCTO") %>'></asp:Label> </h4>
                                <p><asp:Label ID="lblMdlPorcionesProducto" runat="server" Text='<%# Eval("PORCIONESPRODUCTO") %>'></asp:Label> </p>
                                <div class="form-group">
                                    <asp:Image ID="imgMdlProducto" runat="server" CssClass="img-responsive image1" ImageUrl='<%# Eval("IMAGENPRODUCTO") %>' />
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblMdlDescripcion" runat="server" Text='<%# Eval("DESCRIPCIONPRODUCTO") %>'></asp:Label>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblMdlValor" runat="server" Text='<%# Eval("PRECIOPRODUCTO") %>' CssClass="text-primary" Font-Size="Larger"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>--%>
    
</asp:Content>
