<%@ Page Title="" Language="C#" MasterPageFile="~/MasterDonante.Master" AutoEventWireup="true" CodeBehind="Donaciones_d.aspx.cs" Inherits="SysOSFL.GUID.Donaciones_d" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        
        <div>
            <h4>HACER DONACIONES PARA PROYECTOS</h4>
            <br />
            <p><asp:Label Text="Codigo de proyecto" runat="server" /></p>            
            <asp:TextBox class="controles" Id="txtId" placeholder="Ingrese el codigo de proyecto" runat="server" />
            <asp:Button class="btn" Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlDonante">
            <asp:DataGrid ID="gvDonacion" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDonacion" >
                <Columns>
                    <asp:BoundColumn DataField="IdDonacion" HeaderText="Id" />
                    <asp:BoundColumn DataField="NombreEm" HeaderText="Nombre de Institucion" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="" />
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
        <asp:TextBox ID="txtIdDonacion" runat="server" placeholder="" class="controles"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtDonante" runat="server" placeholder="" class="controles"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtProyecto" runat="server" placeholder="" class="controles"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtMonto" runat="server" placeholder="Monto de la donacion" class="controles"></asp:TextBox>
        <br />
        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="Select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="Aceptado">Aceptado</asp:ListItem>
            <asp:ListItem Value="Rechazado">Rechazado</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button class="btn" ID="btnDonar" runat="server" OnClick="btnDonar_Click" Text="HACER DONACION" OnClientClick="return confirm(&quot;Realmente desea hacer la donacion?&quot;);" />
        

    </section>
</asp:Content>
