<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="SpecialRolls.aspx.cs" Inherits="SushiApp.PaginaUsuario.SpecialRolls1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
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
                            <a href="SpecialRolls.aspx">Special Rolls <span class="badge pull-right">
                                <asp:Label ID="lblCantProd" runat="server" Text=""></asp:Label></span></a>
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

          <%--  <div class="banner">
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
            <!--<p class="text-muted lead"></p>-->
            <div class="row products">

                <!-- ListView Prueba-->

                <asp:ListView runat="server" ID="ProductsListView" GroupItemCount="3" OnSelectedIndexChanged="ProductsListView_SelectedIndexChanged" OnItemCommand="ProductsListView_ItemCommand">

                    <LayoutTemplate>
                        <table cellpadding="5" runat="server"
                            id="tblProducts" cssclass="table-responsive" style="">
                            <tr runat="server" id="groupPlaceholder">
                            </tr>
                        </table>
                        <asp:DataPager runat="server" ID="DataPager" PageSize="9"></asp:DataPager>
                    </LayoutTemplate>

                    <GroupTemplate>
                        <tr runat="server" id="productRow"
                            style="">
                            <td runat="server" id="itemPlaceholder"></td>
                        </tr>
                    </GroupTemplate>

                    <ItemTemplate>
                        <div class="col-md-4 col-sm-6">
                            <%--<div class="product">--%>
                            <br />
                            <div class="img-responsive">
                                <a href="#" data-toggle="modal" data-target="#modalSR<%#Eval("Id") %>">
                                    <asp:Image ID="imgImagenProducto" runat="server" CssClass="img-responsive image1" ImageUrl='<%# Bind("Imagen") %>' />
                                </a>
                            </div>
                            <div class="text-center">
                                <h4>
                                    <asp:Label ID="lblNombreProducto" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label></h4>
                                <p class="price">$<asp:Label ID="lblPrecioProducto" runat="server" Text='<%# Bind("Precio") %>'></asp:Label></p>
                                <%--<button type="submit" class="btn btn-template-main" ID="btnAgregarPedido" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="Agregar"><i class="fa fa-shopping-cart"></i> Agregar a mi pedido</button>--%>
                                <asp:Button ID="btnAgregarPedido" CommandArgument='<%#Eval("Id") %>' CommandName="Agregar" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-template-main" />
                            </div>
                            <%--</div>--%>
                        </div>

                        <!-- *** Product MODAL *** -->
                        <div class="modal fade" id="modalSR<%#Eval("Id") %>" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title">
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label></h4>
                                        <p>
                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Porciones") %> '></asp:Label>
                                            porciones
                                        </p>
                                        <div class="form-group">
                                            <asp:Image ID="Image2" runat="server" class="img-responsive image1" ImageUrl='<%# Bind("Imagen") %>' />
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                                        </div>
                                        <div class="form-group">

                                            <p class="text-primary">$<asp:Label ID="Label6" runat="server" Text='<%# Bind("Precio") %>' CssClass="text-primary" Font-Size="Larger"></asp:Label></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- *** Product MODAL END *** -->

                    </ItemTemplate>

                </asp:ListView>

                <hr />

                <asp:XmlDataSource ID="XmlDataSourceWsProducto" runat="server"></asp:XmlDataSource>
                <!-- fin ListView-->

                <!-- *** Volver arriba*** -->
                <%--<div class="row">
                    <div class="col-md-12 banner">
                        <a href="#">
                            <img src="img/suhi900.jpg" alt="" class="img-responsive">
                        </a>
                    </div>
                </div>--%>
                <!-- ***Fin Volver arriba*** -->
            </div>
        </div>
        <!-- *** RIGHT COLUMN END *** -->
        <!-- *** FIN Hoja*** -->
    </div>
</asp:Content>
