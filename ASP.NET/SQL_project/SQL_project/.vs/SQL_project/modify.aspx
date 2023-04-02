<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modify.aspx.cs" Inherits="WebApplication2.WebForm4" %>

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
            <asp:Panel ID="Panel1" runat="server" BackColor="#A6B1E1" HorizontalAlign="Center" CssClass="a">     
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="註冊帳號"></asp:Label>
                <br />
                <br />
                輸入身分證號碼:<asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <br />
                姓名:<asp:TextBox ID="TextBox7" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <br />
                帳號:<asp:TextBox ID="TextBox8" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <br />
                輸入密碼:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                重新輸入密碼:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                電話號碼:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                E-mail:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定" Width="78px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="取消" Width="78px" />
            </asp:Panel>
    </form>
</body>
</html>

