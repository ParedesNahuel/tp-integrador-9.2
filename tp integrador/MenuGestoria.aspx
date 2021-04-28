<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGestoria.aspx.cs" Inherits="pantalla_de_pruebas.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 75%;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style14 {
            width: 141px;
            height: 85px;
        }
        .auto-style15 {
            width: 325px;
            height: 85px;
        }
        .auto-style20 {
            width: 150px;
            height: 119px;
            font-size: x-large;
        }
        .auto-style21 {
            width: 325px;
            height: 119px;
        }
        .auto-style24 {
            height: 45px;
            width: 141px;
        }
        .auto-style25 {
            width: 325px;
            height: 45px;
        }
        .auto-style28 {
            height: 46px;
            width: 141px;
        }
        .auto-style29 {
            width: 325px;
            height: 46px;
        }
        .auto-style34 {
            width: 182px;
            height: 119px;
        }
        .auto-style35 {
            width: 182px;
            height: 85px;
        }
        .auto-style36 {
            height: 45px;
            width: 182px;
        }
        .auto-style37 {
            height: 46px;
            width: 182px;
        }
    </style>
</head>
<body bgcolor="000000">
    <form id="form1" runat="server" >
        <font color="FFFFFF">
        <table class="auto-style1" >
            <tr>
                <td class="auto-style34">&nbsp;</td>
                <td class="auto-style20"><strong>Menu Gestorias</strong></td>
                <td class="auto-style21">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style4" Height="270px" ImageUrl="~/Imagenes/logo.auto1.jpeg" Width="336px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style35" id="lblNombreGestor">Bienvenido/a:&nbsp;&nbsp;&nbsp; <asp:Label ID="LblNombreGestor" runat="server"></asp:Label>
&nbsp;</td>
                <td class="auto-style14"></td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style36">
                    <asp:HyperLink ID="HLAgregarVehiculo" runat="server">Agregar vehiculo</asp:HyperLink>
                </td>
                <td class="auto-style24">
                    <asp:HyperLink ID="HLBajaVehiculo" runat="server">Dar baja a vehiculo</asp:HyperLink>
                </td>
                <td class="auto-style25">
                    <asp:HyperLink ID="HLFormularioVenta" runat="server">Formulario de venta</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">
                    <asp:HyperLink ID="HLMenuMarcas" runat="server" Font-Underline="True" ForeColor="#3333CC" NavigateUrl="~/PantallaMarcas.aspx">Menu Marcas</asp:HyperLink>
                &nbsp;ya ni va</td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style36">
                    <asp:HyperLink ID="HLMenuModelos" runat="server" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/PantallaModelo.aspx">Menu Modelos</asp:HyperLink>
                &nbsp;ya no ba</td>
                <td class="auto-style24">
                    <asp:HyperLink ID="HLListados" runat="server">Listado de vehiculos</asp:HyperLink>
                </td>
                <td class="auto-style25">Reportes:
                    <asp:HyperLink ID="HLReportesVentas" runat="server">Ventas</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    <asp:HyperLink ID="HLListaVehiculos" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF" NavigateUrl="~/MenuVehiculos.aspx">Lista de Vehiculos</asp:HyperLink>
                &nbsp;ya no va</td>
                <td class="auto-style28"></td>
                <td class="auto-style29"></td>
            </tr>
            <tr>
                <td class="auto-style37">
                    &nbsp;</td>
                <td class="auto-style28">cerrar sesion</td>
                <td class="auto-style29">&nbsp;</td>
            </tr>
        </table>
            </font>
    </form>
</body>
</html>
