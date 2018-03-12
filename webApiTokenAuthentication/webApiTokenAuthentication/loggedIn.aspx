<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loggedIn.aspx.cs" Inherits="webApiTokenAuthentication.loggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Welcom User!</div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserConnectionString %>" SelectCommand="SELECT * FROM [User_Table]"></asp:SqlDataSource>
        <br />
        Table of all users:<asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
                <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            </Columns>
        </asp:GridView>
        <br />
        Search user by email<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Find" />
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
        &nbsp;<asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>
&nbsp;<asp:Label ID="Label6" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
&nbsp;
        <asp:Label ID="Label7" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
&nbsp;<asp:Label ID="Label8" runat="server" Text=" "></asp:Label>
        <br />
    </form>
</body>
</html>
