<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="PedidosUsuario.aspx.cs" Inherits="SushiApp.PaginaUsuario.PedidosUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
            <div class="container">


                <div class="row">

                    <!-- *** LEFT COLUMN ***
			 _________________________________________________________ -->

                    <div class="col-md-9" id="customer-orders">

                        <p class="text-muted lead">Si tienes alguna pregunta, por favor, siéntete libre en <a href="Contacto.aspx">contactarnos</a>.</p>

                        <div class="box">

                            <div class="table-responsive">
                                <table class="table table-hover">
                                    <thead>
                                        <tr>
                                            <th>Orden</th>
                                            <th>Fecha</th>
                                            <th>Total</th>
                                            <th>Estado</th>
                                            <th>Acción</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <th># 1735</th>
                                            <td>22/11/2017</td>
                                            <td>$ 22.000</td>
                                            <td><span class="label label-info">Iniciando Preparación</span>
                                            </td>
                                            <td><a href="customer-order.html" class="btn btn-template-main btn-sm">Ver</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th># 1735</th>
                                            <td>22/11/2017</td>
                                            <td>$ 5.600</td>
                                            <td><span class="label label-info">Iniciando Preparación</span>
                                            </td>
                                            <td><a href="customer-order.html" class="btn btn-template-main btn-sm">Ver</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th># 1735</th>
                                            <td>23/11/2017</td>
                                            <td>$ 10.250</td>
                                            <td><span class="label label-success">Recibido</span>
                                            </td>
                                            <td><a href="customer-order.html" class="btn btn-template-main btn-sm">Ver</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th># 1735</th>
                                            <td>23/11/2017</td>
                                            <td>$ 15.300</td>
                                            <td><span class="label label-danger">Cancelado</span>
                                            </td>
                                            <td><a href="customer-order.html" class="btn btn-template-main btn-sm">Ver</a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <th># 1735</th>
                                            <td>24/11/2017</td>
                                            <td>$ 5.400</td>
                                            <td><span class="label label-warning">Por confirmar</span>
                                            </td>
                                            <td><a href="customer-order.html" class="btn btn-template-main btn-sm">Ver</a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.table-responsive -->

                        </div>
                        <!-- /.box -->

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
                                <li class="active">
                                    <a href="PedidosUsuario.aspx"><i class="fa fa-list"></i>Mis Pedidos</a>
                                </li>
                                <li>
                                    <a href="CuentaUsuario.aspx"><i class="fa fa-user"></i>Mi Cuenta</a>
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


            </div>
            <!-- /.container -->
        </div>
        <!-- /#content -->
</asp:Content>
