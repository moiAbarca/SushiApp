﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Checkout4.aspx.cs" Inherits="SushiApp.PaginaUsuario.Checkout41" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container">

            <div class="row">
                <div class="col-md-12">
                    <p class="text-muted lead">You currently have 3 item(s) in your cart.</p>
                </div>


                <div class="col-md-9 clearfix" id="basket">

                    <div class="box">

                        <div>

                            <ul class="nav nav-pills nav-justified">
                                <li class="active"><a href="Checkout1.aspx"><i class="fa fa-user"></i>
                                    <br>
                                    Login</a>
                                </li>
                                <li class="active"><a href="Checkout2.aspx"><i class="fa fa-map-marker"></i>
                                    <br>
                                    Dirección de entrega</a>
                                </li>
                                <li class="active"><a href="Checkout3.aspx"><i class="fa fa-money"></i>
                                    <br>
                                    Método de Pago</a>
                                </li>
                                <li class="active"><a href="#"><i class="fa fa-eye"></i>
                                    <br>
                                    Orden</a>
                                </li>
                            </ul>

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
                                        <asp:BoundField DataField="PRECIO_PRODUCTO" HeaderText="Precio" />
                                        <asp:BoundField DataField="CANTIDAD_PRODUCTO" HeaderText="Cantidad" />
                                        <asp:BoundField DataField="SUBTOTAL" HeaderText="Subtotal" />

                                    </Columns>

                                </asp:GridView>
                                    </table>

                                </div>
                                <!-- /.table-responsive -->
                            </div>
                            <!-- /.box -->

                            <div class="box-footer">
                                <div class="pull-left">
                                    <a href="Inicio.aspx" class="btn btn-default"><i class="fa fa-chevron-left"></i>Seguir comprando</a>
                                </div>
                                <div class="pull-right">
                                    <button class="btn btn-default"><i class="fa fa-refresh"></i>Update cart</button>

                                    <asp:Button ID="btnPagar" runat="server" CssClass="btn btn-template-main" Text="Pagar" OnClick="btnPagar_Click" /><i class="fa fa-chevron-right"></i>


                                </div>
                            </div>
                        </div>

                    </div>
                    <!-- /.box -->



                </div>
                <!-- /.col-md-9 -->

                <div class="col-md-3">
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
                                        <th><asp:Label ID="lblSubtotal" runat="server" Text="" CssClass="form-control"></asp:Label></th>
                                    </tr>
                                    <tr>
                                        <td>Propina Sugerida (10%)</td>
                                        <th><asp:Label ID="lblPropina" runat="server" Text="" CssClass="form-control"></asp:Label></th>
                                    </tr>
                                    <tr>
                                        <td>Total sin propina</td>
                                        <th><asp:Label ID="lblTotalSinTip" runat="server" Text="" CssClass="form-control"></asp:Label></th>
                                    </tr>
                                    <tr class="total">
                                        <td>Total</td>
                                        <th><asp:Label ID="lblTotal" runat="server" Text="" CssClass="form-control"></asp:Label></th>
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

            </div>

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
