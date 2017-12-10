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

   <!-- Bootstrap and Font Awesome css -->
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css"/>

    <!-- Css animations  -->
    <link href="css/animate.css" rel="stylesheet"/>

    <!--SweetAlert Scripts y CSS-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>

    <!-- Funciones JavaScript Locales -->
    <script src="js/JavaScript.js"></script>

    <!-- Theme stylesheet, if possible do not edit this stylesheet -->
    <link href="css/style.blue.css" rel="stylesheet"/>

    <!-- Custom stylesheet - for your changes -->
    <link href="css/custom.css" rel="stylesheet"/>

    <!-- Responsivity for older IE -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
<![endif]-->


    <script>
        window.onload = function () {
            // Una vez cargada la página, el formulario se enviara automáticamente.
            document.forms["form1"].submit();
        }
    </script>
</head>
<body>
    <div class="container center">
        <div class="col-sm-6 col-sm-offset-3">
            <div class="box center">
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
