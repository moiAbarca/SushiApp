<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="NikkeiRolls.aspx.cs" Inherits="SushiApp.PaginaUsuario.NikkeiRolls1" %>

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
                            <a href="#" data-toggle="modal" data-target="#modalSamuraiRoll">
                                <img src="img/ImagenesSushi/ID10_Samurai_Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Samurai Roll</h4>
                            <p class="price">$4.200</p>
                            <asp:Button ID="btnSamuraiRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalSamuraiRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Samurai Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID10_Samurai_Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcioMdlSamuraiRoll" runat="server" Text="Pollo furai, palta, cebollín, envuelto en palta, cubierto en salsa huancaína, teriyaki y espolvoreado con crispys de masa tempura"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlSamuraiRoll" runat="server" Text="$4.200" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalEbiNikkei">
                                <img src="img/ImagenesSushi/ID11_Ebi_Nikkei.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Ebi Nikkei</h4>
                            <p class="price">$4.900</p>
                            <asp:Button ID="btnEbiNikkeiAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalEbiNikkei" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Ebi Nikkei</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID11_Ebi_Nikkei.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlEbiNikkei" runat="server" Text="Salmón, queso crema, cebollín, envuelto en palta o crispys cubierto con tartar de camarones furai, salsa acevichada clásica y toques de chichimi"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlEbiNikkei" runat="server" Text="$4.900" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalCevicheRoll">
                                <img src="img/ImagenesSushi/ID12_Ceviche-Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Ceviche Roll</h4>
                            <p class="price">$4.700</p>
                            <asp:Button ID="btnCevicheRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCevicheRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Ceviche Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID12_Ceviche-Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlCevicheRoll" runat="server" Text="Camarón furai, palta y cubierto en ceviche de pescado"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlCevicheRoll" runat="server" Text="$4.700" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalSakeNikkei">
                                <img src="img/ImagenesSushi/ID13_Sake_Nikkei.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Sake Nikkei</h4>
                            <p class="price">$4.800</p>
                            <asp:Button ID="btnSakeNikkeiAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalSakeNikkei" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Sake Nikkei</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID13_Sake_Nikkei.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlSakeNikkei" runat="server" Text="Camarón tempura, queso crema, cebollín envuelto en palta y cubierto con salmón acevichado"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlSakeNikkei" runat="server" Text="$4.800" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalCrunchyEbi">
                                <img src="img/ImagenesSushi/ID14_Crunchy_Ebi.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Crunchy Ebi</h4>
                            <p class="price">$4.800</p>
                            <asp:Button ID="btnCrunchyEbiAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCrunchyEbi" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Crunchy Ebi</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID14_Crunchy_Ebi.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlCrunchyEbi" runat="server" Text="Pollo, queso crema, cebollín, envuelto en palta y cubierto con salsa acevichada, trozos de camarón apanado y toques de ciboulette picado"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblValorMdlCrunchyEbi" runat="server" Text="$4.800" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalCrunchyTori">
                                <img src="img/ImagenesSushi/ID15_Crunchy_Tori.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Crunchy Tori</h4>
                            <p class="price">$4.700</p>
                            <asp:Button ID="btnCrunchyToriAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalCrunchyTori" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Crunchy Tori</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID15_Crunchy_Tori.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlCrunchyTori" runat="server" Text="Camarón, cebollín, palta, envuelto en queso crema y cubierto con salsa teriyaki, cubos de pollo apanado y un toque de sésamo"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlCrunchyTori" runat="server" Text="$4.700" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalAcevichadoFukusuke">
                                <img src="img/ImagenesSushi/ID16_Acevichado-Fukusuke.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Acevichado Fukusuke</h4>
                            <p class="price">$4.600</p>
                            <asp:Button ID="btnAcevichadoFukusukeAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalAcevichadoFukusuke" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Acevichado Fukusuke</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID16_Acevichado-Fukusuke.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlAcevichadoFukusuke" runat="server" Text="Camarón furai, palta,cubierto en atún, dressing acevichado y chichimi"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlAcevichadoFukusuke" runat="server" Text="$4.700" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalInkaRoll">
                                <img src="img/ImagenesSushi/ID17_Inka_Roll.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Inka Roll</h4>
                            <p class="price">$4.000</p>
                            <asp:Button ID="btnInkaRollAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalInkaRoll" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Inka Roll</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID17_Inka_Roll.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlInkaRoll" runat="server" Text="Pollo, palta, envuelto en palta y bañado en salsa huancaína"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlInkaRoll" runat="server" Text="$4.000" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
                            <a href="#" data-toggle="modal" data-target="#modalAcevichadoCamaron">
                                <img src="img/ImagenesSushi/ID18_Acevichado_Camaron.jpg" alt="" class="img-responsive image1">
                            </a>
                        </div>
                        <!-- /.image -->
                        <div class="text">
                            <h4>Acevichado Camaron</h4>
                            <p class="price">$4.300</p>
                            <asp:Button ID="btnAcevichadoCamaronAgrega" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <!-- /.text -->
                        <!-- *** Product MODAL *** -->

                        <div class="modal fade" id="modalAcevichadoCamaron" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">Acevichado Camaron</h4>
                                        <p>8 porciones</p>
                                        <div class="form-group">
                                            <img src="img/ImagenesSushi/ID18_Acevichado_Camaron.jpg" alt="" class="img-responsive image1">
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblDescripcionMdlAcevichadoCamaron" runat="server" Text="Camarón tempura y palta envuelto en palta y salsa acevichada"></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblPrecioMdlAcevichadoCamaron" runat="server" Text="$4.300" CssClass="text-primary" Font-Size="Larger"></asp:Label>
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
