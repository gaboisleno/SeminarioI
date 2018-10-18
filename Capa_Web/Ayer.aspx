<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ayer.aspx.cs" Inherits="Capa_Web.Ayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>SemiFutbol - Ayer</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header><h1>SEMIFUTBOL</h1></header>
                <nav>   
            <ul>
                <li><a href="Menu.aspx" runat="server">Todos</a></li>
                <li><a href="Hoy.aspx" runat="server">Hoy</a></li>
                <li><a href="Ayer.aspx" class="active"  runat="server">Ayer</a></li>
                <li><a href="Noticias.aspx">Noticias</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
        </nav>
        <div>
            <br />
            <br />
            <a href="Noticias.aspx">
            <asp:GridView ID="grdAyer" runat="server" HorizontalAlign="Center" OnSelectedIndexChanged="grdAyer_SelectedIndexChanged">
            </asp:GridView>
            </a>
        </div>
    </form>
    <footer></footer>
</body>
</html>
