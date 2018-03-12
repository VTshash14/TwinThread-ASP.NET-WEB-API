<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="webApiTokenAuthentication.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
    </style>
</head>
<body style="height: 361px">
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">Register</span></strong><br />
            <br />
            First Name<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Username<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Register" />
            <br />
            <br />
            <strong><span class="auto-style1">Login</span></strong><br />
            <br />
            Username<br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
        </div>
        </form>
</body>
</html>
