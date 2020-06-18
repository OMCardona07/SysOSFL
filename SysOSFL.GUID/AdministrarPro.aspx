<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AdministrarPro.aspx.cs" Inherits="SysOSFL.GUID.AdministrarPro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        <div>
            <asp:Label Text="Codigo de proyecto" runat="server" />
            <asp:TextBox Id="txtId" runat="server" />
            <asp:Button Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
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
        <asp:TextBox ID="txtId_pro" runat="server"></asp:TextBox>

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

        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Proyecto" />


        <br />
        <br />
        <br />
        <p>______________________________________________________</p>
        <h4>ACTUALIZAR TAREAS</h4>
        <asp:Panel runat="server" ID="Panel1">
            <asp:DataGrid ID="dgTareas" runat="server" AutoGenerateColumns="False" DataKeyNames="IdBitacora" >
                <Columns>
                    <asp:BoundColumn DataField="IdBitacora" HeaderText="Id" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="Proyecto" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="Nombre del la tarea" />
                    <asp:BoundColumn DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundColumn DataField="Fecha_ini" HeaderText="Fecha de inicio" />
                    <asp:BoundColumn DataField="Fecha_fin" HeaderText="Fecha de fin" />
                    <asp:BoundColumn DataField="Estado" HeaderText="Estado" />
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:Button ID="btnDeta_Ta" runat="server" OnClick="btnDeta_Ta_Click" Text="Ver Detalles" />
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

        

        <p><label for="">Id:</label></p>
        <asp:TextBox ID="txtId_tar" runat="server"></asp:TextBox>

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

        <asp:Button ID="btnModificar_tar" runat="server" OnClick="btnModificar_tar_Click" Text="Modificar Tarea" />

    </section>

</asp:Content>
