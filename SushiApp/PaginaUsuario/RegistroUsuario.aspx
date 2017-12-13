<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="SushiApp.PaginaUsuario.RegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <div class="container">

            <div class="row">
                <div class="col-md-6">
                    <div class="box">
                        <h2 class="text-uppercase">Nueva Cuenta</h2>

                        <p class="lead">Aun no estás registrado?</p>
                        <p>Con tu registro podrás acceder a promociones especiales y excelentes descuentos! Tan solo te tomará un minuto!</p>
                        <p class="text-muted">Si tienes alguna duda, por favor <a href="Contacto.aspx">contáctanos</a>, te contestaremos a la brevedad.</p>

                        <hr>


                        <div class="form-group">
                            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblRut" runat="server" Text="Rut"></asp:Label>
                            <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="50" TextMode="Email"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" MaxLength="30"></asp:TextBox>
                        </div>
                        <div class="text-center">
                            <button type="submit" class="btn btn-template-main" id="btnRegistrarse" runat="server" onserverclick="btnRegistrarse_ServerClick"><i class="fa fa-user-md"></i>Registrarse</button>
                        </div>

                    </div>
                </div>

                <div class="col-md-6">
                    <div class="box">
                        <h2 class="text-uppercase">Login</h2>

                        <p class="lead">Ya tienes una cuenta?</p>
                        <p class="text-muted">
                            Ingresa tus datos de usuario para acceder a tu cuenta.
                        </p>

                        <hr>


                        <div class="form-group">
                            <asp:Label ID="lblEmailLogin" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="txtEmailLogin" runat="server" CssClass="form-control" MaxLength="30" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPasswordLogin" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox ID="txtPasswordLogin" runat="server" CssClass="form-control" MaxLength="30" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="text-center">
                            <button type="submit" id="btnIngresar" runat="server" onserverclick="btnIngresar_ServerClick" class="btn btn-template-main"><i class="fa fa-sign-in"></i>Ingresar</button>
                        </div>

                    </div>
                </div>

            </div>
            <!-- /.row -->

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
