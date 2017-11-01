<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="ShopBasket.aspx.cs" Inherits="SushiApp.PaginaUsuario.ShopBasket1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container">

            <div class="row">
                <div class="col-md-12">
                    <p class="text-muted lead">Tienes actualmente <asp:Label ID="lblProductosActuales" runat="server" Text=""></asp:Label> producto(s) en tu carrito.</p>
                </div>


                <div class="col-md-9 clearfix" id="basket">

                    <div class="box">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th colspan="2">Producto</th>
                                            <th>Cantidad</th>
                                            <th>Precio unitario</th>
                                            <th>Descuento</th>
                                            <th colspan="2">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <a href="#">
                                                    <img src="img/detailsquare.jpg" alt="White Blouse Armani">
                                                </a>
                                            </td>
                                            <td><a href="#">White Blouse Armani</a>
                                            </td>
                                            <td>
                                                <input type="number" value="2" class="form-control">
                                            </td>
                                            <td>$123.00</td>
                                            <td>$0.00</td>
                                            <td>$246.00</td>
                                            <td><a href="#"><i class="fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <a href="#">
                                                    <img src="img/basketsquare.jpg" alt="Black Blouse Armani">
                                                </a>
                                            </td>
                                            <td><a href="#">Black Blouse Armani</a>
                                            </td>
                                            <td>
                                                <input type="number" value="1" class="form-control">
                                            </td>
                                            <td>$200.00</td>
                                            <td>$0.00</td>
                                            <td>$200.00</td>
                                            <td><a href="#"><i class="fa fa-trash-o"></i></a>
                                            </td>
                                        </tr>
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <th colspan="5">Total</th>
                                            <th colspan="2">$446.00</th>
                                        </tr>
                                    </tfoot>
                                </table>

                            </div>
                            <!-- /.table-responsive -->

                            <div class="box-footer">
                                <div class="pull-left">
                                    <a href="Inicio.aspx" class="btn btn-default"><i class="fa fa-chevron-left"></i>Seguir comprando</a>
                                </div>
                                <div class="pull-right">
                                    <button class="btn btn-default"><i class="fa fa-refresh"></i>Update cart</button>

                                    <button type="submit" class="btn btn-template-main">
                                        Proceder al pago <i class="fa fa-chevron-right"></i>
                                    </button>
                                </div>
                            </div>
                    </div>
                    <!-- /.box -->

                    <div class="row">
                        <div class="col-md-3">
                            <div class="box text-uppercase">
                                <h3>Te pueden interesar estos productos</h3>
                            </div>
                        </div>

                        <div class="col-md-3">
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

                        <div class="col-md-3">
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

                        <div class="col-md-3">
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

                    </div>

                </div>
                <!-- /.col-md-9 -->

                <div class="col-md-3">
                    <div class="box" id="order-summary">
                        <div class="box-header">
                            <h3>Order summary</h3>
                        </div>
                        <p class="text-muted">Shipping and additional costs are calculated based on the values you have entered.</p>

                        <div class="table-responsive">
                            <table class="table">
                                <tbody>
                                    <tr>
                                        <td>Order subtotal</td>
                                        <th>$446.00</th>
                                    </tr>
                                    <tr>
                                        <td>Shipping and handling</td>
                                        <th>$10.00</th>
                                    </tr>
                                    <tr>
                                        <td>Tax</td>
                                        <th>$0.00</th>
                                    </tr>
                                    <tr class="total">
                                        <td>Total</td>
                                        <th>$456.00</th>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                    </div>


                    <div class="box">
                        <div class="box-header">
                            <h4>Coupon code</h4>
                        </div>
                        <p class="text-muted">Si tiene un cupón de descuento, por favor introduzca el código aquí</p>
                     
                            <div class="input-group">

                                <input type="text" class="form-control">

                                <span class="input-group-btn">

                                    <button class="btn btn-template-main" type="button"><i class="fa fa-gift"></i></button>

                                </span>
                            </div>
                            <!-- /input-group -->
                        
                    </div>

                </div>
                <!-- /.col-md-3 -->

            </div>

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
