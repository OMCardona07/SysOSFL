<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AdministrarProyecto.aspx.cs" Inherits="SysOSFL.GUID.AdministrarProyecto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        <h4>ACTUALIZAR PROYECTOS</h4>
        <div>
            <p><asp:Label Text="Codigo de proyecto" runat="server" /></p>
            <asp:TextBox class="controles" Id="txtId" runat="server" />
            <asp:Button class="btn" Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlUsuarios">
            <asp:DataGrid ID="dgProyectos" runat="server" AutoGenerateColumns="False" DataKeyNames="IdProyecto" >
                <Columns>
                    <asp:BoundColumn DataField="IdProyecto" HeaderText="Id" />
                    <asp:BoundColumn DataField="Codigo_pro" HeaderText="Codigo" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="Nombre del proyecto" />
                    <asp:BoundColumn DataField="Tipo_pro" HeaderText="Tipo de proyecto" />
                    <asp:BoundColumn DataField="Presupuesto" HeaderText="Presupuesto" />
                    <asp:BoundColumn DataField="Jefe" HeaderText="Jefe de Proyecto" />
                    <asp:BoundColumn DataField="Progreso_pro" HeaderText="Progreso del proyecto" />
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
        <p><label for="">Id Proyecto:</label></p>
        <asp:TextBox class="controles" ID="txtId_pro" runat="server"></asp:TextBox>

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

        <p><label for="">Progreso :</label></p>
        <asp:TextBox class="controles" ID="txtProgreso" runat="server"></asp:TextBox>

        <asp:Button class="btn" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="MODIFICAR PROYECTO" />
        <asp:Button class="btn" ID="btnAcTarea" runat="server" OnClick="btnAcTarea_Click" Text="ACTUALIZAR TAREAS" />

    </section>

</asp:Content>
