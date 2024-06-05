using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderT AnOrderT = new clsOrderT();
        AnOrderT = (clsOrderT)Session["AnOrderT"];
        Response.Write(AnOrderT.Firstname);
        Response.Write(AnOrderT.CustomerId);
        Response.Write(AnOrderT.Order_Id);
        Response.Write(AnOrderT.Placed_at);
        Response.Write(AnOrderT.phoneno);
        Response.Write(AnOrderT.Paid);
        Response.Write(AnOrderT.Total_amount);
    }
}