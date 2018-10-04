<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Capa_Web.Menu" %>

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
                <li><a class="active" href="#">Hoy</a></li>
                <li><a href="#">Ayer</a></li>
                <li><a href="#">Noticias</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
    </nav>

        <div>
            <table align="center" style="width:50%">
                <tr>
                    <th>Fecha</th>
                    <th>Local</th>
                    <th>Goles L</th>
                    <th>Goles V</th>
                    <th>Visitante</th>
                    <th>Liga/Copa</th>
                </tr>
                <tr>
                    <td>30/09</td>
                    <td>Union</td>
                    <td>1</td>
                    <td>0</td>
                    <td>Gimnasia</td>
                    <td>SuperLiga</td>
                </tr>
                <tr>
                    <td>30/09</td>
                    <td>Belgrano</td>
                    <td>0</td>
                    <td>1</td>
                    <td>Huracan</td>
                    <td>SuperLiga</td>
                </tr>
             
            </table>

        </div>

        <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
    
        <asp:GridView ID="grdPartidos" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    
    </form>
    </body>
</html>
