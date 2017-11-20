<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaUsuario/VentasSushi.Master" AutoEventWireup="true" CodeBehind="Despacho.aspx.cs" Inherits="SushiApp.PaginaUsuario.Despacho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <button onclick="findMe()">Mostrar mi ubicación</button>
        <div id="map">

        </div>

        <script>
            function findMe() {
                var output = document.getElementById('map');
                if (navigator.geolocation) {
                    output.innerHTML = "<p>Tu navegador soporta Geolocalización</p>";
                } else {
                    output.innerHTML = "<p>Tu navegador no soporta Geolocalización</p>";
                }

                function localizacion(posicion) {
                    var latitude = posicion.coords.latitude;
                    var longitude = posicion.coord.longitude;

                    output.innerHTML = "<p>Latitud: " + latitude+ "<br>Longitud: " + longitude +"</p > ";
                }

                function error() {
                    output.innerHTML = "<p>No se pudo obtener tu ubicacion</p>";
                }

                navigator.geolocation.getCurrentPosition(localizacion, error);
            }

        </script>
    </div>
</asp:Content>
