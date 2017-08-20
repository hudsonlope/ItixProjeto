<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TpJogo.aspx.cs" Inherits="TpJogo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table>
            <tr>
                <td>Tipo de Jogo:
                </td>
                <td>
                    <asp:DropDownList ID="ddlTpJogo" runat="server">
                        <asp:ListItem Text="Mega Sena" Value="1"> </asp:ListItem>
                        <asp:ListItem Text="Loto Mania" Value="2"> </asp:ListItem>
                        <asp:ListItem Text="Bolão" Value="3"> </asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <td>
                <asp:Button runat="server" ID="BtnEscolher" OnClick="BtnEscolher_Click" Text="Escolher" />

            </td>

              <td>
            <asp:Button runat="server" id="btnResultado" Text="Resultado" OnClick="btnResultado_Click" />
</td>
        </table>

        <div>
        </div>
    </form>
</body>
</html>
