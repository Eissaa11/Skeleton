using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnorder_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrdIN 
        clsOrdIN AnOrdIN = new clsOrdIN();

        //capture the customer id
        AnOrdIN.CustID = Convert.ToInt32(txtCustID.Text);
        //capture the table No
        AnOrdIN.TblNO = Convert.ToInt32(txtTblNO.Text);
        //capture the customer name
        AnOrdIN.Custname = txtCustname.Text;
        //capture the time of order
        AnOrdIN.Ordtime = Convert.ToDateTime(txtOrdtime.Text);
        //capture its reserve or not
        AnOrdIN.Reserve = Chkreserve.Checked;
        //capture the total money of the order
        AnOrdIN.Total_amt = Convert.ToInt32(txtTotal_amt.Text);

        Session["AnOrdIN"] = AnOrdIN;
        //
        Response.Redirect("6Viewer.aspx");
    }
}