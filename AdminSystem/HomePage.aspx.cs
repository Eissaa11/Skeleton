using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaffList_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("2OrderList.aspx");
    }

    protected void btnTableReservation_Click(object sender, EventArgs e)
    {
        Response.Redirect("4ReservationList.aspx");
    }

    protected void btnCustomerList_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}