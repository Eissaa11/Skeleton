using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderT AnOrderT = new clsOrderT();
      //Capture the OrderID
        AnOrderT.Order_Id=Convert.ToInt32(txtOrder_Id.Text);
       //Capture CustomerId
        AnOrderT.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Capture the First Name
        AnOrderT.Firstname = txtFirstname.Text;
        //Capture the Phone Number
        AnOrderT.phoneno=Convert.ToInt32(txtphoneno.Text);
        //Capture the Date for the order  placed
        AnOrderT.Placed_at = Convert.ToDateTime(txtPlaced_at.Text);
        //Capture the total amount of the Order
        AnOrderT.Total_amount = Convert.ToInt32(txtTotal_amount.Text);
        //Capture the Order is paid or not
        AnOrderT.Paid = chkPaid.Checked;
        Session["AnOrderT"] = AnOrderT;
        Response.Redirect("2OrderViewer.aspx");
    }

    protected void chkPaid_CheckedChanged(object sender, EventArgs e)
    {

    }
}