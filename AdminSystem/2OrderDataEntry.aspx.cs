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
        AnOrderT.Phoneno=Convert.ToInt32(txtphoneno.Text);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of OrderT class
        clsOrderT AnOrderT = new clsOrderT();
        //create a variable to store a primary key
        Int32 Order_Id;
        //Create a variable to store the result of the find opration
        Boolean Found = false;
        //get the primary key entered by the user
        Order_Id = Convert.ToInt32(txtOrder_Id.Text);
        //find the record
        Found= AnOrderT.Find(Order_Id);
        //if found
        if (Found == true)
        {
            //display the values of properties into form
            txtOrder_Id.Text = AnOrderT.Order_Id.ToString();
            txtCustomerId.Text = AnOrderT.CustomerId.ToString();
            txtFirstname.Text = AnOrderT.Firstname;
            txtPlaced_at.Text = AnOrderT.Placed_at.ToString();
            txtTotal_amount.Text = AnOrderT.Total_amount.ToString();
            txtphoneno.Text = AnOrderT.Phoneno.ToString();
            chkPaid.Checked = AnOrderT.Paid;
        }
    }
}