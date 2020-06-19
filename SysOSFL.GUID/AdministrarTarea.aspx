<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AdministrarTarea.aspx.cs" Inherits="SysOSFL.GUID.AdministrarTarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        <h4>ACTUALIZAR TAREAS</h4>
        <div>
            <p><asp:Label Text="Codigo de proyecto" runat="server" /></p>            
            <asp:TextBox class="controles" Id="txtId" runat="server" />
            <asp:Button class="btn" Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="Panel1">
            <asp:DataGrid ID="dgTareas" runat="server" AutoGenerateColumns="False" DataKeyNames="IdBitacora" >
                <Columns>
                    <asp:BoundColumn DataField="IdBitacora" HeaderText="Id" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="Proyecto" />
                    <asp:BoundColumn DataField="Nombre_bi" HeaderText="Nombre del la tarea" />
                    <asp:BoundColumn DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundColumn DataField="Fecha_ini" HeaderText="Fecha de inicio" />
                    <asp:BoundColumn DataField="Fecha_fin" HeaderText="Fecha de fin" />
                    <asp:BoundColumn DataField="Estado" HeaderText="Estado" />
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

        <p><label for="">Id:</label></p>
        <asp:TextBox class="controles" ID="txtId_tar" runat="server"></asp:TextBox>

        <p><label for="">Proyecto:</label></p>
        <asp:DropDownList ID="ddlProyecto" runat="server" Height="30px" Width="250px">
        </asp:DropDownList>
        <br />
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

        <asp:DropDownList ID="ddlEstado" runat="server" Height="30px" Width="250px">
            <asp:ListItem Value="Select">--SELECCIONE UNA OPCION--</asp:ListItem>
            <asp:ListItem Value="En Espera">En Espera</asp:ListItem>
            <asp:ListItem Value="En Proceso">En Proceso</asp:ListItem>
            <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button class="btn" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="MODIFICAR TAREAS" />
    </section>
    
</asp:Content>
