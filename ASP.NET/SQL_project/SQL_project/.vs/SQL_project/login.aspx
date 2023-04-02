<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div  style="position:absolute;top:40%;left:30%">
            <asp:Panel ID="Panel1" runat="server" BackColor="#A6B1E1" HorizontalAlign="Center" Width="500px" Height="200px">
                <br />
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" ForeColor="White" Text="登入"></asp:Label>
                <br />
                <br />
                帳號:<asp:TextBox ID="account" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="account" Display="Dynamic" ErrorMessage="尚未輸入!!" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                密碼:<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="尚未輸入!!" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br /> 
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" Width="62px" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="註冊" Width="62px" CausesValidation="False" />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
