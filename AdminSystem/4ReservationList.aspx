<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4ReservationList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstReservationList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 445px; width: 428px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 529px; position: absolute; width: 98px; right: 2985px; height: 30px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 529px; position: absolute; width: 108px; height: 30px; right: 2055px;" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 622px; position: absolute; width: 174px; height: 33px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDeelete" runat="server" OnClick="btnDeelete_Click" style="z-index: 1; left: 266px; top: 527px; position: absolute; width: 114px; height: 32px" Text="Delete" />
    </form>
</body>
</html>
