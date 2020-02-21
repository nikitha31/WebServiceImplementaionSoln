<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdditionWebAppln.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="first number"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="second number"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" /></br>

            <br />
            Result: <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
