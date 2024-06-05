using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsstaff
        ClsCustomer AnCustomer = new ClsCustomer();
        //get the data from the session object
        AnCustomer = (ClsCustomer)Session["AnCustomer"];
        //display the First Name for this entry
        // Display details of the staff member
        Response.Write("First Name: " + AnCustomer.FirstName + "<br />");
        Response.Write("Last Name: " + AnCustomer.LastName + "<br />");
        Response.Write("Phone Number: " + AnCustomer.phoneno + "<br />");

        Response.Write("Email ID: " + AnCustomer.Email + "<br />");
        Response.Write("Full Address: " + AnCustomer.Address + "<br />");
        Response.Write("Order Date: " + AnCustomer.Orderdate.ToShortDateString() + "<br />");
       
      
        
    }
}