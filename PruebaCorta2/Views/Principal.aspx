<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PruebaCorta2.Views.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.1/jquery.min.js"></script>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <link href="../css/style.css" rel="stylesheet" />

    <title>Destinos Turisticos en Costa Rica</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-custom">
                <div class="container2">
                    <img src="https://res.cloudinary.com/crunchbase-production/image/upload/c_lpad,h_170,w_170,f_auto,b_white,q_auto:eco,dpr_1/soajwwidqued43oaicpn" style="width: 60px; height: 60px; margin-left: 20px; transition: transform 0.5s ease-in-out;" onmouseover="this.style.transform='scale(1.5)';" onmouseout="this.style.transform='scale(1)';" />
                    <a class="navbar-brand" href="#" style="margin-left: 20px; color: black; font-family: Arial; font-size: 18px;">DestinosCR.com</a>
                </div>
                <div class="social-media" style="text-align: right; margin-top: -20px;">
                    <p style="margin-right: 1000px;"></p>
                    <div class="images" style="position: relative;">
                        <p style="overflow-y: hidden; margin-top: 10px; color: white;">Encuéntranos en redes sociales como...</p>
                        <img src="https://cdn-icons-png.flaticon.com/512/87/87390.png" style="width: 39px; height: 39px; margin-right: 20px;" />
                        <img src="https://assets.stickpng.com/images/623dd7d270712bdafc63c38a.png" style="width: 50px; height: 50px;" />
                        <p style="overflow-y: hidden; margin-top: 10px; font-family: Arial;">destinosCR_ 23</p>

                    </div>

                </div>
            </nav>

            <section class="hero">
                <img src="https://www.selina.com/blog/wp-content/uploads/2020/09/atanas-malamov-xGhaXZtQb1s-unsplash-1.jpg" alt="Costa Rica Destinations" class="hero-image" />
                <div class="hero-text">
                    <h5><strong style="color: white;">¿Sabes cuales son los mejores destinos turisticos en Costa Rica?</strong></h5>
                </div>
                <nav class="navbar navbar-expand-lg navbar-light bg-custom2">
                </nav>
            </section>

            <%--Mostrar datos repetitivos, como una lista de elementos, El atributo ID es el identificador del control--%>
            <asp:Repeater ID="repResorts" runat="server">
                <HeaderTemplate>
                    <div class="container">
                        <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div id="cardResorts" class="card">
                        <br>
                        <h5 class="strong" style="font-weight: bold; text-align: center; font-family: Georgia; font-size: 15px"><%# Eval("Name")%></h5>
                        <img src="<%# Eval("Photo")%>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <p class="card-text" style="text-align: justify; overflow-y: hidden;"><%# Eval("Description")%></p>
                            <div class="precio">
                                <strong style="font-weight: bold;">Precio: ₡</strong><%# Eval("Price")%>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>

