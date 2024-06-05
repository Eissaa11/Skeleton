<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
                <asp:Label ID="Label1" runat="server" Font-Names="Akzidenz-Grotesk Pro Bold" style="z-index: 1; left: 124px; top: 367px; position: absolute; width: 463px; height: 34px" Text="Are you Sure you want to delete this record ?"></asp:Label>
        <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" style="z-index: 1; left: 149px; top: 452px; position: absolute; width: 84px; height: 34px; right: 1606px;" Text="Yes" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="25px" />
<asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 341px; top: 452px; position: absolute; width: 71px; height: 36px; right: 1427px;" Text="No" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="25px" />
    </form>
</body>
</html>