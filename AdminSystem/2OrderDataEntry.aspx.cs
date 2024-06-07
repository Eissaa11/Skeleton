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
        //create a new instance of clsOrderT
        clsOrderT AnOrderT = new clsOrderT();

        //capture the CustomerId

        string CustomerId = txtCustomerId.Text;

        //capture the Firstname

        string Firstname = txtFirstname.Text;

        //capture thePhoneno

        string Phoneno = txtphoneno.Text;
        //capture the Placed_at

        string Placed_at = txtPlaced_at.Text;

        //capture the Total_amount

        string Total_amount = txtTotal_amount.Text;


        //capture Paid or not

        String Paid = chkPaid.Text;

        //variable to store any error messages

        string Error = "";

        //validate the data

        Error = AnOrderT.Valid(CustomerId, Firstname, Placed_at, Phoneno, Total_amount);

        if (Error == "")

        {
            //capture the CustomerId
            AnOrderT.CustomerId = Convert.ToInt32(CustomerId);

            //capture the Firstname
            AnOrderT.Firstname = Firstname;

            //capture the Placed_at

            AnOrderT.Placed_at = Convert.ToDateTime(Placed_at);


            //capture the Phoneno
            AnOrderT.Phoneno = Convert.ToInt32(Phoneno);

            //Capture Total_amount
            AnOrderT.Total_amount = Convert.ToInt32(Total_amount);




            //store the Order in the session object

            Session["AnOrderT"] = AnOrderT;
            //navigate to the view page
            Response.Redirect("2Orderviewer.aspx");
        }
        else
        {

            //Display the error message
            lblError.Text = Error;
        }
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