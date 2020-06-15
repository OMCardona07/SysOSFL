<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="ControlProyectos.aspx.cs" Inherits="SysOSFL.GUID.ControlProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>

                    <p><label for="NombreProyecto">Nombre del proyecto:</label></p>
                        <asp:TextBox ID="txtNombre_pro" runat="server"></asp:TextBox>
                    

                    <p><label for="TipoProyecto">Tipo de proyecto:</label></p>
                        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                    
 
                    <p><label for="IdProyecto">Codigo:</label></p>
                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>

                    <p><label for="ProgresoProyecto">Progreso :</label></p>
                        <asp:TextBox ID="txtProgreso" runat="server"></asp:TextBox>
               <asp:Button ID="btn" Text="Hola" runat="server" />


                         <p><label for="PresupuestoProyecto">Presupuesto :</label></p>
                        <asp:TextBox ID="txtPresupuesto" runat="server"></asp:TextBox>

                      <p><label for="JefeProyecto">Jefe Proyecto :</label></p>
                        <asp:TextBox ID="txtJefe" runat="server"></asp:TextBox>

 
                    <p id="bot">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
                          <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar" />

                         <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Buscar" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar" />
                    </p>
                    
                  <asp:GridView ID="GridView1" runat="server"></asp:GridView>

</asp:Content>
