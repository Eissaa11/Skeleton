<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 125px; top: 115px; position: absolute; width: 140px" Text="First Name" Font-Names="Arial Black"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 103px; top: 176px; position: absolute; width: 140px" Text="Last Name" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 89px; top: 324px; position: absolute; width: 165px;" Text="Date Of Birth" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 98px; top: 382px; position: absolute; width: 140px" Text="Phone no" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 628px; top: 113px; position: absolute" Text="Email Id" width="140px" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 619px; top: 184px; position: absolute" Text="Joining Date" width="140px" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 617px; top: 265px; position: absolute" Text="Position" width="140px" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 620px; top: 350px; position: absolute" Text="Salary" width="140px" Font-Names="Arial Black"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 611px; top: 422px; position: absolute" Text="Full Address" width="140px" Font-Names="Arial Black"></asp:Label>
        <asp:TextBox ID="txtlastname" runat="server" style="z-index: 1; left: 274px; top: 176px; position: absolute; width: 182px;"></asp:TextBox>
        <asp:TextBox ID="txtdob" runat="server" style="z-index: 1; left: 280px; top: 326px; position: absolute; width: 177px;"></asp:TextBox>
        <asp:TextBox ID="txtphonen" runat="server" style="z-index: 1; left: 273px; top: 385px; position: absolute; width: 185px;"></asp:TextBox>
        <asp:TextBox ID="txtemailid" runat="server" style="z-index: 1; left: 768px; top: 113px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtjod" runat="server" style="z-index: 1; left: 771px; top: 182px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtposition" runat="server" style="z-index: 1; left: 782px; top: 264px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtsalary" runat="server" style="z-index: 1; left: 786px; top: 351px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtaddress" runat="server" style="z-index: 1; left: 790px; top: 420px; position: absolute; height: 31px; width: 171px;"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 125px; top: 571px; position: absolute; width: 118px; height: 49px; right: 1596px;" Text="Save" BackColor="#99CCFF" Font-Names="Arial Black" Font-Size="25px" />
        <asp:Label ID="Label12" runat="server" Font-Names="Algerian" Font-Size="50px" style="z-index: 1; left: 412px; top: 26px; position: absolute; width: 535px; height: 39px" Text="Staff Data Entry"></asp:Label>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 101px; top: 246px; position: absolute; width: 140px" Text="Gender" Font-Names="Arial Black"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 609px; top: 570px; position: absolute; height: 47px; width: 116px;" Text="Cancel" BackColor="#FF3300" Font-Names="Arial Black" Font-Size="25px" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 165px; top: 452px; position: absolute" Text="[IblError]"></asp:Label>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 1; left: 275px; top: 115px; position: absolute; width: 182px" ></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="Chkf" runat="server" style="z-index: 1; left: 291px; top: 269px; position: absolute" Text="Female" />
        <p>
            <asp:CheckBox ID="chkm" runat="server" style="z-index: 1; left: 296px; top: 231px; position: absolute" Text="Male" />
        </p>
        <asp:Button ID="btnfind" runat="server" OnClick="btnfind_Click" style="z-index: 1; left: 333px; top: 574px; position: absolute; width: 97px; height: 44px; right: 1409px;" Text="Find" BackColor="#99CCFF" Font-Names="Akzidenz-Grotesk Pro Bold Ext" Font-Size="20px" />
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 100px; top: 78px; position: absolute" Text="Staff Id"></asp:Label>
        <asp:TextBox ID="txtstaffId" runat="server" style="z-index: 1; left: 183px; top: 74px; position: absolute; width: 122px"></asp:TextBox>
    </form>
</body>
</html>