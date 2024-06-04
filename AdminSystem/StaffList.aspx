<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" Font-Names="Arial Black" OnClick="btnAdd_Click" style="z-index: 1; left: 40px; top: 499px; position: absolute; width: 69px" Text="Add" />
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 405px; width: 454px"></asp:ListBox>
    </form>
</body>
</html>
