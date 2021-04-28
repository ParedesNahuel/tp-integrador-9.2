<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMarca.aspx.cs" Inherits="tp_integrador.AgregarMarca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 531px;
        }
        .auto-style3 {
            width: 439px;
        }
        .auto-style4 {
            width: 553px;
        }
        .auto-style5 {
            width: 934px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <h1>Ingresar Nueva MARCA</h1>
                    <p>
                        &nbsp;</p>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">Usuario:
                    <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:HyperLink ID="hplMenuAnterior" runat="server" NavigateUrl="~/PantallaMarcas.aspx">menu anterior</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Código de Marca:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCodMarca" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rfvCodMarca" runat="server" ErrorMessage="no se ingreso codigo" ControlToValidate="txtCodMarca"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre de Marca:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNombreMarca" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="rfvNombreMarca" runat="server" ErrorMessage="no se ingreso nombre de marca" ControlToValidate="txtNombreMarca"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar y Agregar" OnClick="btnConfirmar_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblConfirmado" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
