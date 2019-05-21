<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testMain.aspx.cs" Inherits="testBottles.testMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:RadioButton ID="RadioButton1" GroupName="tablets"  runat="server"  Text="Tablet 1"/>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton2" GroupName="tablets" runat="server"  Text="Tablet 2"/>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton3" GroupName="tablets" runat="server" Text="Tablet 3" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="RadioButton4" GroupName="tablets" runat="server" Text="Tablet 4"/>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" ReadOnly="true" />
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
