<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="ControlProyectos.aspx.cs" Inherits="SysOSFL.GUID.ControlProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosRegistroUsu.css"/>

    <section class="form-registro">
        <h4>REGISTRO DE PROYECTO</h4>
        <p><label for="">Codigo de Proyecto:</label></p>
        <asp:TextBox class="controles" ID="txtCodigo" runat="server"></asp:TextBox>

        <p><label for="">Nombre del proyecto:</label></p>
        <asp:TextBox class="controles" ID="txtNombre_pro" runat="server"></asp:TextBox>
                    

        <p><label for="">Tipo de proyecto:</label></p>
        <asp:TextBox class="controles" ID="txtTipo" runat="server"></asp:TextBox>
                    
 
        <p><label for="">Presupuesto :</label></p>
        <asp:TextBox class="controles" ID="txtPresupuesto" runat="server"></asp:TextBox>

        <p><label for="">Jefe Proyecto :</label></p>
        <asp:DropDownList ID="ddlJefe" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <p><label for="">Progreso :</label></p>
        <asp:TextBox class="controles" ID="txtProgreso" runat="server"></asp:TextBox>

        <asp:Button class="btn" ID="Button1" runat="server" OnClick="Button1_Click" Text="GUARDAR PROYECTO" />
        <asp:Button class="btn" ID="btnAgregarTarea" runat="server" OnClick="btnAgregarTarea_Click" Text="AGREGAR TAREA" />

    </section>

</asp:Content>
