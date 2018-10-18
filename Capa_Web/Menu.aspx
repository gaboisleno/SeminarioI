﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capa_Web.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SemiFutbol - Home</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">
        <header>
           <h1>SEMIFUTBOL</h1> 
        </header>
    
    <nav>   
            <ul>
                <li><a href="#" class="active" runat="server">Todos</a></li>
                <li><a href="Hoy.aspx" runat="server">Hoy</a></li>
                <li><a href="Ayer.aspx" runat="server">Ayer</a></li>
                <li><a href="Noticias.aspx">Noticias</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
    </nav>

        <div>

    
            <br />
            <br />
            <asp:GridView ID="GridView1"  runat="server" BorderStyle="None" CellPadding="5" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>

            <br />

    
        </div>

        <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
    
    </form>
    </body>
</html>
