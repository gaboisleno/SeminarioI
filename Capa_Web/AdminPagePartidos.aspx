<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPagePartidos.aspx.cs" Inherits="Capa_Web.AdminPagePartidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SemiFutbol - Admin Partidos</title>
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
                <li><a class="active" href="AdminPagePartidos.aspx" >Partidos</a></li>
                <li><a href="AdminPageEquipos.aspx" >Equipos</a></li>
                <li><a href="#">Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                <li style="float:right"><a href="#">Cerrar sesion</a></li>
            </ul>
    </nav>

        <div>
            Insert/Update/Delete Partidos<br />
            (Para INSERTAR complete todo)<br />
            (Para ACTUALIZAR complete todo)<br />
            (Para BORRAR, SOLO ingrese Local, Visitante y Fecha).<br />
            <br />
            A que Competicion pertenece el partido?<br />
            <asp:DropDownList ID="DDListLigas" runat="server" OnSelectedIndexChanged="DDListLiga_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Quien es el equipo
            Local? (*)</div>
        <asp:DropDownList ID="DDListLocal" runat="server" OnSelectedIndexChanged="DDListLocal_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Quien es el equipo
        Visitante (*)<br />
        <br />
        <asp:DropDownList ID="DDListVisitante" runat="server" OnSelectedIndexChanged="DDListVisitante_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        Que
        Fecha es el partido? (*) (Formato AAAA-MM-DD)<br />
        <asp:TextBox ID="txbxFecha" runat="server"></asp:TextBox>
        <br />
        <br />
        En que
        Horario se juega?<br />
        <asp:TextBox ID="txbxHorario" runat="server"></asp:TextBox>
        <br />
        <br />
        Cantidad de Goles Local<br />
        <asp:TextBox ID="txbxGolLocal" runat="server"></asp:TextBox>
        <br />
        <br />
        Cantidad de Goles Visitante<br />
        <asp:TextBox ID="txbxGolVisitante" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Aplicar" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
