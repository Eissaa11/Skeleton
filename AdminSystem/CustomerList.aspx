<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="436px" Width="450px"></asp:ListBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Add" Width="72px" BackColor="#33CCCC" />
            <asp:Button ID="btnEdit" runat="server" BackColor="#0099FF" Height="43px" OnClick="btnEdit_Click" style="margin-left: 66px" Text="Edit" Width="80px" />
            <asp:Button ID="btnDelete" runat="server" BackColor="#CC66FF" Height="39px" OnClick="btnDelete_Click" style="margin-left: 44px" Text="Delete" Width="90px" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
