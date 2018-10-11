<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPageEquipos.aspx.cs" Inherits="Capa_Web.AdminPageEquipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SemiFutbol - Admin Equipos</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <header>
            <h1>SEMIFUTBOL</h1>
        </header>

        <nav>   
            <ul>
                <li><a href="#" runat="server" onserverclick="GridPartidosAdmin">Partidos</a></li>
                <li><a class="active" href="AdminPageEquipos.aspx" >Equipos</a></li>
                <li><a href="#" runat="server" onserverclick="GridLigasAdmin">Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
        </nav>
        
        <div>
            Nuevo Equipo. Los campos * son obligatorios.<br />
        </div>
        Nombre del equipo (*)<br />
        <asp:TextBox ID="txbxEquipo" runat="server"></asp:TextBox>
        <br />
        Liga del Equipo (*)<br />
        <asp:DropDownList ID="DDListLiga" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Nuevo Equipo" OnClick="Button1_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" HorizontalAlign="Center">
        </asp:GridView>
    </form>

    <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
</body>
</html>
