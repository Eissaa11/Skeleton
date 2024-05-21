<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;
            </p>
        <p>
            <asp:Label ID="lblCustomer" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="328px"></asp:TextBox>
        </p>
              
        <p>
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="328px"></asp:TextBox> </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="textlname" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="328px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="317px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Phone No"></asp:Label>
            <asp:TextBox ID="txtphone" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="328px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="textaddress" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="328px" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="textorderdae" runat="server" Height="16px" style="margin-left: 100px; margin-top: 0px" Width="313px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Labe" runat="server" Text="Gender"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkfemale" runat="server" Text="Female" />
        </p>
        <p>
            <asp:CheckBox ID="chkmale" runat="server" Text="Male" />
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="[IblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Height="48px" OnClick="btnOK_Click" Style="margin-left: 13px; margin-top: 30px" Text="OK" Width="183px" BackColor="#669999" />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnacncel" runat="server" BackColor="#0099CC" Height="49px" OnClick="btnacncel_Click" Text="Cancel" Width="140px" />
            
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
