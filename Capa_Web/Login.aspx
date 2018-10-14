<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capa_Web.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SemiFutbol - LogIn</title>
    <link href="Css/Style.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">
        
        <header>
           <h1>SEMIFUTBOL</h1> 
        </header>
        
        <nav>   
            <ul>
                <li> <a class="active" href="#">Iniciar sesion</a></li>
                <li> <a  href="Register.aspx">Registrate</a> </li>
            </ul>
        </nav>
    
        <div>
            <br />
                <br />
                <asp:TextBox ID="txbxUsr" placeholder="Usuario" runat="server" OnTextChanged="txbxUsr_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txbxPsw" placeholder="Contraseña" runat="server"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="Button1_Click" />
            <br /> 
        
            <p>Puedes registrarte haciendo clic <a href="Register.aspx"><strong>Acá</strong></a></p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>  
    
        <div>


        </div>


        <footer>
            &nbsp; © Copyright 2018 SemiFutbol® <span>Todos los derechos reservados</span>
        </footer>
    </form>    
</body>        
   
</html>
