<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="SysOSFL.GUID.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS\EstilosLogIn.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="form-registro">
        <h4>INICIO DE SESION</h4>
        <br />
        <br />
        <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" class="controles" TextMode="Password"></asp:TextBox>
        <asp:DropDownList ID="ddCredencial" runat="server" Height="24px" Width="177px">
            <asp:ListItem Value="Administador">Administrador</asp:ListItem>
            <asp:ListItem Value="Jefe de Proyecto">Jefe de Proyecto</asp:ListItem>
            <asp:ListItem Value="Donante">Donante</asp:ListItem>
        </asp:DropDownList>
        <asp:Button class="btn" ID="btnIniciar" runat="server" OnClick="btnIniciar_Click" Text="Iniciar Sesion" />
    </section>
    </form>
</body>
</html>
