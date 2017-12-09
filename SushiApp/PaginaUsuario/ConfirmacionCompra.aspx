<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmacionCompra.aspx.cs" Inherits="SushiApp.PaginaUsuario.ConfirmacionCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="robots" content="all,follow"/>
    <meta name="googlebot" content="index,follow,snippet,archive"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>

    <title>Fukusuke Sushi Delivery</title>

    <meta name="keywords" content=""/>

   
    <script>
        window.onload = function () {
            // Una vez cargada la página, el formulario se enviara automáticamente.
            document.forms["form1"].submit();
        }
    </script>
</head>
<body>
    <div class="container">
        <div class="col-sm-6 col-sm-offset-3">
            <div class="box">
                <h3>Está siendo redirigido a la página de pago.</h3>
                <h4 class="text-muted">Espere unos segundos por favor...</h4>
            </div>

        </div>
        <!-- /.col-sm-6 -->
    </div>
    <!-- /.container -->
    <form id="form1" runat="server" action="http://www.checkbox.cl/PaymentGateway/pay.php" method="post">
        <div>
            <input type="hidden" name="comercio_id" value="160" />
            <input type="hidden" name="comercio_logo" value="" />

            <input type="hidden" name="item_nombre" value="Pedido de Compra" />
            <input type="hidden" name="item_id" value="01" />
        
            <input type="hidden" name="item_precio" value="" id="item_precio" runat="server"/>

            <input type="hidden" name="url_return" value="http://localhost:2205/PaginaUsuario/PagoOk.aspx" />
            <input type="hidden" name="url_cancel" value="http://localhost:2205/PaginaUsuario/ErrorPago.aspx" />
            <input type="hidden" name="url_h2h" value="" />

            <input type="hidden" name="cliente_nombres" id="cliente_nombres" value="" />
            <input type="hidden" name="cliente_rut" value="" />
            <input type="hidden" name="cliente_email" id="cliente_email" value="" runat="server"/>

            <%--<input type="submit" value="Pagar Online" />--%>
        </div>
    </form>
</body>
</html>
