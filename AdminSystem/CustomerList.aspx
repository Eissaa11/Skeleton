﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

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
            <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Add" Width="72px" />
        </p>
    </form>
</body>
</html>