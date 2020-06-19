<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarDonacion.aspx.cs" Inherits="SysOSFL.GUID.AgregarDonacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS\EstilosRegistroUsu.css"/>
    <section class="form-registro">
        <h4>REGISTRO DE DONACIONES</h4>
        <h3>* Campos obligatorios</h3>
        <br />
        <br />
        <asp:DropDownList ID="ddlDonante" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList AutoPostBack="true" ID="ddlProyecto" runat="server" Height="30px" Width="250px" OnSelectedIndexChanged="ddlProyecto_SelectedIndexChanged" placeholder="--SELECCIONE UN PROYECTO--">
        </asp:DropDownList>
        <br />
        <br />
        <asp:TextBox ID="txtMonto" runat="server" placeholder="Monto a solicitar" class="controles"></asp:TextBox>
        <br />
        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="Select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="Aceptado">Aceptado</asp:ListItem>
            <asp:ListItem Value="Rechazado">Rechazado</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button class="btn" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR" />
    </section>
</asp:Content>
