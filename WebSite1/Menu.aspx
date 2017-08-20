<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table>
            <tr>
                <td>Tipo de Escolha:
                </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlTpEscolha">
                        <asp:ListItem Text="Manual" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Automático" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>Quantidade de Jogos:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtQtdJogos"></asp:TextBox>
                </td>
            </tr>

        </table>

        <asp:Button runat="server" ID="btnProcessar" OnClick="btnProcessar_Click" Text="Processar" />


        <br />
        <asp:Label ID="LblMenssagem" runat="server" Text=""></asp:Label>
        <br />
        <%--  <asp:Label ID="LbResultado" runat="server" Text="Label"></asp:Label>--%>
        <br />
        <br />
        <%--  <asp:ListBox ID="listaResultado" runat="server" Height="116px" Width="109px"></asp:ListBox>--%>


        <div>
        </div>
    </form>
</body>
</html>
