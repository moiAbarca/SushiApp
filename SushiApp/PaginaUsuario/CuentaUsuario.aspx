<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="CuentaUsuario.aspx.cs" Inherits="SushiApp.PaginaUsuario.CuentaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="clearfix">

        <div class="container">

            <div class="row">

                <!-- *** LEFT COLUMN ***
			 _________________________________________________________ -->

                <div class="col-md-9 clearfix" id="customer-account">

                    <p class="lead">Cambia tus datos o tu password de acceso aquí.</p>
                    <p class="text-muted">Registra tus datos y ahorra tiempo al solicitar tus pedidos.</p>

                    <div class="box">

                        <div class="heading">
                            <h3 class="text-uppercase">Cambiar password</h3>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblPassword" runat="server" Text="Password actual"></asp:Label>
                                    <asp:TextBox ID="txtOldPassword" runat="server" CssClass="form-control" TextMode="Password" MaxLength="20"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNewPassword" runat="server" Text="Nuevo Password"></asp:Label>
                                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-control" MaxLength="20" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNewPassword2" runat="server" Text="Reingrese Nuevo Password"></asp:Label>
                                    <asp:TextBox ID="txtNewPassword2" runat="server" CssClass="form-control" MaxLength="20" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <!-- /.row -->

                        <div class="text-center">
                            <button runat="server" id="btnGuardar" onserverclick="btnGuardar_ServerClick" type="submit" class="btn btn-template-main"><i class="fa fa-save"></i>Guardar Nuevo Password</button>
                        </div>
                    </div>
                    <!-- /.box -->


                    <div class="box clearfix">
                        <div class="heading">
                            <h3 class="text-uppercase">Datos Personales</h3>
                        </div>

                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="30" placeholder="Ingrese su nombre..."></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" MaxLength="30" placeholder="Ingrese su apellido..."></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <!-- /.row -->

                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblRut" runat="server" Text="Rut"></asp:Label>
                                    <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" MaxLength="11" placeholder="Ingrese su Rut..."></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                                    <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control" MaxLength="10" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <!-- /.row -->

                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                                    <asp:TextBox ID="txtDireccion" CssClass="form-control" placeholder="Ingrese su dirección..." runat="server" MaxLength="50"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <asp:Label ID="lblComuna" runat="server" Text="Comuna"></asp:Label>
                                    <asp:DropDownList ID="ddlComuna" CssClass="form-control" runat="server">
                                        <asp:ListItem>Maipú</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
                                    <asp:DropDownList ID="ddlSexo" CssClass="form-control" runat="server">
                                        <asp:ListItem>Seleccione...</asp:ListItem>
                                        <asp:ListItem>Masculino</asp:ListItem>
                                        <asp:ListItem>Femenino</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                                    <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" MaxLength="9" placeholder="Ingrese su teléfono"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                    <%--<span class="input-group-addon" id="basic-addon1">@</span>--%> <%--aria-describedby="basic-addon1"--%>
                                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" ReadOnly="True" TextMode="SingleLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-12 text-center">
                                <button type="submit" class="btn btn-template-main" id="btnGuardaDatos" runat="server" onserverclick="btnGuardaDatos_ServerClick"><i class="fa fa-save"></i>Guardar Cambios</button>

                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.col-md-9 -->

                <!-- *** LEFT COLUMN END *** -->

                <!-- *** RIGHT COLUMN ***
			 _________________________________________________________ -->

                <div class="col-md-3">
                    <!-- *** CUSTOMER MENU ***
 _________________________________________________________ -->
                    <div class="panel panel-default sidebar-menu">

                        <div class="panel-heading">
                            <h3 class="panel-title">Menú Usuario</h3>
                        </div>

                        <div class="panel-body">

                            <ul class="nav nav-pills nav-stacked">
                                <li>
                                    <a href="PedidosUsuario.aspx"><i class="fa fa-list"></i>Mis Pedidos</a>
                                </li>
                                <li class="active">
                                    <a href="#"><i class="fa fa-user"></i>Mi Cuenta</a>
                                </li>

                            </ul>
                            <br />
                            <br />
                            <ul class="nav nav-pills nav-stacked">
                                <li>
                                    <button runat="server" id="btnLogout" onserverclick="btnLogout_ServerClick" type="submit" class="btn btn-template-main"><i class="fa fa-sign-out"></i>Logout</button>
                                    <%--<a href="index.html"><i class="fa fa-sign-out"></i>Logout</a>--%>
                                </li>
                            </ul>
                        </div>

                    </div>
                    <!-- /.col-md-3 -->

                    <!-- *** CUSTOMER MENU END *** -->
                </div>

                <!-- *** RIGHT COLUMN END *** -->

            </div>
            <!-- /.row -->

        </div>
        <!-- /.container -->
    </div>
    <!-- /#content -->
</asp:Content>
