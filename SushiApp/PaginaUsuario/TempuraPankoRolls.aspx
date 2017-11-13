<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="TempuraPankoRolls.aspx.cs" Inherits="SushiApp.PaginaUsuario.TempuraPankoRolls1" %>

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
                <a href="#">
                    <img src="img/banner5.jpg" alt="sales 2014" class="img-responsive">
                </a>
            </div>
            <!-- /.banner -->

        </div>
        <!-- /.col-md-3 -->

        <!-- *** LEFT COLUMN END *** -->
        <div class="col-sm-9">
            <!--<p class="text-muted lead"></p>-->
            <div class="row products">
       
        <!-- ListView Prueba-->
        
                        <asp:ListView runat="server"  
                          ID="ProductsListView" GroupItemCount="3" OnSelectedIndexChanged="ProductsListView_SelectedIndexChanged" OnItemCommand="ProductsListView_ItemCommand" >
                  <LayoutTemplate>
                    <table cellpadding="5" runat="server"
                           id="tblProducts" style="height:320px"><!--style="height:320px"-->
                      <tr runat="server" id="groupPlaceholder">
                      </tr>
                    </table>
                    <asp:DataPager runat="server" ID="DataPager"
                                   PageSize="9">
                       
                    </asp:DataPager>
                  </LayoutTemplate>
                  <GroupTemplate>
                    <tr runat="server" id="productRow"
                        style="height:80px">
                      <td runat="server" id="itemPlaceholder">
                      </td>
                    </tr>
                  </GroupTemplate>
                  <ItemTemplate>
                    <td valign="top" align="center" style=" width:100px" runat="server">
                  
                            <div class="image">
                                <a href="#" data-toggle="modal" data-target="#modalSR1">
                                    <asp:Image ID="Image1" runat="server" class="img-responsive image1" ImageUrl='<%# Bind("imagenProdcuto") %>' />
                                </a>
                            </div>                      
                        <br />                        
                        <div class="text">
                            <h4><asp:Label ID="Label1" runat="server" Text='<%# Bind("nombreProducto") %>'></asp:Label></h4>
                            <p class="price"><asp:Label ID="Label2" runat="server" Text='<%# Bind("precioProducto") %>'></asp:Label></p>
                            <asp:Button ID="btnAgregarPedido" CommandArgument='<%#Eval("productoId") %>' CommandName="Agregar" runat="server" Text="Agregar a mi pedido" CssClass="btn btn-lg btn-success" />
                        </div>
                        <br />
                        <!-- *** Product MODAL *** -->
                        <div class="modal fade" id="modalSR1" tabindex="-1" role="dialog" aria-hidden="true">
                            <div class="modal-dialog modal-sm">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                        <h4 class="modal-title"><asp:Label ID="Label3" runat="server" Text='<%# Bind("nombreProducto") %>'></asp:Label></h4>
                                        <p><asp:Label ID="Label4" runat="server" Text='<%# Bind("porcionesProdcuto") %> '></asp:Label> porciones</p>
                                        <div class="form-group">
                                            <asp:Image ID="Image2" runat="server" class="img-responsive image1" ImageUrl='<%# Bind("imagenProdcuto") %>' />
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("descripcionProducto") %>'></asp:Label>
                                        </div>
                                        <div class="form-group">
                                            
                                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("precioProducto") %>' CssClass="text-primary" Font-Size="Larger"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- *** Product MODAL END *** -->
                        
                    </td>
                  </ItemTemplate>
                    <ItemSeparatorTemplate>
                      <td class="separator" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    </ItemSeparatorTemplate>
                </asp:ListView>
                <asp:XmlDataSource ID="XmlDataSourceWsProducto" runat="server"></asp:XmlDataSource>
        <!-- fin ListView-->
        </div>
            </div>
        <!-- *** FIN Hoja*** -->
    </div>
</asp:Content>
