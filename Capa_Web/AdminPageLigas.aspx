<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPageLigas.aspx.cs" Inherits="Capa_Web.AdminPageLigas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nueva Liga. Los campos * son obligatorios</div>
        <br />
        Nombre de la Liga/Copa (*)<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Ultimo campeon (opcional)<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add League" />
    </form>
</body>
</html>
