<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PagAutomatico.aspx.cs" Inherits="PagAutomatico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
        <br />
        <asp:Button ID="Button1" runat="server" Text="Jogar Novamente" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:ListBox ID="listaResultado" runat="server" Height="360px" Width="278px"></asp:ListBox>
      

        <asp:Label runat="server" ID="lblMsg"></asp:Label>

    </div>
    </form>
</body>
</html>
