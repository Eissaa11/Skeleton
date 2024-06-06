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
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 247px; top: 175px; position: absolute; right: 1488px; bottom: 391px;" Text="UserName" Font-Names="Arial Rounded MT Bold"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 237px; top: 253px; position: absolute" Text="Password" Font-Names="Arial Rounded MT Bold"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" EnableTheming="True" style="z-index: 1; left: 470px; top: 175px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 468px; top: 254px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="#FF3300" ForeColor="#FF3300" style="z-index: 1; left: 743px; top: 222px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="z-index: 1; left: 260px; top: 363px; position: absolute" Text="Login" Font-Names="Arial Black" Font-Size="20px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 360px; position: absolute; left: 514px" Text="Cancel" Font-Names="Arial Black" Font-Size="20px" />
        <asp:Label ID="Label3" runat="server" Font-Names="Algerian" Font-Size="40px" style="z-index: 1; left: 364px; top: 70px; position: absolute; height: 44px; width: 218px" Text="LOGIN"></asp:Label>
    </form>
</body>
</html>
