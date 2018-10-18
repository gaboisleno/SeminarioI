<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="Capa_Web.Noticias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SEMIFUTBOL - NOTICIAS</title>
        <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header><H1>SEMIFUTBOL</H1></header>
    <form id="form1" runat="server">
            <nav>   
            <ul>
                <li><a href="Menu.aspx" runat="server">Todos</a></li>
                <li><a href="Hoy.aspx" runat="server">Hoy</a></li>
                <li><a href="Ayer.aspx" runat="server">Ayer</a></li>
                <li><a href="#" class="active">Noticias</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
    </nav>
        <div>
            <p>
                <h3>"Gallardo va a seguir en River"</h3>
                D'Onofrio buscó sacarle ruido al "nada dura para siempre" del Muñeco y no dudó sobre su continuidad. Y lo ve en el club hasta el 2021. ¿Será así?
                "Se hicieron interpretaciones que se pueden hacer pero que no condicen con la realidad. Gallardo va a seguir en River, es parte de un proyecto integral. Un proyecto que él quiere hacer y que nosotros estamos felices de que él lo haga".
            </p>
        </div>



    </form>

    <footer></footer>
</body>
</html>
