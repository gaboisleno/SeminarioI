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
                <li><a href="AdminPageLigas.aspx">Ligas</a></li>
                <li><a href="#">Usuarios</a></li>
                <li style="float:right"><a href="#">Cerrar sesion</a></li>
            </ul>
    </nav>

        <div>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="32px">
                <asp:RadioButton ID="rbtnInsert" runat="server" Checked="True" Text="Nuevo Partido" />
                <asp:RadioButton ID="rbtnUpdate" runat="server" Text="Modificar Partido" />
                <asp:RadioButton ID="rbtnDelete" runat="server" Text="Eliminar Partido" />
            </asp:Panel>
        </div>
            A que Competicion pertenece el partido?<br />
            <asp:DropDownList ID="DDListLigas" runat="server" OnSelectedIndexChanged="DDListLiga_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Quien es el equipo
            Local? (*)<br />
        <asp:DropDownList ID="DDListLocal" runat="server" OnSelectedIndexChanged="DDListLocal_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Quien es el equipo
        Visitante (*)<br />
        <asp:DropDownList ID="DDListVisitante" runat="server" OnSelectedIndexChanged="DDListVisitante_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
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
        <asp:Button ID="Button2" runat="server" Text="Aplicar" OnClick="Button2_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
