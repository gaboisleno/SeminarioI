<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Capa_Web.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SemiFutbol - Admin Home</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <header>
            <h1>SEMIFUTBOL</h1>
        </header>
        
        <nav>   
            <ul>
                <li><a class="active" href="#">Partidos</a></li>
                <li><a href="#">Equipos</a></li>
                <li><a href="#">Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                <li style="float:right"><a href="Login.aspx">Cerrar sesion</a></li>
            </ul>
    </nav>
        <div>
            <p>
                Tabla de edicion de partidos(Insert/Update/Delete)
            </p>

        </div>

        <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
    </form>
</body>
</html>
