<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClassApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>BMW:<asp:Literal ID="BMWLiteral" runat="server" /></h2>
        <h2>Benz:<asp:Literal ID="BenzLiteral" runat="server" /></h2>
        <hr />
        <p>限制時速在 60 ~ 100 之間</p>
        <label>BMW時速</label>
        <div>
            <asp:TextBox ID="TextBoxBMW" runat="server" placeholder="請輸入時速" />
            <h2>BMW時速:<asp:Literal ID="BMWLiteral1" runat="server" /></h2>
        </div>
        <label>Benz時速</label>
        <div>
            <asp:TextBox ID="TextBoxBenz" runat="server" placeholder="請輸入時速" />
            <h2>Benz時速:<asp:Literal ID="BenzLiteral1" runat="server" /></h2>
        </div>
        <hr />
        <h2>Audi1:<asp:Literal ID="AudiLiteral1" runat="server" /></h2>
        <h2>Audi2:<asp:Literal ID="AudiLiteral2" runat="server" /></h2>
        <h2>Audi3:<asp:Literal ID="AudiLiteral3" runat="server" /></h2>
        <hr />
        <div>
            <h2 style="color: blue">BMW:<asp:Literal ID="Literal1" runat="server"></asp:Literal></h2>
            <h2 style="color: green">Benz:<asp:Literal ID="Literal2" runat="server"></asp:Literal></h2>
            <h2 style="color: red">Audi:<asp:Literal ID="Literal3" runat="server"></asp:Literal></h2>
        </div>
        <asp:Button Text="確定" runat="server" />
    </form>
</body>
</html>
