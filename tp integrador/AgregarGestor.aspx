<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarGestor.aspx.cs" Inherits="tp_integrador.RegistroGestor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 75%;
        }
        .auto-style2 {
            width: 511px;
        }
        .auto-style5 {
            width: 392px;
        }
        .auto-style18 {
            width: 500px;
        }
        .auto-style7 {
            width: 1029px;
        }
        .auto-style31 {
            width: 511px;
            height: 51px;
        }
        .auto-style32 {
            width: 392px;
            height: 51px;
        }
        .auto-style33 {
            width: 500px;
            height: 51px;
        }
        .auto-style34 {
            width: 1029px;
            height: 51px;
        }
        .auto-style35 {
            height: 51px;
        }
        .auto-style13 {
            width: 511px;
            height: 60px;
        }
        .auto-style14 {
            width: 392px;
            height: 60px;
        }
        .auto-style20 {
            width: 500px;
            height: 60px;
        }
        .auto-style15 {
            width: 1029px;
            height: 60px;
        }
        .auto-style16 {
            height: 60px;
        }
        .auto-style21 {
            width: 511px;
            height: 88px;
        }
        .auto-style22 {
            width: 392px;
            height: 88px;
        }
        .auto-style23 {
            width: 500px;
            height: 88px;
        }
        .auto-style24 {
            width: 1029px;
            height: 88px;
        }
        .auto-style25 {
            height: 88px;
        }
        </style>
</head>
<body bgcolor="000000" >
    <font color ="FFFFFF">
    <form id="form1" runat="server">
        <table class="auto-style1" background="https://cdn.pixabay.com/photo/2016/08/26/10/09/auto-1621744_1280.jpg" align ="center">
            <tr>
                <td class="auto-style2">
                    <h1>Menu registro de Gestor</h1>
                    <p>
                        &nbsp;</p>
                    <p>
                        &nbsp;</p>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/logo.jpeg" />
                </td>
                <td>
                    <asp:HyperLink ID="hplMenuPrincipal" runat="server" NavigateUrl="~/MenuGestorInicio.aspx">volver al menu principal</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style31">Matricula</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="rfvMatricula" runat="server" ControlToValidate="txtMatricula" ErrorMessage="Ingrese una matricula" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">Nombre:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese un nombre en el espacio" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">Apellido:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Ingrese un apellido en el espacio" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">Fecha de nacimiento:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtFecha" runat="server" TextMode="DateTime"></asp:TextBox>
                &nbsp; (DD/MM/AAAA)</td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="RFVFecha" runat="server" ErrorMessage="Ingrese una fecha." ValidationGroup="Grupo1" ControlToValidate="txtFecha"></asp:RequiredFieldValidator>
&nbsp;
                    <asp:RegularExpressionValidator ID="revFecha" runat="server" ControlToValidate="txtFecha" ErrorMessage=" Fecha no valida" ValidationExpression="^[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}$" ValidationGroup="Grupo1"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">DNI:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtDni" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="RFVDni" runat="server" ControlToValidate="txtDni" ErrorMessage="No se introdujo un DNI. " ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvDni" runat="server" ControlToValidate="txtDni" ErrorMessage="Dni fuera de rango" MaximumValue="99999999" MinimumValue="10000000" Type="Integer" ValidationGroup="Grupo1"></asp:RangeValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">Mail:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMail" ErrorMessage="No se introdujo un mail.  " ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revMail" runat="server" ControlToValidate="txtMail" ErrorMessage=" Mail no valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Grupo1"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31">
                    <br />
                    Nombre del perfil:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtPerfil" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="rfvPerfil" runat="server" ControlToValidate="txtPerfil" ErrorMessage="Ingrese un nombre en el espacio" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style13">Contraseña:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    <asp:RequiredFieldValidator ID="rfvContrasenia" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="ingrese contraseña" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <br />
                    Confirme contraseña:</td>
                <td class="auto-style22">
                    <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style23">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtConfirm" ControlToValidate="txtContrasenia" ErrorMessage="reingrese contraseña" ValidationGroup="Grupo1"></asp:CompareValidator>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" ValidationGroup="Grupo1" />
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="lblConfirmado" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
        </font>
</body>
</html>
