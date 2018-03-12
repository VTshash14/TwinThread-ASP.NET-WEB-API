<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="webApiTokenAuthentication.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-weight: normal;
            font-size: medium;
        }
    </style>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div style="font-size: x-large">
            Edit User Details<br />
            <span class="auto-style2">
            <br />
            <br />
            Email</span><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <span class="auto-style2">New First Name<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </span>
            <br />
            <span class="auto-style2">New Last Name</span><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <span class="auto-style2">New Password</span><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        </div>
    </form>
</body>
</html>
