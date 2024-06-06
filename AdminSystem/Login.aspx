<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 145px; top: 135px; position: absolute; right: 1590px" Text="UserName"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 141px; top: 189px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" EnableTheming="True" style="z-index: 1; left: 281px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 274px; top: 186px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="#FF3300" ForeColor="#FF3300" style="z-index: 1; left: 560px; top: 160px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="z-index: 1; left: 219px; top: 327px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 326px; position: absolute; left: 375px" Text="Cancel" />
    </form>
</body>
</html>
