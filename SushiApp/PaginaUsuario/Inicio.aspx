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
                        <li class="active">
                            <a href="NikkeiRolls.aspx">Nikkei Rolls</span></a>
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

        <div class="col-sm-9">



            <div class="row">

                <div class="col-md-12 banner">
                    <a href="#">
                        <img src="img/sushi1.jpg" alt="" class="img-responsive">
                    </a>
                </div>

            </div>

            


        </div>
        <!-- /.col-md-9 -->

        <!-- *** RIGHT COLUMN END *** -->

    </div>
</asp:Content>
