<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AgregarTareas.aspx.cs" Inherits="SysOSFL.GUID.AgregarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosRegistroUsu.css"/>

    <section class="form-registro">
        <h4>AGREGAR TAREAS AL PROYECTO</h4>
        <asp:DropDownList ID="ddlProyecto" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>
        <br />
        
        <p><label for="">Nombre:</label></p>
        <asp:TextBox class="controles" ID="txtNombre_ta" runat="server"></asp:TextBox>
                    
 
        <p><label for="">Descripcion :</label></p>
        <asp:TextBox class="controles" ID="txtDesc" runat="server"></asp:TextBox>

        <p><label for="">Fecha de inicio :</label></p>
        <asp:TextBox class="controles" ID="txtFechaIni" runat="server"></asp:TextBox>

        <p><label for="">Fecha de Finalizacion :</label></p>
        <asp:TextBox class="controles" ID="txtFechaFin" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
            <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
        </asp:DropDownList>

        <asp:Button class="btn" ID="btnGuardarPro" runat="server" OnClick="btnGuardarPro_Click" Text="GUARDAR TAREA" />
    </section>
    

</asp:Content>
