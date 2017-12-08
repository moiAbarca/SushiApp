<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Checkout1.aspx.cs" Inherits="SushiApp.PaginaUsuario.Checkout11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container">

            <div class="row">

                <div class="col-md-9 clearfix" id="checkout">

                    <div class="box">
                        <form method="post" action="Checkout2.aspx">

                            <ul class="nav nav-pills nav-justified">
                                <li class="active"><a href="#"><i class="fa fa-user"></i>
                                    <br>
                                    Login</a>
                                </li>
                                <li class="disabled"><a href="#"><i class="fa fa-map-marker"></i>
                                    <br>
                                    Dirección de entrega</a>
                                </li>
                                <li class="disabled"><a href="#"><i class="fa fa-money"></i>
                                    <br>
                                    Método de Pago</a>
                                </li>
                                <li class="disabled"><a href="#"><i class="fa fa-eye"></i>
                                    <br>
                                    Orden</a>
                                </li>
                            </ul>


                            <div class="container">

                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="box">
                                            <h2 class="text-uppercase">Nuevo Usuario</h2>

                                            <p class="lead">Aun no estás registrado?</p>
                                            <p>Con tu registro podrás acceder a promociones especiales y excelentes descuentos! Tan solo te tomará un minuto!</p>
                                            <div>
                                                <p class="text-muted">Si tienes alguna pregunta, por favor contáctate con nosotros<a href="Contacto.aspx"></a>.</p>

                                                <hr>

                                                <div class="form-group">
                                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>

                                                <div class="form-group">
                                                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>

                                                <div class="form-group">
                                                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="50" TextMode="Email"></asp:TextBox>
                                                </div>


                                                <div class="form-group">
                                                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" MaxLength="20"></asp:TextBox>
                                                </div>

                                                <div class="text-center">
                                                    <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-template-main" Text="Registrar" OnClick="btnRegistrar_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="box">
                                            <h2 class="text-uppercase">Login</h2>

                                            <p class="lead">Ya estás registrado?</p>
                                            <p class="text-muted">
                                                Ingresa tus datos de usuario para acceder a tu cuenta.
                                            </p>

                                            <hr>

                                            <div>
                                                <div class="form-group">
                                                    <asp:Label ID="lblEmailLogin" runat="server" Text="Email"></asp:Label>
                                                    <asp:TextBox ID="txtEmailLogin" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                                <div class="form-group">
                                                    <asp:Label ID="lblPasswordLogin" runat="server" Text="Password"></asp:Label>
                                                    <asp:TextBox ID="txtPasswordLogin" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                                <div class="text-center">
                                                    <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-template-main" Text="Ingresar" OnClick="btnIngresar_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <!-- /.row -->

                            </div>
                            <!-- /.container -->



                        </form>
                    </div>
                    <!-- /.box -->


                </div>
                <!-- /.col-md-9 -->

            </div>
            <!-- /.row -->


        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
