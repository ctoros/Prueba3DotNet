<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="WEB.CrearCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table style="width:100%;">
     <tr>
            <td>&nbsp;</td>
            <td style="width: 169px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td style="height: 20px; width: 169px"><h1> Ingreso de Clientes</h1> </td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px; width: 169px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px; width: 169px">rut</td>
            <td style="height: 20px">
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px; width: 169px">nombre</td>
            <td style="height: 20px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px; width: 169px">direccion</td>
            <td style="height: 20px">
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
            <td style="height: 20px"></td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 169px">giro</td>
            <td>
                <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 169px">
                <asp:Label ID="lblMensajeIn" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnIngresoCliente" runat="server" Text="Ingresar Cliente" OnClick="btnIngresoCliente_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 169px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 169px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
