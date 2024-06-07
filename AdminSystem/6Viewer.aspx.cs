using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _6Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //create anew instance of clsOrdIN
        clsOrdIN AnOrdIn = new clsOrdIN();
        //get the data from the session object
        AnOrdIn = (clsOrdIN)Session["AnOrdIN"];
        //display the order id for this entry
        Response.Write(AnOrdIn.Ord_id);
        Response.Write(AnOrdIn.CustID);
        Response.Write(AnOrdIn.TblNO);
        Response.Write(AnOrdIn.Custname);
        Response.Write(AnOrdIn.Ordtime);
        Response.Write(AnOrdIn.Total_amt);
        Response.Write(AnOrdIn.Reserve);
    }
}