<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Checkout3.aspx.cs" Inherits="SushiApp.PaginaUsuario.Checkout31" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container">

            <div class="row">

                <div class="col-md-9 clearfix" id="checkout">

                    <div class="box">
                        <div >
                            <ul class="nav nav-pills nav-justified">
                                <li class="active"><a href="Checkout1.aspx"><i class="fa fa-user"></i>
                                    <br>
                                    Login</a>
                                </li>
                                <li class="active"><a href="Checkout2.aspx"><i class="fa fa-map-marker"></i>
                                    <br>
                                    Dirección de entrega</a>
                                </li>
                                <li class="active"><a href="#"><i class="fa fa-money"></i>
                                    <br>
                                    Método de Pago</a>
                                </li>
                                <li class="disabled"><a href="#"><i class="fa fa-eye"></i>
                                    <br>
                                    Orden</a>
                                </li>
                            </ul>

                            <div class="content">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="box payment-method">

                                            <h4>Paypal</h4>

                                            <p>Puedes pagar con tu cuenta de Paypal.</p>

                                            <div class="box-footer text-center">

                                                <input type="radio" name="payment" value="payment1">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="box payment-method">

                                            <h4>Tarjeta de Débito o Crédito</h4>

                                            <p>Múltiples opciones de pago con tarjeta.</p>

                                            <div class="box-footer text-center">

                                                <input type="radio" name="payment" value="payment2">
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-sm-6">
                                        <div class="box payment-method">

                                            <h4>Efectivo</h4>

                                            <p>Pagarás cuando recibas tu producto.</p>

                                            <div class="box-footer text-center">

                                                <input type="radio" name="payment" value="payment3">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- /.row -->

                            </div>
                            <!-- /.content -->

                            <div class="form-group">
                                <div class="box-footer">
                                    <div class="pull-left">
                                        <a href="ShopBasket.aspx" class="btn btn-default"><i class="fa fa-chevron-left"></i>Volver a la canasta</a>
                                    </div>
                                    <div class="pull-right">
                                        <asp:Button ID="btnResumen" runat="server" Text="Continuar" CssClass="btn btn-template-main" OnClick="btnResumen_Click" />
                                    </div>
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

                </div>
                <!-- /.col-md-3 -->

            </div>
            <!-- /.row -->

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
