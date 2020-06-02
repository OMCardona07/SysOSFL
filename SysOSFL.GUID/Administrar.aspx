<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="SysOSFL.GUID.Administrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\estilos1.css"/>
    <section class="form-registro">
        <div>
            <asp:Label Text="N° de identificacion" runat="server" />
            <asp:TextBox Id="txtId" runat="server" />
            <asp:Button Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlUsuarios">
            <asp:DataGrid ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="IdAdmin">
                <Columns>
                    <asp:BoundColumn DataField="IdAdmin" HeaderText="Id" >
                        <HeaderStyle Width="10px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Nombres" HeaderText="Nombres" >
                        <HeaderStyle Width="20px" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundColumn DataField="Dui" HeaderText="N° de Identificacion" />
                    <asp:BoundColumn DataField="Email" HeaderText="E-Mail" />
                    <asp:BoundColumn DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundColumn DataField="NomUsu" HeaderText="Nombre de Usuario" />
                    <asp:BoundColumn DataField="Pass" HeaderText="Contraseña" />
                </Columns>
            </asp:DataGrid>
        </asp:Panel>
        </div>
        <br />
        <br />
        
    </section>
</asp:Content>
