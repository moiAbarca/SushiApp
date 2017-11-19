<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Checkout4.aspx.cs" Inherits="SushiApp.PaginaUsuario.Checkout41" %>

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
                                        <asp:GridView ID="GVCanasta" runat="server" AutoGenerateColumns="False" Width="100%">
                                            <Columns>
                                                <asp:TemplateField HeaderText="Quitar">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="19px"
                                                            ImageUrl="~/PaginaUsuario/img/ImagenesSushi/sushifavicon.png" Width="20px" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo" />
                                                <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="Nombre" />
                                                <asp:BoundField DataField="PRECIO_PRODUCTO" HeaderText="Precio" />
                                                <asp:BoundField DataField="CANTIDAD_PRODUCTO" HeaderText="Cantidad" />
                                                <%--<asp:TemplateField HeaderText="Cantidad">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="73px" DataField="CANTIDAD_PRODUCTO" MaxLength="2"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>--%>

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
