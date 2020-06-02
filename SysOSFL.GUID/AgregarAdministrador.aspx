<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarAdministrador.aspx.cs" Inherits="SysOSFL.GUID.AgregarAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <section class="form-registro">
            <h4>FORMULARIO REGISTRO</h4>
            <h3>* Campos obligatorios</h3>
            <br />
            <h5>*</h5>
            <asp:TextBox class="controles" ID="txtNombre" runat="server" placeholder="Ingrese su nombre" ToolTip="Este campo es obligatorio"></asp:TextBox>
            <h5>*</h5>
            <asp:TextBox ID="txtApellidos" runat="server" placeholder="Ingrese su apellido" class="controles"></asp:TextBox>
            <h5>*</h5>
            <asp:TextBox ID="txtDui" runat="server" placeholder="Ingrese su número de DUI" class="controles"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
            <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" class="controles"></asp:TextBox>
            <h5>*</h5>
            <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario" class="controles"></asp:TextBox>
            <h5>*</h5>
            <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña" class="controles" TextMode="Password"></asp:TextBox>
            <%--<input id="txtPass" type="password" placeholder="Ingrese su contraseña" class="controles"/>--%>
            <%--<asp:Button class="btn" ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />--%>
    </section>
</asp:Content>
