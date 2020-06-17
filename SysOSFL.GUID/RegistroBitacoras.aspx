<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="RegistroBitacoras.aspx.cs" Inherits="SysOSFL.GUID.RegistroBitacoras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>

    
                   


                    <p><label for="CodigoProyecto">Codigo proyecto:</label></p>
                        <asp:TextBox ID="txtCodigo_pro" runat="server"></asp:TextBox>

                    <p><label for="CodigoBi">Codigo Bitacora:</label></p>
                        <asp:TextBox ID="txtCodigoBi" runat="server"></asp:TextBox>
                    

                    <p><label for="Descripcion">Descripcion:</label></p>
                        <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
                    
 
                    <p><label for="Fecha">Fecha:</label></p>
                        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>

                    




 
                    <p id="bot">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
                          
                        
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar" />
                        
                    </p>
                        <p><label for="CodigoProyecto">Codigo Bitacora:</label></p>
                        <asp:TextBox ID="txtEl" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />

                       <p><label for="CodigoProyecto">Codigo Proyecto:</label></p>
                        <asp:TextBox ID="textPro" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Buscar" />

                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>      



</asp:Content>
