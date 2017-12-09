<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="SushiApp.PaginaUsuario.Contacto1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="contact">

        <section>

            <div class="row">
                <div class="col-md-12">
                    <section>
                        <div class="heading">
                            <h2>Formulario de Contacto</h2>
                        </div>

                        <p class="lead">
                            Tienes alguna curiosidad? Ocurrió algún problema con nuestros productos?
                        <p>Siéntete libre de enviar tus consultas, dudas, sugerencias o quejas, te contestaremos a la brevedad posible</p>
                    </section>
                </div>
            </div>

        </section>

        <section>

            <div class="row">
                <div class="col-md-4">
                    <div class="box-simple">
                        <div class="icon">
                            <i class="fa fa-map-marker"></i>
                        </div>
                        <h3>Dirección</h3>
                        <p>
                            Mar de Chile 516
                                    <br>
                            Maipu, <strong>Santiago</strong>
                        </p>
                    </div>
                    <!-- /.box-simple -->
                </div>


                <div class="col-md-4">

                    <div class="box-simple">
                        <div class="icon">
                            <i class="fa fa-phone"></i>
                        </div>
                        <h3>Call center</h3>
                        <p class="text-muted">Puedes llamar a este número!</p>
                        <p>
                            <strong>+56 2 2345 1371</strong>
                        </p>
                    </div>
                    <!-- /.box-simple -->

                </div>

                <div class="col-md-4">

                    <div class="box-simple">
                        <div class="icon">
                            <i class="fa fa-envelope"></i>
                        </div>
                        <h3>Soporte electrónico</h3>
                        <p class="text-muted">Escríbenos y déjanos tus comentarios.</p>
                        <ul class="list-style-none">
                            <li><strong><a href="mailto:">contactofukusukesuhi@gmail.cl</a></strong>
                            </li>
                        </ul>
                    </div>
                    <!-- /.box-simple -->
                </div>
            </div>

        </section>

        <section>

            <div class="row text-center">

                <div class="col-md-12">
                    <div class="heading">
                        <h2>Formulario de Contacto</h2>
                    </div>
                </div>

                <div class="col-md-8 col-md-offset-2">
               
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                                    <asp:TextBox ID="txtNombre" runat="server" cssclass="form-control" MaxLength="30"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                                    <asp:TextBox ID="txtApellido" runat="server" cssclass="form-control" MaxLength="30"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                    <asp:TextBox ID="txtEmail" runat="server" cssclass="form-control" MaxLength="30" TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:Label ID="lblAsunto" runat="server" Text="Asunto"></asp:Label>
                                    <asp:TextBox ID="txtAsunto" runat="server" cssclass="form-control" MaxLength="50"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-12">
                                <div class="form-group">
                                    <asp:Label ID="lblMensaje" runat="server" Text="Mensaje"></asp:Label>
                                    <asp:TextBox ID="txtMensaje" runat="server" cssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 text-center">
                                <button type="submit" id="btnConsulta" class="btn btn-template-main" runat="server" onserverclick="btnConsulta_ServerClick"><i class="fa fa-envelope-o"></i>Enviar Mensaje</button>
                            </div>
                        </div>
                        <!-- /.row -->
                </div>
            </div>
            <!-- /.row -->
        </section>
    </div>
</asp:Content>
