<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 140px; top: 135px; position: absolute; right: 2866px" Text="UserName" Font-Size="30px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 141px; top: 189px; position: absolute" Text="Password" Font-Size="30px"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" EnableTheming="True" style="z-index: 1; left: 281px; top: 137px; position: absolute; height: 35px; width: 255px;"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 280px; top: 186px; position: absolute; height: 34px; width: 257px;" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="#FF3300" ForeColor="#FF3300" style="z-index: 1; left: 560px; top: 160px; position: absolute"></asp:Label>
        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="z-index: 1; left: 209px; top: 309px; position: absolute; height: 56px; width: 154px;" Text="Login" BackColor="Gray" BorderColor="Black" Font-Size="20px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 308px; position: absolute; left: 403px; height: 58px; width: 160px;" Text="Cancel" BackColor="Gray" BorderColor="Black" Font-Size="20px" OnClick="btnCancel_Click" />
        <asp:Label ID="Label3" runat="server" Font-Italic="False" Font-Names="Algerian" Font-Size="45px" style="z-index: 1; left: 200px; top: 37px; position: absolute; height: 88px; width: 507px" Text="BARA RESTAURANT"></asp:Label>
    </form>
</body>
</html>

