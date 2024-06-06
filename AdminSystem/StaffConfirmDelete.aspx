<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .form-container {
            background: #fff;
            padding: 40px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        .form-container label {
            font-family: 'Akzidenz-Grotesk Pro Bold', sans-serif;
            font-size: 18px;
            margin-bottom: 20px;
            color: #333;
        }
        .form-container .button {
            font-family: "Arial Black", sans-serif;
            font-size: 20px;
            background-color: #3399FF;
            color: #fff;
            border: none;
            border-radius: 5px;
            padding: 10px 20px;
            margin: 10px;
            cursor: pointer;
            transition: background-color 0.3s ease;
            width: 100px; /* Ensure buttons have a consistent width */
        }
        .form-container .button:hover {
            background-color: #2878c6;
        }
        .form-container .button-container {
            display: flex;
            justify-content: space-between;
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <div class="button-container">
                <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" CssClass="button" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" CssClass="button" Text="No" />
            </div>
        </div>
    </form>
</body>
</html>
