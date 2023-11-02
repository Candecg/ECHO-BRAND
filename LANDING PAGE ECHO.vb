<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ECHO</title>

    <style>
        /* Configuración de estilos para el cuerpo de la página */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #6D996B;
        }
        /* Configuración de estilos para el encabezado de la página */
        header {
            background-color: #6D996B;
            color: #000000;
            text-align: center;
            padding: 0.5em;
        }
        /* Configuración de estilos para la barra de navegación de la página */
        nav {
            display: flex;
            justify-content: center;
            background-color: #000000;
            padding: 0.5em;
        }
        /* Configuración de estilos para los enlaces de la barra de navegación de la página */
        nav a {
            color: #fff;
            text-decoration: none;
            margin: 0 1em;
        }
        /* Configuración de estilos para el contenedor principal */
        .container {
            display: flex;
            flex-wrap: wrap;
        }
        /* Configuración de estilos para el contenido principal */
        .main-content {
            flex: 1;
        }
        /* Configuración de estilos para las secciones */
        section {
            margin: 20px;
            padding: 20px;
            background-color: #fff;
            flex: 1;
        }
        /* Configuración de estilos para la barra lateral */
        aside {
            font-size: 80%;
            flex-basis: 15%;
            height: 800px;
            margin: 10px;
            padding: 50px;
            background-color: #ffffff;
        }
        /* Configuración de estilos para el pie de página */
        footer {
            background-color: #333;
            color: #fff;
            text-align: center;
            padding: 1em;
            position: relative;
            bottom: 0;
            width: 100%;
        }
        @media (max-width: 768px) {
            /* Cambiar la dirección del contenedor en dispositivos móviles */
            .container {
                flex-direction: column;
            }
            /* Ancho comleto para la barra lateral en dispositivos móviles */
            aside {
                flex-basis: 100%;
            }
        }

    </style>
</head>
<body>
    <header role="banner">
        <img src="IMATGES%20LANDING%20PAGE/LOGO.PNG" alt="Logo ECHO" height="200" width="200">
    </header>
    <nav role="navigation">
        <a href="#inicio">Inicio</a>
        <a href="#Servicios">Servicios</a>
        <a href="#footer">Contacto</a>
    </nav>
    <div class="container">
        <div class="main-content" role="main">
            <section id="inicio" aria-label="Sección de Inicio">
                <h2>Bienvenido a ECHO</h2>
                <p>En ECHO buscamos que nuestros clientes se sumen a nuestra causa, para conseguir eso, queremos promocionar una visión de la moda sostenible y ética, con prendas de ropa fabricadas a partir de materiales reciclados.</p>
            </section>
            <section id="Servicios" aria-label="Sección de Servicios">
                <h2>Servicios</h2>
                <img src="IMATGES%20LANDING%20PAGE/cart.png" alt="Icono carro de la compra" height="20" width="20">
                <h3>Productos</h3>
                <p>Disponemos de diferentes prendas de ropa</p>
                <img src="IMATGES%20LANDING%20PAGE/PRENDA_1.PNG" alt="Sudadera 1" height="200" width="200">    
                <img src="IMATGES%20LANDING%20PAGE/PRENDA_2.PNG" alt="Sudadera 2" height="200" width="200">    
                <img src="IMATGES%20LANDING%20PAGE/PRENDA_3.PNG" alt="Sudadera 3" height="200" width="200">    

                <h3>Zona Verde</h3>    
                <p>La Zona Verde es un lugar de recogida de ropa vieja que más adelante se podrá usar para hacer otras prendas. Queremos dar a nuestros clientes una alternativa para cuando tengan prendas que ya no se ponen o están en mal estado. Cada lunes de cada mes estaremos en la Plaça Sant Joan del Carrer Major de Lleida para poder recaudar la mayor cantidad de ropa posible. A cambio, nuestros clientes podrán recibir merchandising de nuestra marca y descuentos para nuestros productos.</p>
                <img src="IMATGES%20LANDING%20PAGE/donar.png" alt="Donar ropa" height="100" width="200">
            </section>
        </div>
        <aside role="complementary">
            <h3>¡ESTAMOS COMPROMETIDOS!</h3>
            <div class="card" style="width: 18rem;">
                <img src="IMATGES%20LANDING%20PAGE/RRR.png" class="card-img-top" alt="Reutilizar, Reducir, Reciclar"><br><br>
                <div class="card-body">
                    <p class="card-text">Infórmate aquí sobre lo que son las 3 Rs</p><br><br>
                    <a href="https://www.heritage-enviro.com/news/the-3-rs-of-solid-waste-management/" class="btn btn-primary stretched-link">VAMOS</a>
                </div>
            </div>
            <br><br><br><br><br><br>
            <div class="card" style="width: 18rem;">
                <img src="IMATGES%20LANDING%20PAGE/ONU.png" class="card-img-top" alt="Símbolo de la ONU"><br><br><br><br><br><br>
                <div class="card-body">
                    <p class="card-text">Esto es un ejemplo de lo que pasa por la sobreproducción de ropa, la mayoría de las prendas son de baja calidad, fabricadas con fibras sintéticas o mezcladas con productos químicos, que liberan contaminantes en el aire, el suelo y el agua, perjudicando al medio ambiente y a las comunidades locales.</p><br>
                    <a href="https://news.un.org/es/story/2023/05/1521102" class="btn btn-primary stretched-link">VAMOS</a>
                </div>
            </div>  
            <br><br><br>
            <h3>Web Map</h3>
            <ul>
                <li><a href="#inicio">Quienes somos</a></li>
                <li><a href="#Servicios">Servicios</a></li>
                <li><a href="#footer">Contacto</a></li>
                <li><a href="#Servicios">Zona verde</a></li>
                <li><a href="#Servicios">Productos</a></li>
            </ul>
        </aside>
    </div>
    <footer role="contentinfo">
        <a href="#inicio">Inicio</a> |
        <a href="#Servicios">Servicios</a> |
        <a href="#footer">Contacto</a>
        <br>
        Mapa del sitio: <a href="#mapa">Mapa Web</a>
        <br>
        Datos de contacto: contacto@echo.com | Teléfono: 636736101 <img src="IMATGES%20LANDING%20PAGE/phone-call.png" alt="Icono telefono" height="20" width="20">
    </footer>
</body>
</html>