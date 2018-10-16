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
                <li><a href="AdminPageUsuarios.aspx">Usuarios</a></li>
                
            </ul>
    </nav>
        
        <div>
            Nuevo Equipo. Los campos * son obligatorios.<br />
        </div>
        
        <br />
        
        <div>
            Nuevo Equipo (*)<br />
            <asp:TextBox ID="txbxEquipo" placeholder="Nombre" runat="server"></asp:TextBox>
            <br />
            Liga del Equipo (*)
            <br />
            
            <asp:DropDownList ID="DDListLigas" runat="server" OnSelectedIndexChanged="DDListLigas_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Nuevo Equipo" OnClick="Button1_Click" />
            <br />
            <br />
           
            Borrar Equipo<br />
            <asp:TextBox ID="txbxDelete" placeholder="ID del equipo" runat="server" OnTextChanged="txbxDelete_TextChanged1"></asp:TextBox> 
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Borrar Equipo" OnClick="btnDelete_Click1" />
            <br />
            <br />
            <br />
            Modificar Equipo<br />
            <asp:TextBox ID="txbxId" placeholder="ID del equipo" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txbxUpdate" placeholder="Nuevo Nombre" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Modificar Equipo" OnClick="btnUpdate_Click" />
            <br />
        </div>
        
        <div>
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </div>
            
  

    </form>

    <footer>
            © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
</body>
</html>
