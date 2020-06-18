<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarDonacion.aspx.cs" Inherits="SysOSFL.GUID.AgregarDonacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS\EstilosRegistro.css"/>
    <section class="form-registro">
        <h4>REGISTRO DE DONACIONES</h4>
        <h3>* Campos obligatorios</h3>
        <br />
        <br />
        <asp:DropDownList ID="ddlDonante" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>
        <asp:DropDownList AutoPostBack="true" ID="ddlProyecto" runat="server" Height="30px" Width="250px" OnSelectedIndexChanged="ddlProyecto_SelectedIndexChanged" placeholder="--SELECCIONE UN PROYECTO--">
        </asp:DropDownList>
        <asp:TextBox ID="txtMonto" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="Select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="Aceptado">Aceptado</asp:ListItem>
            <asp:ListItem Value="Rechazado">Rechazado</asp:ListItem>
        </asp:DropDownList>
        <asp:Button class="btn" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </section>
</asp:Content>
