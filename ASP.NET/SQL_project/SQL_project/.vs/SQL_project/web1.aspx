<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web1.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
     
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" BackColor="#A6B1E1" Height="200px">
                <asp:Label ID="Label1" runat="server" CssClass="a" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="選擇問卷"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button6" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" Text="修改個人資料" Width="90px" OnClick="Button6_Click" />
                &nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" OnClick="Button1_Click" Text="睡眠" Width="80px" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" OnClick="Button2_Click" Text="飲食" Width="80px" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" OnClick="Button3_Click" Text="壓力" Width="80px" />
                &nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" OnClick="Button5_Click" Text="心臟" Width="80px" />
&nbsp;
                <asp:Button ID="Button4" runat="server" BackColor="#DCD6F7" BorderColor="#FF9999" BorderStyle="None" Height="80px" Text="查看歷史紀錄" Width="80px" OnClick="Button4_Click" />
                <br />
                <br />
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="登出" />
            </asp:Panel>

            <br />

        </div>
    </form>
</body>
</html>
