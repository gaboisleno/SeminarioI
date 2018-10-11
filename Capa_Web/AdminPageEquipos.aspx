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
                <li><a href="AdminPage.aspx">Inicio</a></li>
                <li><a href="AdminPagePartidos.aspx" >Partidos</a></li>
                <li><a class="active" href="AdminPageEquipos.aspx" >Equipos</a></li>
                <li><a href="AdminPageLigas.aspx">Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                
            </ul>
    </nav>
        
        <div>
            Nuevo Equipo. Los campos * son obligatorios.<br />
        </div>
        Nombre del equipo (*)<br />
        <asp:TextBox ID="txbxEquipo" runat="server"></asp:TextBox>
        <br />
        Liga del Equipo (*)<br />
        <asp:DropDownList ID="DDListLigas" runat="server" OnSelectedIndexChanged="DDListLigas_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Nuevo Equipo" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
            </asp:GridView>
        </p>

    </form>

    <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
</body>
</html>
