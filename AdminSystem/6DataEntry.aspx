<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BARA RESTARAUNT</div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LblOrd_id" runat="server" Text="Ord_id" width="61px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrd_id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblCustID" runat="server" Text="CustID" width="61px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Lblcustname" runat="server" Text="Custname" width="61px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblTblNO" runat="server" Text="TblNO" width="61px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTblNO" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblOrdtime" runat="server" Text="Ordtime" width="61px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrdtime" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblTotal_amt" runat="server" Text="Total_amt"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotal_amt" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="Chkreserve" runat="server" Text="Reserve" />
        </p>
        <asp:Button ID="btnorder" runat="server" OnClick="btnorder_Click" Text="Order Now" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
