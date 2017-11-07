<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Bebidas.aspx.cs" Inherits="SushiApp.PaginaUsuario.Bebidas1" EnableEventValidation="false" validateRequest="false" %>

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

        <%--<asp:Repeater ID="bebidasRepeater" runat="server">--%>
        <asp:DataList ID="dtlProductos" runat="server" RepeatColumns="3" OnItemCommand="dtlProductos_ItemCommand">
            <ItemTemplate>
                <div class="col-sm-9">
                    <div class="row products">
                        <div class="col-md-4 col-sm-6">
                            <div class="product">
                                <div class="image">
                                    <a href="#" data-toggle="modal" data-target="#modalProducto">
                                        <asp:Image ID="imgProducto" runat="server" CssClass="img-responsive image1" ImageUrl='<%# Eval("IMAGENPRODUCTO") %>' />
                                    </a>
                                </div>
                                <div class="text">
                                    <h5><asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("NOMBREPRODUCTO") %>'></asp:Label></h5>
                                    <%--<hr />--%>
                                    <h6><asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("PRECIOPRODUCTO") %>'></asp:Label></h6>              
                                    <asp:Button ID="btnAgrega" runat="server" Text="Agregar" CssClass="btn btn-lg btn-success" CommandArgument='<%# Eval("IDPRODUCTO") %>' CommandName="Agregar"/>
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
        </asp:DataList>
        <%--</asp:Repeater>--%>




        <%--<div class="col-sm-9">
            <div class="row products">
                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="text">
                            <h4>Thai Roll</h4>
                            <p class="price">$4.600</p>
                            <asp:Button ID="btnThaiRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
    </div>
</asp:Content>


<%--<div class="row products">
                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="image">
                            <a href="#" data-toggle="modal" data-target="#modalCV">
                                <img src="img/fotoSushi1.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>California Veggie</h4>
                            <p class="price">$3.800</p>
                            <asp:Button ID="btnCaliforniaVeggieAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" OnClick="btnCaliforniaVeggieAgrega_Click" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCV" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">California Veggie</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/fotoSushi1.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripciomdlCV" runat="server" Text="Champignon furai, palta, papa camote, envuelto en sesamo, masago o ciboulette"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValormdlCV" runat="server" Text="$3.800" CssClass="text-primary" Font-Size="Larger"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- *** Product MODAL END *** -->
                    </div>
                    <!-- /.product -->
                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="image">
                            <a href="#" data-toggle="modal" data-target="#modalCC">
                                <img src="img/fotoSushi2.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>California Cheese</h4>
                            <p class="price">$3.400</p>
                            <asp:Button ID="btnCaliforniaCheeseAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" OnClick="btnCaliforniaCheeseAgrega_Click" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCC" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">California Cheese</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/fotoSushi2.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripciomdlCC" runat="server" Text="Salmón, queso, crema, cebollín, envuelto en sésamo, masago o ciboulette"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValormdlCC" runat="server" Text="$3.400" CssClass="text-primary" Font-Size="Larger"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- *** Product MODAL END *** -->
                    </div>
                    <!-- /.product -->
                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="image">
                            <a href="#" data-toggle="modal" data-target="#modalCCapresse">
                                <img src="img/fotoSushi3.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>California Capresse</h4>
                            <p class="price">$3.100</p>
                            <asp:Button ID="btnCaliforniaCapresseAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" OnClick="btnCaliforniaCapresseAgrega_Click" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCCapresse" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">California Capresse</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/fotoSushi3.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripciomdlCCapresse" runat="server" Text="Albahaca, tomate, queso crema envuelto en sésamo o ciboulette"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValormdlCCapresse" runat="server" Text="$3.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- *** Product MODAL END *** -->
                    </div>
                    <!-- /.product -->
                </div>
                <!-- /.col-md-4 -->
            </div>
            <!-- /.products -->--%>