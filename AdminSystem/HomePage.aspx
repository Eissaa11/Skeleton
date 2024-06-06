<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-image: url('path_to_your_background_image.jpg');
            background-size: cover;
            background-position: center;
        }
        .navbar {
            background-color: rgba(0, 0, 0, 0.5);
            overflow: hidden;
            padding: 10px 0;
        }
        .navbar a, .navbar asp:Button {
            float: left;
            display: block;
            color: #f2f2f2;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
            border: none;
            background: none;
            font: inherit;
            cursor: pointer;
        }
        .navbar a:hover, .navbar asp:Button:hover {
            background-color: #ddd;
            color: black;
        }
        .container {
            position: relative;
            max-width: 1200px;
            margin: 50px auto;
            padding: 20px;
            background: rgba(255, 255, 255, 0.8);
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        .button {
            font-family: "Arial Black", sans-serif;
            font-size: 20px;
            background-color: darkslategrey;
            color: black;
            border: none;
            border-radius: 5px;
            padding: 10px 20px;
            margin: 10px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }
        .button:hover {
            background-color: #0056b3;
        }
        .heading {
            font-family: 'Algerian', cursive;
            font-size: 50px;
            text-align: center;
            margin-bottom: 30px;
            position: absolute;
            top: 30%;
            left: 50%;
            transform: translate(-50%, -50%);
            color: #000; 
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5);
            z-index: 1;
        }
        .logo {
            display: block;
            margin: 0 auto;
            width: 100%;
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            &nbsp;
            <asp:Button ID="btnStaffList" runat="server" Text="Staff List" CssClass="button" OnClick="btnStaffList_Click" Height="66px" Width="242px" />
            <asp:Button ID="btnOrders" runat="server" Text="Orders" CssClass="button" OnClick="btnOrders_Click" Height="68px" Width="245px" />
            <asp:Button ID="btnTableReservation" runat="server" Text="Table Reservation" CssClass="button" OnClick="btnTableReservation_Click" Height="68px" Width="302px" />
            <asp:Button ID="btnCustomerList" runat="server" Text="Customer List" CssClass="button" OnClick="btnCustomerList_Click" Height="69px" Width="300px" />
        </div>
        <div class="container">
            <img src="https://th.bing.com/th/id/R.569f58d00a2d70ebfaaff77d14f9ce25?rik=Q7qW23%2fTLiFLWg&pid=ImgRaw&r=0" alt="Bara Restaurant Logo" class="logo" />
            <h1 class="heading">BARA RESTAURANT</h1>
        </div>
    </form>
</body>
</html>
