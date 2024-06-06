<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 41px; top: 634px; position: absolute; width: 148px; height: 26px;" Text="Enter FirstName"></asp:Label>

                <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 203px; top: 634px; position: absolute; width: 182px;"></asp:TextBox>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 405px; width: 454px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 19px; top: 485px; position: absolute; width: 77px; height: 28px; right: 1743px;" Text="Add" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 129px; top: 485px; position: absolute; width: 67px; height: 28px; right: 1643px;" Text="Edit" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 241px; top: 482px; position: absolute; width: 72px; height: 32px; right: 1526px;" Text="Delete" BackColor="#FF3300" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 69px; top: 574px; position: absolute" Text="[IblError]"></asp:Label>
         <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 270px; top: 695px; position: absolute; width: 97px; height: 30px; right: 1472px;" Text="Clear Filter" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
 <asp:Button ID="btnAplyClear" runat="server" OnClick="btnApplyClear_Click" style="z-index: 1; left: 106px; top: 694px; position: absolute; width: 102px; height: 31px; " Text="Apply Filter" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnCancel" runat="server" BackColor="#990000" Font-Names="Arial Black" Font-Size="20px" OnClick="btnCancel_Click" style="z-index: 1; left: 441px; top: 490px; position: absolute; height: 29px" Text="Cancel" />
    </form>
</body>
</html>