<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdmin/MenuInterior.Master" AutoEventWireup="true" CodeBehind="mantenedor_productos.aspx.cs" Inherits="SushiApp.PaginaAdmin.mantenedor_productos1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- INICIO DE BREADCRUMB -->
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Mantenedor Productos</h2>
            <ol class="breadcrumb">
                <li>
                    <a href="inicio.aspx">Inicio</a>
                </li>
                <li>
                    <a>Mantenedores</a>
                </li>
                <li class="active">
                    <strong>Productos</strong>
                </li>
            </ol>
        </div>
        <div class="col-lg-2">
        </div>
    </div>
    <!-- FIN DE BREADCRUMB -->

    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">
            <div class="row">
                <div class="col-sm-9">
                    <div class="ibox">
                        <div class="ibox-content">
            <!-- INICIO FILTROS DE BUSQUEDA -->
            <div class="ibox-content m-b-sm border-bottom">
                <!-- botones -->
                &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />    
                &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />                                                                                     
                &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />       
                &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />
                
                <br />
                <br />
                <!-- botones -->
                <div class="row">
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="product_name">ID Producto</label>
                            <%--<input type="text" id="price" name="producto" value="" placeholder="Nombre del producto" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" placeholder="Ingrese Id" ID="txtIdproducto" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <label class="control-label" for="price">Nombre</label>
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                        </div>
                    </div>                    
                    <div class="col-sm-3">
                        <div class="form-group">
                            <label class="control-label" for="price">Descripción</label>
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtDescripcion" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="price">Porciones</label>
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtPorcion" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="price">Precio</label>
                            <%--<input type="text" id="quantity" name="categoria" value="" placeholder="Categoria" class="form-control">--%>
                            <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server"></asp:TextBox>
                        </div>
                    </div> 
                    <div class="col-sm-3">
                        <div class="form-group">
                            <label class="control-label" for="quantity">Categoria</label>
                            <%--<button type="button" class="btn btn btn-primary"> Buscar</button>--%>
                            <asp:TextBox CssClass="form-control" ID="txtCategoria" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="form-group">
                            <label class="control-label" for="status">Estado</label>
                            <select name="status" id="status" class="form-control">
                                <option value="1" selected>Disponible</option>
                                <option value="0">No Disponible</option>
                            </select>
                        </div>
                    </div>  
                                     
                </div>                
            </div>
            
            <!-- FIN DE FILTROS DE BUSQUEDA -->
                       
            
            <!--GRID VIEW DE PRODUCTOS -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="ibox">
                        <div class="ibox-content">
                            <asp:GridView CssClass="footable table table-stripped toggle-arrow-tiny" ID="gvProductos" runat="server"></asp:GridView> 
                        </div>
                    </div>
                </div>
            </div>
            <!--FIN DE GRIDVIEW -->

        </div>
    </div>
      </div>
    </div>
              </div>
    </div>
    

    <!-- nuevo panel 2-->
    <div class="col-sm-4">
                    <div class="ibox ">
                        <div class="ibox-content">
                            <div class="tab-content">
                                <div id="usuario" class="tab-pane active">                                    
                                    <div class="client-detail">
                                        <div class="full-height-scroll">

                                            <!-- inicio imagen-->
                                             <div class="form-group">
                            <label class="control-label" for="price">Imagen</label>                            
                                <asp:FileUpload ID="FileUpload1" runat="server" />  
                                <asp:Button CssClass="btn btn btn-primary" ID="btnImagen" runat="server" Text="Cargar " OnClick="btnImagen_Click" />                                 
                                <asp:Image ID="imgFoto" runat="server"  />
                            <asp:TextBox ID="txtRuta" runat="server" Enabled="False"></asp:TextBox>
                        </div>
                                            <!--fin imagen-->                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                          </div>
                    </div>
                </div>
</asp:Content>
