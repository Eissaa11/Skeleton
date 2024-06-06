<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4ReservationConfirmDelete.aspx.cs" Inherits="_4ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 51px; top: 258px; position: absolute; height: 36px; width: 74px;" Text="Yes" />
        <asp:Label ID="sureDelete" runat="server" style="z-index: 1; left: 11px; top: 201px; position: absolute; width: 382px" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 151px; top: 257px; position: absolute; height: 38px; width: 77px" Text="No" />
    </form>
</body>
</html>
