<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro_Proyectos.aspx.cs" Inherits="PruebaSistema.Interfaz.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div id="envoltura">
        <div id="contenedor">
 
            <div id="cuerpo">
 
                <form id="form1" runat="server">
                    <p><label for="NombreProyecto">Nombre del proyecto:</label></p>
                        <asp:TextBox ID="txtNombre_pro" runat="server"></asp:TextBox>
                    

                    <p><label for="TipoProyecto">Tipo de proyecto:</label></p>
                        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                    
 
                    <p><label for="IdProyecto">Codigo:</label></p>
                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>

                    <p><label for="ProgresoProyecto">Progreso :</label></p>
                        <asp:TextBox ID="txtProgreso" runat="server"></asp:TextBox>
 
                    <p id="bot">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
                          <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Modificar" />
                    </p>
                    
        
                      
                    
                </form>
            </div>
 
            <div id="pie">///////////</div>
        </div><!-- fin contenedor -->
 
    </div>
</body>
</html>