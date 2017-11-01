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
                            <a href="#" data-toggle="modal" data-target="#modalThaiRoll">
                                <img src="img/ImagenesSushi/ID1_Thai_Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Thai Roll</h4>
                            <p class="price">$4.600</p>
                            <asp:Button ID="btnThaiRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalThaiRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Thai Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID1_Thai_Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcioMdlThaiRoll" runat="server" Text="Pollo furai, queso crema, cilantro, envuelto en palta, espolvoreado con maní, salsa de curry y toques de limón sutíl"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlThaiRoll" runat="server" Text="$4.600" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalTeriyakiRoll">
                                <img src="img/ImagenesSushi/ID2_Teriyaki_Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Teriyaki Roll</h4>
                            <p class="price">$4.500</p>
                            <asp:Button ID="btnTeriyakiRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalTeriyakiRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Teriyaki Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID2_Teriyaki_Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlTeriyakiRoll" runat="server" Text="Camarón, queso crema, cebollín envuelto en palta, cubierto con cubos de pollo teriyaki y sésamo"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlTeriyakiRoll" runat="server" Text="$4.500" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalDragonRoll">
                                <img src="img/ImagenesSushi/ID3_Dragon_Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Dragon Roll</h4>
                            <p class="price">$4.600</p>
                            <asp:Button ID="btnDragonRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalDragonRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Dragon Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID3_Dragon_Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlDragonRoll" runat="server" Text="Camarón tempura, queso crema, cebollín cubierto en mixto de palta y atún, sésamo, masago y salsa acevichada"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlDragonRoll" runat="server" Text="$4.600" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
            <!-- /.products row 1-->

            <div class="row products">
                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="image">
                            <a href="#" data-toggle="modal" data-target="#modalSpicyTempura">
                                <img src="img/ImagenesSushi/ID4_Spicy_Tempura.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Spicy Tempura</h4>
                            <p class="price">$4.100</p>
                            <asp:Button ID="btnSpicyTempuraAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalSpicyTempura" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Spicy Tempura</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID4_Spicy_Tempura.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlSpicyTempura" runat="server" Text="Camarón tempura, salsa spicy, queso crema, cebollín envuelto en palta, salmón, mixto o crispys"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlSpicyTempura" runat="server" Text="$4.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalAvocadoTempura">
                                <img src="img/ImagenesSushi/ID5_Avocado_Tempura.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Avocado Tempura</h4>
                            <p class="price">$4.100</p>
                            <asp:Button ID="btnAvocadoTempuraAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalAvocadoTempura" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Avocado Tempura</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID5_Avocado_Tempura.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlAvocadoTempura" runat="server" Text="Camarón tempura, queso crema, palta, envuelto en palta, salmón, mixto o crispys"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlAvocadoTempura" runat="server" Text="$4.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalRainbowSpecial">
                                <img src="img/ImagenesSushi/ID6_Rainbow_Especial.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Rainbow Special</h4>
                            <p class="price">$4.200</p>
                            <asp:Button ID="btnRainbowSpecialAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalRainbowSpecial" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Rainbow Special</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID6_Rainbow_Especial.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlRainbowSpecial" runat="server" Text="Salmón, queso crema, palta cubierto en mixto de atún y palta"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlRainbowSpecial" runat="server" Text="$4.200" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
            <!-- /.products row 2-->

            <div class="row products">
                <div class="col-md-4 col-sm-6">
                    <div class="product">
                        <div class="image">
                            <a href="#" data-toggle="modal" data-target="#modalTokioWhite">
                                <img src="img/ImagenesSushi/ID7_Tokio_White.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Tokio White</h4>
                            <p class="price">$4.100</p>
                            <asp:Button ID="btnTokioWhiteAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalTokioWhite" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Tokio White</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID7_Tokio_White.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlTokioWhite" runat="server" Text="Salmón ahumado, palta, envuelto en queso crema y ciboulette"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlTokioWhite" runat="server" Text="$4.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalFuraiWhite">
                                <img src="img/ImagenesSushi/ID8_Furai_White.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Furai White</h4>
                            <p class="price">$4.100</p>
                            <asp:Button ID="btnFuraiWhiteAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalFuraiWhite" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Furai White</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID8_Furai_White.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripciónMdlFuraiWhite" runat="server" Text="Camarón furai, palta y cebollín envuelto en queso crema y salsa unagui"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlFuraiWhite" runat="server" Text="$4.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalToriCrispy">
                                <img src="img/ImagenesSushi/ID9_Tori_Crispy.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Tori Crispy</h4>
                            <p class="price">$4.100</p>
                            <asp:Button ID="btnToriCrispyAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalToriCrispy" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Tori Crispy</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID9_Tori_Crispy.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlToriCrispy" runat="server" Text="Pollo furai, queso crema, cebollín, envuelto en palta y cubierto de papas hilo"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlToriCrispy" runat="server" Text="$4.100" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
            <!-- /.products row 2-->

            <div class="row">

                <div class="col-md-12 banner">
                    <a href="#">
                        <img src="img/Banner50desctoUsuario.gif" alt="" class="img-responsive">
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
