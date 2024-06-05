<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 320px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrder_Id" runat="server" style="z-index: 1; left: 34px; top: 52px; position: absolute" Text="Order_Id" width="83px"></asp:Label>
        <p>
            <asp:TextBox ID="txtOrder_Id" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 119px; top: 47px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 32px; top: 88px; position: absolute" Text="CustomerId" width="83px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 119px; top: 85px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 32px; top: 130px; position: absolute" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; left: 119px; top: 128px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtphoneno" runat="server" style="z-index: 1; left: 119px; top: 162px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblphoneno" runat="server" style="z-index: 1; left: 33px; top: 167px; position: absolute" Text="Phone No" width="83px"></asp:Label>
        <asp:TextBox ID="txtPlaced_at" runat="server" style="z-index: 1; left: 119px; top: 212px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblPlaced_at" runat="server" style="z-index: 1; left: 32px; top: 211px; position: absolute" Text="Placed at" width="83px"></asp:Label>
        </p>
        <asp:Label ID="lblTotal_amount" runat="server" style="z-index: 1; left: 29px; top: 247px; position: absolute" Text="Total Amount"></asp:Label>
        <p>
            <asp:TextBox ID="txtTotal_amount" runat="server" style="z-index: 1; left: 119px; top: 243px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 71px; top: 395px; position: absolute; height: 37px; width: 65px" Text="OK" />
            <asp:CheckBox ID="chkPaid" runat="server" style="z-index: 1; left: 119px; top: 300px; position: absolute" Text="Paid" />
        </p>
        <p>
            <asp:Button ID="btnCancle" runat="server" style="z-index: 1; left: 166px; top: 395px; position: absolute; height: 38px; width: 78px" Text="Cancle" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 119px; top: 350px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
