<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="ShopBasket.aspx.cs" Inherits="SushiApp.PaginaUsuario.ShopBasket1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container-fluid">

            <div class="row">
                <div class=".col-md-8">
                    <p class="text-muted lead">
                        Tienes actualmente
                        <asp:Label ID="lblProductosActuales" runat="server" Text=""></asp:Label>
                        producto(s) en tu carrito.
                    </p>
                </div>


                <div class=".col-md-8" id="basket">

                    <div class="box">
                        <div class="table-responsive">
                            <table class="table">
                                <asp:GridView ID="GVCanasta" runat="server" AutoGenerateColumns="False" GridLines="Horizontal" Width="90%" CssClass="table-responsive table">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Imagen">
                                            <ItemStyle Width="105px" />
                                            <ItemTemplate>
                                                <asp:Image ID="ImageButton1" runat="server" Height="100px"
                                                    ImageUrl='<%# Eval("IMAGEN_PRODUCTO") %>' Width="100px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="Producto" />
                                        <asp:BoundField DataField="PRECIO_PRODUCTO" HeaderText="Precio" DataFormatString="{0:C}"/> 
                                        <%--DataFormatString="{0:C}"--%>
                                        <asp:BoundField DataField="CANTIDAD_PRODUCTO" HeaderText="Cantidad" />
                                        <asp:BoundField DataField="SUBTOTAL" HeaderText="Subtotal" DataFormatString="{0:C}"/>

                                    </Columns>

                                </asp:GridView>
                            </table>

                        </div>
                        <!-- /.table-responsive -->


                    </div>
                    <!-- /.box -->

                    <%--<div class="row">
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

                    </div>--%>
                </div>
                <!-- /.col-md-9 -->

                <div class=".col-md-4 .col-md-offset-4">
                    <div class="box" id="order-summary">
                        <div class="box-header">
                            <h3>Resumen de Pedido</h3>
                        </div>
                        <p class="text-muted"></p>

                        <div class="table-responsive">
                            <table class="table">
                                <tbody>
                                    <tr>
                                        <td>Subtotal Pedido</td>
                                        <th>
                                            <asp:Label ID="lblSubtotal" runat="server" Text="" CssClass="form-control"></asp:Label>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>Propina Sugerida (10%)</td>
                                        <th>
                                            <asp:Label ID="lblPropina" runat="server" Text="" CssClass="form-control"></asp:Label>
                                        </th>
                                    </tr>
                                    <tr>
                                        <td>Total sin propina</td>
                                        <th>
                                            <asp:Label ID="lblTotalSinTip" runat="server" Text="" CssClass="form-control"></asp:Label>
                                        </th>
                                    </tr>
                                    <tr class="total">
                                        <td>Total</td>
                                        <th>
                                            <asp:Label ID="lblTotal" runat="server" Text="" CssClass="form-control"></asp:Label>
                                        </th>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                    </div>


                    <div class="box">
                        <div class="box-header">
                            <h4>Cupón de Descuento</h4>
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
                <div class="box-footer">
                    <div class="pull-left">
                        <a href="Inicio.aspx" class="btn btn-default"><i class="fa fa-chevron-left"></i>Seguir comprando</a>
                    </div>
                    <div class="pull-right">
                        <button class="btn btn-default"><i class="fa fa-refresh"></i>Update cart</button>
                        <asp:Button ID="btnIr1" runat="server" CssClass="btn btn-template-main" Text="Comprar" OnClick="btnIr1_Click" />
                        <i class="fa fa-chevron-right"></i>

                    </div>
                </div>
            </div>

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
