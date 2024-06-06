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
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 570px; top: 238px; position: absolute; width: 148px; height: 26px;" Text="Enter FirstName"></asp:Label>

                <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 795px; top: 240px; position: absolute; width: 182px;"></asp:TextBox>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 449px; width: 508px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 27px; top: 530px; position: absolute; width: 82px; height: 39px; right: 1709px;" Text="Add" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 531px; position: absolute; width: 72px; height: 37px; right: 1614px;" Text="Edit" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 256px; top: 532px; position: absolute; width: 74px; height: 37px; right: 1488px;" Text="Delete" BackColor="#FF3300" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 539px; top: 93px; position: absolute" Text="[IblError]"></asp:Label>
         <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 864px; top: 305px; position: absolute; width: 97px; height: 30px; right: 857px;" Text="Clear Filter" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
 <asp:Button ID="btnAplyClear" runat="server" OnClick="btnApplyClear_Click" style="z-index: 1; left: 663px; top: 307px; position: absolute; width: 102px; height: 31px; " Text="Apply Filter" BackColor="#3399FF" Font-Names="Arial Black" Font-Size="15px" />
        <asp:Button ID="btnCancel" runat="server" BackColor="#CC6600" Font-Names="Arial Black" Font-Size="20px" OnClick="btnCancel_Click" style="z-index: 1; left: 461px; top: 525px; position: absolute; height: 45px; width: 105px;" Text="Cancel" />
    </form>
</body>
</html>