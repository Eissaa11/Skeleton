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
            <asp:Label ID="lblCustomer" runat="server" Text="Customer ID" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 102px; margin-top: 0px; margin-bottom: 11px;" Width="432px"></asp:TextBox>
        </p>
              
        <p>
            <asp:Label ID="Label1" runat="server" Text="First Name" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server" Height="17px" style="margin-left: 100px; margin-top: 0px; margin-bottom: 9px;" Width="427px"></asp:TextBox> </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name" Font-Bold="True" Font-Size="Medium" Height="19px" width="77px"></asp:Label>
            <asp:TextBox ID="textlname" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="427px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server" Height="19px" style="margin-left: 98px; margin-top: 0px" Width="427px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Phone No" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
            <asp:TextBox ID="txtphone" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="427px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Address" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
            <asp:TextBox ID="textaddress" runat="server" Height="19px" style="margin-left: 100px; margin-top: 0px" Width="427px" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Order Date" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="textorderdae" runat="server" Height="16px" style="margin-left: 99px; margin-top: 0px; margin-bottom: 9px;" Width="427px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Labe" runat="server" Text="Gender" Font-Bold="True" Font-Size="Medium" width="77px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkfemale" runat="server" Text="Female" Font-Bold="True" />
        </p>
        <p>
            <asp:CheckBox ID="chkmale" runat="server" Text="Male" Font-Bold="True" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[IblError]" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Height="48px" OnClick="btnOK_Click" Style="margin-left: 13px; margin-top: 30px" Text="OK" Width="183px" BackColor="#669999" Font-Bold="True" Font-Size="Medium" />
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnacncel" runat="server" BackColor="#0099CC" Height="49px" OnClick="btnacncel_Click" Text="Cancel" Width="140px" Font-Bold="True" Font-Size="Medium" />
            
            <asp:Button ID="Button1" runat="server" Height="48px" style="margin-left: 81px" Text="Find" Width="132px" BackColor="#660066" OnClick="Button1_Click" />
            
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
