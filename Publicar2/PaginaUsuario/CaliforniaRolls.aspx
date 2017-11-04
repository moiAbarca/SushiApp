<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="CaliforniaRolls.aspx.cs" Inherits="SushiApp.PaginaUsuario.CaliforniaRolls1" %>

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

        <div class="col-sm-9">

            <p class="text-muted lead"></p>

            <div class="row products">
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
            <!-- /.products -->

            <div class="row">

                <div class="col-md-12 banner">
                    <a href="#">
                        <img src="img/sushi1.jpg" alt="" class="img-responsive">
                    </a>
                </div>

            </div>


            <div class="pages">

                <p class="loadMore">
                    <a href="#" class="btn btn-template-main"><i class="fa fa-chevron-down"></i>Load more</a>
                </p>

                <ul class="pagination">
                    <li><a href="#">&laquo;</a>
                    </li>
                    <li class="active"><a href="#">1</a>
                    </li>
                    <li><a href="#">2</a>
                    </li>
                    <li><a href="#">3</a>
                    </li>
                    <li><a href="#">4</a>
                    </li>
                    <li><a href="#">5</a>
                    </li>
                    <li><a href="#">&raquo;</a>
                    </li>
                </ul>
            </div>


        </div>
        <!-- /.col-md-9 -->

        <!-- *** RIGHT COLUMN END *** -->
    </div>
</asp:Content>
