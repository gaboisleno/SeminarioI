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
            <br />
            Liga<br />
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Local (*)</div>
        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Visitante (*)<br />
        <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Fecha (*) (Formato AAAA-MM-DD)<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Horario<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Gol/es local<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Gol/es visitante<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Aplicar" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
