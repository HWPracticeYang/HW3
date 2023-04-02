<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="heart.aspx.cs" Inherits="WebApplication2.heart" MaintainScrollPositionOnPostback="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .a{
            margin:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" BackColor="#A6B1E1">
                <asp:Label ID="aaa" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="心臟問卷"></asp:Label>
                <br />
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Left" style="margin-left: 545px" Width="300px" CssClass="a">
                </asp:Panel>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出" Width="65px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" Width="65px" />
                <br />
                <asp:Label ID="final" runat="server" BorderColor="Black" BorderStyle="None" Font-Size="Large" ForeColor="Red"></asp:Label>
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="回首頁" Visible="False" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
