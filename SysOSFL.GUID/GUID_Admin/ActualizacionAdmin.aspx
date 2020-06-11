<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizacionAdmin.aspx.cs" Inherits="SysOSFL.GUID.GUID_Admin.ActualizacionAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--<link href="../CSS/EstilosBuscar.css" rel="stylesheet" />--%>
    <link href="../CSS/EstilosRegistro.css" rel="stylesheet" />
    <%--<link href="../CSS/estilo_menuH.css" rel="stylesheet" />--%>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<%--        <nav><ul>
            <li><a href="#">Inicio</a></li>
            <li><a href="#">Registro de Datos</a>
                <ul><li><a href="RegistroAdmin.aspx">Registro Admin</a></li>
                <li><a href="RegistroJefe.aspx">Registro Jefes</a></li>
                <li><a href="RegistroDonante.aspx">Registro Donantes</a></li></ul>
            </li>
            
            <li><a href="#">Actualizar de Datos</a>
                <ul><li><a href="ActualizacionAdmin.aspx">Actualizar Admin</a></li>
                <li><a href="#">Actualizar Donante</a></li></ul>
            </li>
            <li><a href="#">Proyectos</a>
                <ul><li><a href="#">Agregar Proyecto</a></li></ul>
            </li>
            <li><a href="#">Contacto</a></li>
            </ul></nav>
        <br />
        <br />--%>
 
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
        <asp:Button class="btn" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />

    </section>
    </form>
</body>
</html>
