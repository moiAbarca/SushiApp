<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagoOk.aspx.cs" Inherits="SushiApp.PaginaUsuario.PagoOk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <meta name="robots" content="all,follow"/>
    <meta name="googlebot" content="index,follow,snippet,archive"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"/>

    <title>Fukusuke Sushi Delivery</title>

    <meta name="keywords" content=""/>

    <link href='http://fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,500,700,800' rel='stylesheet' type='text/css'/>

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
    <link href="css/style.blue.css" rel="stylesheet" id="theme-stylesheet"/>

    <!-- Custom stylesheet - for your changes -->
    <link href="css/custom.css" rel="stylesheet"/>

    <!-- Responsivity for older IE -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
<![endif]-->


</head>
<body>
    <div class="container">

        <div class="col-sm-6 col-sm-offset-3" id="error-page">

            <div class="box">

                <p class="text-center">
                    <a href="Inicio.aspx">
                        <img src="img/logo.png"/>
                    </a>
                </p>

                <h3>Hemos recibido su Pago.</h3>
                <h4 class="text-muted">Por favor espere. Será redirigido en unos segundos...</h4>

                <p class="buttons">
                    <a href="Inicio.aspx" class="btn btn-template-main"><i class="fa fa-home"></i>Ir a la página de Inicio</a>
                </p>
            </div>


        </div>
        <!-- /.col-sm-6 -->
    </div>
    <!-- /.container -->
</body>
</html>
