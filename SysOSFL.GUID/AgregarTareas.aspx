<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarTareas.aspx.cs" Inherits="SysOSFL.GUID.AgregarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>

    <section class="form-registro">
        <h4>AGREGAR TAREAS AL PROYECTO</h4>
        <p><label for="">Proyecto:</label></p>
        <asp:DropDownList ID="ddlProyecto" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>

        
        <p><label for="">Nombre:</label></p>
        <asp:TextBox ID="txtNombre_ta" runat="server"></asp:TextBox>
                    
 
        <p><label for="">Descripcion :</label></p>
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>

        <p><label for="">Fecha de inicio :</label></p>
        <asp:TextBox ID="txtFechaIni" runat="server"></asp:TextBox>

        <p><label for="">Fecha de Finalizacion :</label></p>
        <asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox>

        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
            <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="btnGuardarPro" runat="server" OnClick="btnGuardarPro_Click" Text="Guardar Proyecto" />
    </section>
    

</asp:Content>
