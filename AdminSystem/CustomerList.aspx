<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 617px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="436px" Width="450px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 550px; top: 222px; position: absolute; height: 22px; width: 120px" Text="Enter a FirstName"></asp:Label>
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 593px; top: 316px; position: absolute; height: 36px; width: 91px" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 316px; position: absolute; height: 35px; width: 69px; left: 744px" Text="Clear Filter" />
        <p>
            <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Add" Width="72px" BackColor="#33CCCC" />
            <asp:Button ID="btnEdit" runat="server" BackColor="#0099FF" Height="43px" OnClick="btnEdit_Click" style="margin-left: 66px" Text="Edit" Width="80px" />
            <asp:Button ID="btnDelete" runat="server" BackColor="#CC66FF" Height="39px" OnClick="btnDelete_Click" style="margin-left: 44px" Text="Delete" Width="90px" />
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 681px; top: 223px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
