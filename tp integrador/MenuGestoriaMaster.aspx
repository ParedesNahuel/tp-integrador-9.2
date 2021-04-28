<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGestorMaster.aspx.cs" Inherits="tp_integrador.MenuGestorMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style18 {
            width: 174px;
            height: 119px;
        }
        .auto-style20 {
            width: 164px;
            height: 119px;
            font-size: x-large;
        }
        .auto-style21 {
            width: 325px;
            height: 119px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style11 {
            width: 174px;
        }
        .auto-style14 {
            width: 164px;
        }
        .auto-style15 {
            width: 325px;
        }
        .auto-style22 {
            height: 45px;
            width: 174px;
        }
        .auto-style24 {
            height: 45px;
            width: 164px;
        }
        .auto-style25 {
            width: 325px;
            height: 45px;
        }
        .auto-style26 {
            height: 46px;
            width: 174px;
        }
        .auto-style28 {
            height: 46px;
            width: 164px;
        }
        .auto-style29 {
            width: 325px;
            height: 46px;
        }
        .auto-style32 {
            width: 307px;
            height: 45px;
        }
        .auto-style33 {
            height: 45px;
        }
        .auto-style31 {
            width: 100%;
            margin-top: 6px;
        }
        .auto-style30 {
            width: 307px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style20"><strong>Menu Gestor<br />
                    Master</strong></td>
                <td class="auto-style21">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style4" Height="350px" ImageUrl="~/Imagenes/logo.auto1.jpeg" Width="349px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Bienvenido/a:<asp:Label ID="LblNombreGestorMaster" runat="server"></asp:Label>
&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:HyperLink ID="HLGestoresActivos" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/ListaDeGestores.aspx">Lista de Gestores Activos</asp:HyperLink>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:HyperLink ID="HLlistacliente" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/ListaClientes.aspx">Lista de Clientes</asp:HyperLink>
                </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style25">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:HyperLink ID="HLListaFormulariosxGestor" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/ListaFormulariosPorGestores.aspx">Lista de Formularios por Gestores</asp:HyperLink>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:HyperLink ID="HLListaVehiculos" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/MenuVehiculos.aspx">Lista de Vehiculos</asp:HyperLink>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:HyperLink ID="HLMenuModelos" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/PantallaModelo.aspx">Menu Modelos</asp:HyperLink>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style26">
                    <asp:HyperLink ID="HLMenuMarcas" runat="server" Font-Underline="True" ForeColor="#3333CC" NavigateUrl="~/PantallaMarcas.aspx">Menu Marcas</asp:HyperLink>
                </td>
                <td class="auto-style28"></td>
                <td class="auto-style29"></td>
            </tr>
            <tr>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style32">
                    &nbsp;</td>
                <td class="auto-style33"></td>
            </tr>
        </table>
        <table class="auto-style31">
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HLCerrarSesion" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/MenuGestorInicio.aspx">Cerrar Sesion</asp:HyperLink>
                </td>
            </tr>
        </table>
    
        <div>
        </div>
    </form>
</body>
</html>
