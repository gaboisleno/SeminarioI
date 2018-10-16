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
                <li><a href="AdminPageUsuarios.aspx">Usuarios</a></li>
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
        Ultimo campeon (opcional)<br />
        <asp:DropDownList ID="DDListEquipos" runat="server" OnSelectedIndexChanged="DDListEquipos_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Añadir Liga" OnClick="Button2_Click" />
        <br />
        <br />
        Cambiar Campeón de la Liga/Copa<br />
        <asp:TextBox ID="txbxUpdate" placeholder="ID Liga" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnNuevoCamp" runat="server" Text="Nuevo Campeón" OnClick="btnNuevoCamp_Click" />
        <br />
        <br />
        Borrar una Liga
        <br />
        <asp:TextBox ID="txbxDeleteLiga" placeholder="ID de la Liga" runat="server" OnTextChanged="txbxDeleteLiga_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btnDeleteLiga" runat="server" Text="Eliminar Liga" OnClick="btnDeleteLiga_Click" />
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
        </asp:GridView>
           <br />
    </form>

    <footer>© Copyright 2018 SemiFutbol® Todos los derechos reservados </footer>
</body>
</html>
