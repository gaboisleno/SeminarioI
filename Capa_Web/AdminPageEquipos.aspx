<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPageEquipos.aspx.cs" Inherits="Capa_Web.AdminPageEquipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nuevo Equipo. Los campos * son obligatorios.<br />
        </div>
        Nombre del equipo (*)<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Liga del Equipo (*)<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add Team" />
        </p>
    </form>
</body>
</html>
