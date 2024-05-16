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
        //create a new instance of clsstaff
        clsstaff staff = new clsstaff();
        //get the data from the session object
        staff = (clsstaff)Session["staff"];
        //display the First Name for this entry
        // Display details of the staff member
        Response.Write("First Name: " + staff.FirstName + "<br />");
        Response.Write("Last Name: " + staff.LastName + "<br />");
        Response.Write("Date of Birth: " + staff.DOB.ToShortDateString() + "<br />");
        Response.Write("Joining Date: " + staff.joiningDate.ToShortDateString() + "<br />");
        Response.Write("Position: " + staff.Position + "<br />");
        Response.Write("Salary: " + staff.Salary.ToString("C") + "<br />"); // Assuming Salary is in decimal and you want to display it as currency
        Response.Write("Phone Number: " + staff.Phoneno + "<br />");
        Response.Write("Full Address: " + staff.Fulladdress + "<br />");
        Response.Write("Email ID: " + staff.EmailId + "<br />");
  

    }
}