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
                                    <asp:Label ID="lblPassword" runat="server" Text="Paswword actual"></asp:Label>
                                    <asp:TextBox ID="txtOldPassword" runat="server" CssClass="form-control" TextMode="Password" MaxLength="20"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNewPassword" runat="server" Text="Nuevo Password"></asp:Label>
                                    <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNewPassword2" runat="server" Text="Reingrese Nuevo Password"></asp:Label>
                                    <asp:TextBox ID="txtNewPassword2" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
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
                                    <label for="firstname">Firstname</label>
                                    <input type="text" class="form-control" id="firstname">
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <label for="lastname">Lastname</label>
                                    <input type="text" class="form-control" id="lastname">
                                </div>
                            </div>
                        </div>
                        <!-- /.row -->

                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <label for="company">Company</label>
                                    <input type="text" class="form-control" id="company">
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <label for="street">Street</label>
                                    <input type="text" class="form-control" id="street">
                                </div>
                            </div>
                        </div>
                        <!-- /.row -->

                        <div class="row">
                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <label for="city">Company</label>
                                    <input type="text" class="form-control" id="city">
                                </div>
                            </div>
                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <label for="zip">ZIP</label>
                                    <input type="text" class="form-control" id="zip">
                                </div>
                            </div>
                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <label for="state">State</label>
                                    <select class="form-control" id="state"></select>
                                </div>
                            </div>
                            <div class="col-sm-6 col-md-3">
                                <div class="form-group">
                                    <label for="country">Country</label>
                                    <select class="form-control" id="country"></select>
                                </div>
                            </div>

                            <div class="col-sm-6">
                                <div class="form-group">
                                    <label for="phone">Telephone</label>
                                    <input type="text" class="form-control" id="phone">
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <label for="email_account">Email</label>
                                    <input type="text" class="form-control" id="email_account">
                                </div>
                            </div>
                            <div class="col-sm-12 text-center">
                                <button type="submit" class="btn btn-template-main"><i class="fa fa-save"></i>Save changes</button>

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
