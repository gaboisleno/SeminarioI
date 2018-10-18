﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hoy.aspx.cs" Inherits="Capa_Web.Hoy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>SemiFutbol - Hoy</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header><h1>SEMIFUTBOL</h1></header>
        <nav>   
            <ul>
                <li><a href="Menu.aspx" runat="server">Todos</a></li>
                <li><a href="Hoy.aspx" class="active" runat="server">Hoy</a></li>
                <li><a href="Ayer.aspx" runat="server">Ayer</a></li>
                <li><a href="Noticias.aspx">Noticias</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
        </nav>
        <div>
            <br />
        </div>
        <asp:GridView ID="grdHoy" runat="server" HorizontalAlign="Center" OnSelectedIndexChanged="grdHoy_SelectedIndexChanged">
        </asp:GridView>
    </form>
    <footer></footer>
</body>
</html>
