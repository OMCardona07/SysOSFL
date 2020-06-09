<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="SysOSFL.GUID.Administrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        <div>
            <asp:Label Text="N° de identificacion" runat="server" />
            <asp:TextBox Id="txtId" runat="server" />
            <asp:Button Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlUsuarios">
            <asp:DataGrid ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="IdAdmin" >
                <Columns>
                    <asp:BoundColumn DataField="IdAdmin" HeaderText="Id" />
                    <asp:BoundColumn DataField="Nombres" HeaderText="Nombres" />
                    <asp:BoundColumn DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundColumn DataField="Dui" HeaderText="N° de Identificacion" />
                    <asp:BoundColumn DataField="Email" HeaderText="E-Mail" />
                    <asp:BoundColumn DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundColumn DataField="NomUsu" HeaderText="Nombre de Usuario" />
                    <asp:BoundColumn DataField="Pass" HeaderText="Contraseña" />
                    <asp:BoundColumn DataField="Credencial" HeaderText="Credencial" />
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:Button ID="btnDetalles" runat="server" OnClick="btnDetalles_Click" Text="Ver Detalles" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <ItemStyle BackColor="White" ForeColor="#003399" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            </asp:DataGrid>
        </asp:Panel>
        </div>
        <br />
        <br />
        <asp:TextBox class="controles" ID="txtIdAdmin" runat="server" placeholder="" ToolTip=""></asp:TextBox>
        <asp:TextBox class="controles" ID="txtNombre" runat="server" placeholder="Ingrese su nombre *" ToolTip="Este campo es obligatorio"></asp:TextBox>
        <asp:TextBox ID="txtApellidos" runat="server" placeholder="Ingrese su apellido *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtDui" runat="server" placeholder="Ingrese su número de DUI *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" class="controles"></asp:TextBox>
        <asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" class="controles"></asp:TextBox>
        <%--<input id="txtPass" type="password" placeholder="Ingrese su contraseña" class="controles"/>--%>
        <asp:Button class="btn" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
        <asp:Button class="btn" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click1" Text="Eliminar" />

    </section>

    
</asp:Content>


