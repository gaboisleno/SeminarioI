<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPageLigas.aspx.cs" Inherits="Capa_Web.AdminPageLigas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SemiFutbol - Admin Ligas</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <header><H1>SEMIFUTBOL</H1></header>
        <nav>   
            <ul>
                <li><a href="AdminPage.aspx">Inicio</a></li>
                <li><a href="AdminPagePartidos.aspx" >Partidos</a></li>
                <li><a href="AdminPageEquipos.aspx" >Equipos</a></li>
                <li><a href="#" class="active" >Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                <li style="float:right"><a href="#">Cerrar sesion</a></li>
            </ul>
    </nav>
        
        
        <div>
            Nueva Liga. Los campos * son obligatorios</div>
        <br />
        <br />
        Nombre de la Liga/Copa (*)<br />
        <asp:TextBox ID="txbxLiga" runat="server"></asp:TextBox>
        <br />
        <br />
        Ultimo campeon (opcional)<br />
        <asp:DropDownList ID="DDListEquipos" runat="server" OnSelectedIndexChanged="DDListEquipos_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Añadir Liga" OnClick="Button2_Click" />
    </form>
</body>
</html>
