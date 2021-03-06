﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="AdministrarDonante.aspx.cs" Inherits="SysOSFL.GUID.AdministrarDonante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <link rel="stylesheet" href="CSS\EstilosBuscar.css"/>
    <section class="form-registro">
        <div>
            <h4>ACTUALIZACION DE DATOS DEL DONANTE</h4>
            <br />
            <p><asp:Label Text="N° de identificacion" runat="server" /></p>            
            <asp:TextBox class="controles" Id="txtId" runat="server" />
            <asp:Button class="btn" Id="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:Panel runat="server" ID="pnlDonante">
            <asp:DataGrid ID="gvDonante" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDonante" >
                <Columns>
                    <asp:BoundColumn DataField="IdDonante" HeaderText="Id" />
                    <asp:BoundColumn DataField="NombreEm" HeaderText="Nombre de Institucion" />
                    <asp:BoundColumn DataField="N_Emp" HeaderText="N° de Identificacion" />
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
        <asp:TextBox class="controles" ID="txtIdDonante" runat="server" placeholder="" ToolTip=""></asp:TextBox>
        <asp:TextBox class="controles" ID="txtNombreEm" runat="server" placeholder="Ingrese su nombre *" ToolTip=""></asp:TextBox>
        <asp:TextBox class="controles" ID="txtNrc" runat="server" placeholder="Ingrese su número de DUI *" ></asp:TextBox>
        <asp:TextBox class="controles" ID="txtEmail" runat="server" placeholder="Ingrese su Correo electronico" ></asp:TextBox>
        <asp:TextBox class="controles" ID="txtTelefono" runat="server" placeholder="Ingrese su número de telefono" ></asp:TextBox>
        <asp:TextBox class="controles" ID="txtNomUsu" runat="server" placeholder="Ingrese su nombre de usuario *" ></asp:TextBox>
        <asp:TextBox class="controles" ID="txtPass" runat="server" placeholder="Ingrese su nombre de contraseña *" ></asp:TextBox>
        <asp:TextBox class="controles" ID="txtCredencial" runat="server" ReadOnly="true"></asp:TextBox>
        <asp:Button class="btn" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="MODIFICAR" />
        <asp:Button class="btn" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="ELIMINAR" OnClientClick="return confirm(&quot;Realmente desea eliminar el registro&quot;);" />

    </section>
</asp:Content>
