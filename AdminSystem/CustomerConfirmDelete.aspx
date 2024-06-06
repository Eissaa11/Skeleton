<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Size="20px" Text="Are You sure you want to delet this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 9px; top: 208px; position: absolute; height: 33px; width: 69px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 108px; top: 208px; position: absolute; height: 33px; width: 71px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
