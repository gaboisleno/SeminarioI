<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPageUsuarios.aspx.cs" Inherits="Capa_Web.AdminPageUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SemiFutbol - Admin Users</title>
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
                <li><a href="AdminPageLigas.aspx" >Ligas</a></li>
                <li><a href="#" class="active">Usuarios</a></li>
                <li style="float:right"><a href="#" runat="server" onserverclick="closeSession">Cerrar sesion</a></li>
            </ul>
    </nav>
        <div>
        </div>
         <br />
         <br />
         <br />
         <asp:RadioButton ID="rbtnAddAdmin" runat="server" Text="Conceder Admin" AutoPostBack="True" OnCheckedChanged="rbtnAddAdmin_CheckedChanged" />
         <asp:RadioButton ID="rbtnRmvAdmin" runat="server" Text="Quitar Admin" AutoPostBack="True" OnCheckedChanged="rbtnRmvAdmin_CheckedChanged" />
         <asp:RadioButton ID="rbtnRmvUser" runat="server" Text="Borrar Usuario" AutoPostBack="True" OnCheckedChanged="rbtnRmvUser_CheckedChanged" />
         <br />
         <br />
         <asp:TextBox ID="txbxId" placeholder="ID Usuario" runat="server"></asp:TextBox>
         <br />
         <asp:Button ID="btnEditUser" runat="server" Text="Aplicar" OnClick="btnEditUser_Click" style="height: 26px" />
         <br />
         <br />
        <br />
         <br />
         <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
         </asp:GridView>
    </form>

    <footer></footer>
</body>
</html>
