<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarAdministrador.aspx.cs" Inherits="SysOSFL.GUID.AgregarAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Select1 {
            width: 106px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS\EstilosRegistro.css"/>
    <section class="form-registro">
        <h4>FORMULARIO REGISTRO</h4>
        <h3>* Campos obligatorios</h3>
        <br />
        <br />
        <asp:TextBox class="controles" ID="txtNombre" runat="server" placeholder="Ingrese su nombre *" ToolTip="Este campo es obligatorio"></asp:TextBox>
        <asp:TextBox ID="txtApellidos" runat="server" placeholder="Ingrese su apellido *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtDui" runat="server" placeholder="Ingrese su número de DUI *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" class="controles" TextMode="Password"></asp:TextBox>
        <%--<input id="txtPass" type="password" placeholder="Ingrese su contraseña" class="controles"/>--%>
        <asp:DropDownList ID="ddCredencial" runat="server" Height="24px" Width="177px">
            <asp:ListItem Value="Administador">Administrador</asp:ListItem>
            <asp:ListItem Value="Jefe de Proyecto">Jefe de Proyecto</asp:ListItem>
        </asp:DropDownList>
        <asp:Button class="btn" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </section>
</asp:Content>
