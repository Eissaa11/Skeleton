<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCustomer" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 153px; margin-top: 0px" Width="392px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="19px" style="margin-left: 168px" Width="391px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="19px" style="margin-left: 170px" Width="391px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="19px" style="margin-left: 209px" Width="393px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Phone No"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Height="19px" style="margin-left: 182px" Width="391px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Height="19px" style="margin-left: 188px" Width="391px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" Height="19px" style="margin-left: 166px" Width="391px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Female" />
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Male" />
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="48px" OnClick="Button1_Click" style="margin-left: 13px; margin-top: 30px" Text="OK" Width="183px" />
            <asp:Button ID="Button2" runat="server" Height="48px" style="margin-left: 13px; margin-top: 30px" Text="Cancel" Width="183px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
