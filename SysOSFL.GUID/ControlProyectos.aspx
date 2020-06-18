<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="ControlProyectos.aspx.cs" Inherits="SysOSFL.GUID.ControlProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>

    <section class="form-registro">
        <h4>REGISTRO DE PROYECTO</h4>
        <p><label for="">Codigo de Proyecto:</label></p>
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>

        <p><label for="">Nombre del proyecto:</label></p>
        <asp:TextBox ID="txtNombre_pro" runat="server"></asp:TextBox>
                    

        <p><label for="">Tipo de proyecto:</label></p>
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                    
 
        <p><label for="">Presupuesto :</label></p>
        <asp:TextBox ID="txtPresupuesto" runat="server"></asp:TextBox>

        <p><label for="">Jefe Proyecto :</label></p>
        <asp:DropDownList ID="ddlJefe" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>

        <p><label for="">Progreso :</label></p>
        <asp:TextBox ID="txtProgreso" runat="server"></asp:TextBox>


        <p id="bot">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar" />

            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Buscar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar" />
        </p>
                    
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <p>__________________________________________________________________</p>
        <br />
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
