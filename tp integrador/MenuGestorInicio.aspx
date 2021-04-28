<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGestorInicio.aspx.cs" Inherits="tp_integrador.WFGestor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        titulo
    </title>
<style>

       
        
        .auto-style14 {
            width: 451px;
            margin-left: 40px;
        height: 185px;
    }
        .auto-style6 {
            width: 1568px;
            margin-left: 40px;
        height: 185px;
        text-align: center;
    }
        .auto-style20 {
            width: 451px;
            height: 64px;
        }
        .auto-style22 {
            width: 1568px;
            height: 64px;
        }
        .auto-style23 {
            margin-right: 3px;
        }
        .auto-style24 {
            text-align: center;
        }
        .auto-style26 {
            width: 945px;
            height: 64px;
        }
        .auto-style29 {
            width: 419px;
            height: 64px;
        }
        .auto-style31 {
            width: 945px;
            height: 41px;
        }
        .auto-style32 {
            width: 419px;
            height: 41px;
        }
        .auto-style33 {
            width: 451px;
            height: 41px;
        }
        .auto-style34 {
            width: 1568px;
            height: 41px;
        }
        .auto-style35 {
            height: 57px;
            text-align: center;
        }
        .auto-style37 {
            font-size: medium;
        }
        .auto-style38 {
       width: 50%;
    }
    .auto-style39 {
        width: 945px;
        height: 29px;
    }
    .auto-style40 {
        width: 419px;
        height: 29px;
    }
    .auto-style41 {
        width: 451px;
        height: 29px;
    }
    .auto-style42 {
        width: 1568px;
        height: 29px;
    }
    .auto-style43 {
        width: 945px;
        height: 185px;
    }
    .auto-style44 {
        width: 419px;
        height: 185px;
    }
    .auto-style45 {
        width: 451px;
        height: 185px;
    }
    .auto-style46 {
        width: 1568px;
        height: 185px;
    }
        .auto-style47 {
        height: 858px;
    }
        </style>
</head>
    
<body bgcolor="000000" >
    
        &nbsp;<form id="form1" runat="server">

            <div class="auto-style47">
            <table  class="auto-style38" border="0" background="https://cdn.pixabay.com/photo/2016/08/26/10/09/auto-1621744_1280.jpg" aling="center" >
                <tr > 
                    <td class="auto-style43">
                        <font color="FFFFFF"> 
                        <h1 class="auto-style24">Menu de Gestor</h1>
                        </font>
                    </td>
                    <td class="auto-style44"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style6">
                        &nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server"  ImageUrl ="~/Imagenes/logo.jpeg" CssClass="auto-style23" Height="364px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        <font color="FFFFFF">Ingrese perfil: </font>
                        </td>
                    <td class="auto-style29">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style20">
                        <asp:RequiredFieldValidator ID="rfvPerfil" runat="server" ControlToValidate="txtNombre" ErrorMessage="ingrese nombre de perfil" ValidationGroup="Grupo2" BackColor="#FF0066" ForeColor="White"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style22"></td>
                </tr>
                <tr>
                    <td class="auto-style39"></td>
                    <td class="auto-style40">
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style41"></td>
                    <td class="auto-style42"></td>
                </tr>
                <tr>
                    <td class="auto-style43"> <FONT COLOR= "FFFFFF">Ingrese <span class="auto-style37">contraseña</span>:</FONT>

                    </td>
                    <td class="auto-style44">
                        <asp:TextBox ID="txtContrasenia" runat="server" CssClass="auto-style4" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style45">
                        <asp:RequiredFieldValidator ID="rfvContrasena" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="ingrese contraseña" BackColor="#FF0066" ForeColor="White" ValidationGroup="Grupo2"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style46"></td>
                </tr>
                <tr>
                    <td class="auto-style31"></td>
                    <td class="auto-style32">
                        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" ValidationGroup="Grupo2" />
                    </td>
                    <td class="auto-style33">
                        <asp:Label ID="lblConfirmado" runat="server" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style34"></td>
                </tr>
                <tr bgcolor="000000">
                    <td class="auto-style35" colspan="4"><font color="FFFFFF">
                        ¿No esta registrado?&nbsp;&nbsp;&nbsp;
                            </font>
                        <asp:HyperLink ID="hlRegistrar" runat="server" NavigateUrl="~/AgregarGestor.aspx">Haz click aquí</asp:HyperLink>
                    </td>
                </tr>
            </table>
                </div>
    </form>
   </body>
</html>
