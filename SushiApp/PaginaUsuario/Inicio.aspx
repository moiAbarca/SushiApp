<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SushiApp.PaginaUsuario.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" id="home">

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
                            <a href="SpecialRolls.aspx">Special Rolls</a>
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

            <%-- <div class="banner">
                <a href="shop-category.html">
                    <img src="img/banner.jpg" alt="sales 2014" class="img-responsive">
                </a>
            </div>
            <!-- /.banner -->--%>
        </div>
        <!-- /.col-md-3 -->

        <!-- *** LEFT COLUMN END *** -->



        <!-- *** RIGHT COLUMN ***
			_________________________________________________________ -->

        <div class="col-sm-9">



            <div class="row">

                <div class="col-md-12 banner">
                    <div class="image">
                        <img src="img/ImagenesSushi/bannerSushi.jpg" alt="" class="img-responsive">
                    </div>
                </div>

            </div>

            <div class="row">
                <div class="image">
                    
                        <div class="col-md-4">
                            <a href="SpecialRolls.aspx">
                                <img src="img/ImagenesSushi/ID2_Teriyaki_Roll.jpg" alt="" class="img-responsive" />
                            </a>
                            <h3 class="box-header text-center">Special Rolls</h3>
                            <p class="text-center">
                                Rolls de sabores únicos
                            </p>
                        </div>
                   

                  
                        <div class="col-md-4">
                            <a href="NikkeiRolls.aspx">
                                <img src="img/ImagenesSushi/ID11_Ebi_Nikkei.jpg" alt="" class="img-responsive" />
                            </a>
                            <h3 class="box-header text-center">Nikkei Rolls</h3>
                            <p class="text-center">
                                Fusión japonesa - peruana
                            </p>
                        </div>
                

                    
                        <div class="col-md-4">
                            <a href="TempuraPankoRolls.aspx">
                                <img src="img/ImagenesSushi/ID26_Teriyaki_Tempura.jpg" alt="" class="img-responsive" />
                            </a>
                            <h3 class="box-header text-center">Tempura Rolls</h3>
                            <p class="text-center">
                                Envueltos en masa Témpura o Panko
                            </p>
                        </div>
                   

                </div>
            </div>




        </div>
        <!-- /.col-md-9 -->

        <!-- *** RIGHT COLUMN END *** -->

    </div>
</asp:Content>
