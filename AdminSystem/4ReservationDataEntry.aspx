<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4ReservationDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lbldesign" runat="server" Font-Names="Algerian" Font-Size="XX-Large" style="z-index: 1; left: 57px; top: 42px; position: absolute; width: 570px; height: 56px" Text="TABLE RESERVATION"></asp:Label>
        <asp:Label ID="lblReservationId" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute; height: 35px; width: 151px; bottom: 1010px" Text="Reservation Id"></asp:Label>
        <p>
            <asp:TextBox ID="txtReservationId" runat="server" OnTextChanged="txtReservationId_TextChanged" style="z-index: 1; left: 184px; top: 126px; position: absolute; width: 388px; height: 28px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute; height: 28px; width: 151px" Text="Customer Id"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 183px; top: 182px; position: absolute; width: 386px; height: 28px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute; height: 28px; width: 151px" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 184px; top: 239px; position: absolute; width: 386px; height: 29px"></asp:TextBox>
        <asp:Label ID="lbklPhone" runat="server" style="z-index: 1; left: 10px; top: 297px; position: absolute; height: 31px; width: 151px" Text="Phone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 185px; top: 295px; position: absolute; width: 387px; height: 28px"></asp:TextBox>
        <asp:Label ID="lblDateAndTime" runat="server" style="z-index: 1; left: 10px; top: 354px; position: absolute; height: 28px; width: 151px" Text="Date And Time"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 517px; position: absolute; height: 28px; width: 241px"></asp:Label>
        <asp:TextBox ID="txtDateAndTime" runat="server" style="z-index: 1; left: 186px; top: 352px; position: absolute; width: 390px; height: 28px"></asp:TextBox>
        <asp:Label ID="lblTableNumber" runat="server" style="z-index: 1; left: 10px; top: 408px; position: absolute; height: 29px; width: 151px" Text="Table Number"></asp:Label>
        <asp:TextBox ID="txtTableNumber" runat="server" style="z-index: 1; left: 185px; top: 407px; position: absolute; width: 388px; height: 27px"></asp:TextBox>
        <asp:Label ID="lblAge" runat="server" style="z-index: 1; left: 10px; top: 459px; position: absolute; height: 28px" Text="Age" width="151px"></asp:Label>
        <asp:CheckBox ID="chkAge" runat="server" style="z-index: 1; left: 188px; top: 461px; position: absolute; width: 388px; height: 32px" Text="Over 18?" OnCheckedChanged="chkAge_CheckedChanged" />
        <asp:Button ID="bttnOk" runat="server" OnClick="bttnOk_Click" style="z-index: 1; left: 10px; top: 593px; position: absolute; height: 36px; width: 112px" Text="OK" />
        <asp:Button ID="bttnCancel" runat="server" style="z-index: 1; left: 147px; top: 592px; position: absolute; width: 112px; height: 37px" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 401px; top: 499px; position: absolute; width: 138px; height: 38px" Text="Find" />
    </form>
</body>
</html>
