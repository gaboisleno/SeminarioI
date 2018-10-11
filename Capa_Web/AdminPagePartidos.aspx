<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPagePartidos.aspx.cs" Inherits="Capa_Web.AdminPagePartidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert/Update/Delete Partidos<br />
            (Para INSERTAR complete todo)<br />
            (Para ACTUALIZAR complete todo)<br />
            (Para BORRAR, SOLO ingrese Local, Visitante y Fecha).<br />
            <br />
            A que Competicion pertenece el partido?<br />
            <asp:DropDownList ID="DDListLiga" runat="server" OnSelectedIndexChanged="DDListLiga_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Quien es el equipo
            Local? (*)</div>
        <asp:DropDownList ID="DDListLocal" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Quien es el equipo
        Visitante (*)<br />
        <asp:DropDownList ID="DDListVisitante" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Que
        Fecha es el partido? (*) (Formato AAAA-MM-DD)<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        En que
        Horario se juega?<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Cantidad de Goles Local<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Cantidad de Goles Visitante<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Aplicar" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
