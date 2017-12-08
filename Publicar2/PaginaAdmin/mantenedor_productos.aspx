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
      
    </div>
    <!-- FIN DE BREADCRUMB -->

    <div class="m-t" >
        <div class="wrapper wrapper-content animated fadeInRight ecommerce">
            
            <!-- INICIO FILTROS DE BUSQUEDA -->
               
            <div class="ibox-content m-b-sm border-bottom">                
                <div class="row">
                    <ul class="list-group clear-list">  
                      <li class="list-group-item">   
                          <span>
                            <!-- botones -->
                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />    
                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />                                                                                     
                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />       
                            &nbsp;<asp:Button CssClass="btn btn btn-primary" ID="btneliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" />                                  
                            <!-- botones -->  
                           </span>                                                                  
                       </li>                                              
                       <li class="list-group-item">                           
                            <span class="pull-right" id="prId">                                                        
                            <asp:TextBox placeholder="Ingrese Id" ID="txtIdproducto" runat="server"></asp:TextBox>
                             </span>    
                           ID Producto
                       </li>
                        <li class="list-group-item">                           
                            <span class="pull-right" id="prNombre">                                                        
                             <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                             </span>    
                           Nombre
                       </li>
                       <li class="list-group-item">                           
                            <span class="pull-right" id="prDescripcion">                                                        
                             <asp:TextBox  ID="txtDescripcion" runat="server"></asp:TextBox>
                             </span>    
                           Descripción
                       </li>
                        <li class="list-group-item">                           
                            <span class="pull-right" id="prPorciones">                                                        
                             <asp:TextBox  ID="txtPorcion" runat="server"></asp:TextBox>
                             </span>    
                           Porciones
                       </li>
                        <li class="list-group-item">                           
                            <span class="pull-right" id="prPrecio">                                                        
                             <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                             </span>    
                           Precio
                       </li>
                        <li class="list-group-item">                           
                            <span class="pull-right" id="prCategoria">                                                        
                             <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
                             </span>    
                           Categoria
                       </li>
                        <li class="list-group-item">                           
                            <span class="pull-right" id="prEstado">                                                        
                             <label class="control-label" for="status"></label>
                                    <select name="status" id="status" class="form-control">
                                        <option value="1" selected>Disponible</option>
                                        <option value="0">No Disponible</option>
                                    </select>
                             </span>    
                           Estado
                       </li>                       
                   </ul>                    
                       <br />
                    <br />              
                </div>                
            </div>
            
            <!-- FIN DE FILTROS DE BUSQUEDA -->
                       <!-- inicio imagen-->
                         <div class="form-group">
                            <label class="control-label" for="price">Imagen</label> <br />                           
                                <asp:FileUpload ID="FileUpload1" runat="server" />                                 
                                <asp:Button CssClass="btn btn btn-primary" ID="btnImagen" runat="server" Text="Cargar " OnClick="btnImagen_Click" /> 
                                <br />   
                             <asp:Image ID="imgFoto" runat="server"  />
                                <br />
                                <br />                             
                                <br />
                            <asp:TextBox ID="txtRuta" runat="server" Enabled="False" Visible="False"></asp:TextBox>
                        </div>
                     <!--fin imagen-->  
            <br />
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

</asp:Content>
