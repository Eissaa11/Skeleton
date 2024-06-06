using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create an instance of the Customer collection
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        // Find the customer to delete
        bool found = CustomerBook.ThisCustomer.Find(CustomerId);
        if (found)
        {
            // Set ThisCustomer to the found customer
            CustomerBook.ThisCustomer = CustomerBook.ThisCustomer;

            // Delete the customer
            CustomerBook.Delete();

            // Redirect to the customer list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // Display an error message if the customer was not found
            //lblError.Text = "Customer not found";
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
