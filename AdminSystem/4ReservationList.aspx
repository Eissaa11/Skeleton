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
        <asp:ListBox ID="lstReservationList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 445px; width: 428px" BackColor="Silver"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 579px; top: 84px; position: absolute; width: 229px; height: 25px"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 527px; position: absolute; width: 98px; right: 2985px; height: 32px; bottom: 570px;" Text="Add" BackColor="#999999" BorderColor="Black" Font-Size="20px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 527px; position: absolute; width: 108px; height: 32px; right: 2858px; bottom: 570px;" Text="Edit" BackColor="Gray" BorderColor="Black" Font-Size="20px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 585px; position: absolute; width: 174px; height: 33px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDeelete" runat="server" OnClick="btnDeelete_Click" style="z-index: 1; left: 266px; top: 526px; position: absolute; width: 114px; height: 33px" Text="Delete" BackColor="#666666" BorderColor="Black" Font-Size="20px" />
        <asp:Label ID="lblApply" runat="server" Font-Size="20px" style="z-index: 1; left: 466px; top: 88px; position: absolute; height: 29px; width: 148px" Text="Enter a Name"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" BackColor="#663300" BorderColor="Black" Font-Size="20px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 489px; top: 157px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" BackColor="#663300" BorderColor="Black" Font-Size="20px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 674px; top: 157px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
