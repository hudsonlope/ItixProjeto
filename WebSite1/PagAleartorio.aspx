<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PagAleartorio.aspx.cs" Inherits="PagAleartorio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <asp:Label runat="server" ID="lblMsg"></asp:Label>

    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Primeiro Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtPrNumero"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Segundo Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSgNumero"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Terceiro Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtTerNumero"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Quarto Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtQuarNumero"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Quinto Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtQuiNumero"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>Sexto Número:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtSexNumero"></asp:TextBox>
                </td>
            </tr>

            <td>
                <asp:Button runat="server" id="btnProcessar" OnClick="btnProcessar_Click" Text="Processar" />
            </td>
            
        </table>


        <div>
        </div>
    </form>
</body>
</html>
