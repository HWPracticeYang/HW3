<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="WebApplication2.history" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .a{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:#A6B1E1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="歷史紀錄查詢" CssClass="a"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="刪除" />
        &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="回首頁" />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                刪除(輸入index):<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="確認" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
