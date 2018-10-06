<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Capa_Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SemiFutbol - Registrarse</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <header>
            <h1>SEMIFUTBOL</h1>
        </header>

        <nav>
            <ul>
                <li> <a href="Login.aspx">Iniciar sesion</a></li>
                <li> <a class="active" href="#">Registrate</a> </li>
            </ul>
        </nav>

        <div>
        <br />
        <asp:TextBox ID="txbxUsr" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Nombre de usuario<br />
        <br />
        <asp:TextBox ID="txbxPsw" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Contraseña<br />
        <br />
        <asp:TextBox ID="txbxConPsw" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Confirmar contraseña<br />
        <br />
        <asp:TextBox ID="txbxMail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; E-mail<br />
        <br />
        <p>
            <asp:Button ID="ButtonRegister" runat="server" OnClick="Button1_Click1" Text="Registrarme" />
        </p>
    </div>
    </form>

    <footer>
        © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
    </footer>


    </body>
</html>
