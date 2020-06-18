<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AdministrarDonacion.aspx.cs" Inherits="SysOSFL.GUID.AdministrarDonacion" %>
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
            <asp:Panel runat="server" ID="pnlDonante">
            <asp:DataGrid ID="gvDonacion" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDonacion" >
                <Columns>
                    <asp:BoundColumn DataField="IdDonacion" HeaderText="Id" />
                    <asp:BoundColumn DataField="NombreEm" HeaderText="Nombre de Institucion" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="N° de Identificacion" />
                    <asp:BoundColumn DataField="Monto" HeaderText="E-Mail" />
                    <asp:BoundColumn DataField="Estado" HeaderText="Telefono" />
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
        <asp:TextBox ID="txtIdDonacion" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="ddlDonante" runat="server" Height="30px" Width="250px" >
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList AutoPostBack="true" ID="ddlProyecto" runat="server" Height="30px" Width="250px" OnSelectedIndexChanged="ddlProyecto_SelectedIndexChanged" placeholder="--SELECCIONE UN PROYECTO--">
        </asp:DropDownList>
        <br />
        <br />
        <asp:TextBox ID="txtMonto" runat="server" placeholder="Ingrese su Correo electronico" class="controles"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="Select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="Aceptado">Aceptado</asp:ListItem>
            <asp:ListItem Value="Rechazado">Rechazado</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button class="btn" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
        <asp:Button class="btn" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" OnClientClick="return confirm(&quot;Realmente desea eliminar el registro&quot;);" />

    </section>
</asp:Content>
