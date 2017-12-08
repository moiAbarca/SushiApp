<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_ofertas.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_ofertas1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Ofertas</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Ofertas</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <!-- INICIO OFERTAS -->
    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">
                <div class="ibox-content m-b-sm border-bottom">  
                    <div class="row">
                        <h2>Ofertas</h2>
                            <div class="clients-list">                                        
                                <div class="full-height-scroll">
                                            <div class="table-responsive">
                                                <div class="input-group">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                    <asp:TextBox CssClass="form-control" ID="txtId" placeholder="Ingrese Id" runat="server"></asp:TextBox>                                                    
                                                   <span class="input-group-btn">
                                                    <%--<button type="button" class="btn btn-primary btn-sm btn-block">Enviar mensaje</button>--%>
                                                     <asp:Button CssClass="btn btn btn-primary" ID="txtOferta" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />
                                                   </span>
                                                </div>
                                      <div class="client-detail">
                                        <div class="full-height-scroll">
                                            <br />

                                            <asp:Button CssClass="btn btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"  />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
                                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
                                            &nbsp;
                                            <br />
                                            <br />
                                            <strong>Información:</strong>
                                            
                                            <ul class="list-group clear-list">                                                
                                                <li class="list-group-item fist-item">
                                                    <span class="pull-right" id="prNombre"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></span>
                                                    Descuento:
                                            </li>
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prFechaInicio"><asp:Calendar ID="calFechaInicio" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                                        <OtherMonthDayStyle ForeColor="#999999" />
                                                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                                        <TodayDayStyle BackColor="#CCCCCC" />
                                                    </asp:Calendar> </span>
                                                    Fecha de Inicio:
                                                    
                                            </li>
                                                
                                                
                                                
                                                <li class="list-group-item">
                                                    <span class="pull-right" id="prFechaTermino"><asp:Calendar ID="calFechaTermino" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                                        <OtherMonthDayStyle ForeColor="#999999" />
                                                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                                        <TodayDayStyle BackColor="#CCCCCC" />
                                                    </asp:Calendar> </span>
                                                    Fecha de termino:
                                                                                       
                                           </ul>                                                                                       
                                                  <!--GV cliente-->                                               
                                                  <!--<asp:GridView ID="gvAdministrador" CssClass="footable table table-stripped toggle-arrow-tiny" runat="server"></asp:GridView>  -->                                              
                                                  <!--FIN GV cliente-->                                                                                                                                                                                              
                                        </div>                                                   
                                     </div>                                                
                                 </div>
                              </div> 
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- FIN OFERTAS -->
</asp:Content>
