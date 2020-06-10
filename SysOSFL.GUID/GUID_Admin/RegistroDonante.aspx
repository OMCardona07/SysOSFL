<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroDonante.aspx.cs" Inherits="SysOSFL.GUID.GUID_Admin.RegistroDonante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../CSS/estilo_menuH.css" rel="stylesheet" />
    <link href="../CSS/EstilosRegistro.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <nav><ul>
            <li><a href="#">Inicio</a></li>
            <li><a href="#">Registro de Datos</a>
                <ul><li><a href="RegistroAdmin.aspx">Registro Admin</a></li>
                <li><a href="RegistroJefe.aspx">Registro Jefes</a></li>
                <li><a href="RegistroDonante.aspx">Registro Donantes</a></li></ul>
            </li>
            
            <li><a href="#">Actualizar de Datos</a>
                <ul><li><a href="#">Actualizar Usuario</a></li>
                <li><a href="#">Actualizar Donante</a></li></ul>
            </li>
            <li><a href="#">Proyectos</a>
                <ul><li><a href="#">Agregar Proyecto</a></li></ul>
            </li>
            <li><a href="#">Contacto</a></li>
            </ul></nav>

            <section class="form-registro">
        <h4>REGISTRO DE DONANTES</h4>
        <h3>* Campos obligatorios</h3>
        <br />
        <asp:TextBox class="controles" ID="txtNombre" runat="server" placeholder="Ingrese su nombre de la empresa *" ToolTip="Este campo es obligatorio"></asp:TextBox>
        <asp:TextBox ID="txtNrc" runat="server" placeholder="Ingrese su número de Identificacion *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" class="controles" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtCredencial" runat="server" class="controles"></asp:TextBox>
        <asp:Button class="btn" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </section>
    </form>
</body>
</html>
