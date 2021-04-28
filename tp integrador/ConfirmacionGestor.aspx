<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmacionGestor.aspx.cs" Inherits="tp_integrador.ConfirmacionGestor" %>

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
            width: 760px;
        }
        .auto-style3 {
            width: 994px;
        }
        .auto-style5 {
            text-decoration: underline;
        }
        .auto-style6 {
            width: 105px;
        }
    </style>
</head>
<body bgcolor="000000">
    <font color="FFFFFF">
    <form id="form1" runat="server" >
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/logo.auto1.jpeg" />
                    </td>
                    <td class="auto-style3">
                        <h1>Registro realizado correctamente</h1>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style6"><span class="auto-style5">Perfil:</span>
                                    <asp:Label ID="lblPerfil" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                <td><span class="auto-style5">Contraseña:</span>
                                    <asp:Label ID="lblContrasenia" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <br />
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtnInicio0" runat="server" PostBackUrl="~/MenuGestorInicio.aspx">Volver al Menu Principal</asp:LinkButton>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:HyperLink ID="hplGestoria0" runat="server" Font-Underline="True" ForeColor="#3333CC" NavigateUrl="~/MenuGestoria.aspx">Menu de Gestoria</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <br />
                        <br />
                        &nbsp;<h3>
                            (SI ES ADMINISTRADOR MASTER DEBE SOLICITAR A OTRO ADMINISTRADOR QUE SUBA SU NIVEL)<br />
                        </h3>
                        <br />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
        </font>
</body>
</html>
