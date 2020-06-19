<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="RegistroDondante.aspx.cs" Inherits="SysOSFL.GUID.RegistroDondante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS\EstilosRegistroUsu.css"/>
    <section class="form-registro">
        <h4>REGISTRO DE DONANTES</h4>
        <h3>* Campos obligatorios</h3>
        <br />
        <br />
        <asp:TextBox class="controles" ID="txtNombreEm" runat="server" placeholder="Ingrese el nombre de la empresa *" ToolTip="Este campo es obligatorio"></asp:TextBox>
        <asp:TextBox ID="txtNrc" runat="server" placeholder="Ingrese su número de identificacion *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" class="controles" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtCredencial" runat="server" class="controles" ReadOnly="true"></asp:TextBox>
        <asp:Button class="btn" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR" />
    </section>
</asp:Content>
