using ClassLibrary;
using System;
using System.Web.UI;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve CustomerId from the session
        CustomerId = Convert.ToInt32(Session["CustomerId"]);

        if (!IsPostBack)
        {
            // If CustomerId is not -1, it means we are editing an existing customer
            if (CustomerId != -1)
            {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        // Create an instance of the customer collection
        clsCustomerCollection CustomerCollection = new clsCustomerCollection();

        // Find the specific customer
        bool found = CustomerCollection.ThisCustomer.Find(CustomerId);
        if (found)
        {
            // Populate the form fields with customer data
            TextBox1.Text = CustomerCollection.ThisCustomer.CustomerId.ToString();
            txtfname.Text = CustomerCollection.ThisCustomer.FirstName;
            textlname.Text = CustomerCollection.ThisCustomer.LastName;
            txtemail.Text = CustomerCollection.ThisCustomer.Email;
            txtphone.Text = CustomerCollection.ThisCustomer.phoneno.ToString();
            textaddress.Text = CustomerCollection.ThisCustomer.Address;
            textorderdae.Text = CustomerCollection.ThisCustomer.Orderdate.ToString("yyyy-MM-dd");

            // Set gender checkboxes
            chkfemale.Checked = CustomerCollection.ThisCustomer.Gender;
            chkmale.Checked = !CustomerCollection.ThisCustomer.Gender;
        }
        else
        {
            lblError.Text = "Customer not found";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();

        // Capture form data
        String FirstName = txtfname.Text;
        String LastName = textlname.Text;
        String Email = txtemail.Text;
        String phone = txtphone.Text;
        String address = textaddress.Text;
        String orderdate = textorderdae.Text;

        // Determine gender
        String Gender;
        if (chkmale.Checked)
        {
            Gender = "Male";
        }
        else if (chkfemale.Checked)
        {
            Gender = "female";
        }
        else
        {
            Gender = "";
        }
        // Validate data
        string Error = AnCustomer.Valid(FirstName, LastName, Gender, phone, Email, orderdate, address);

        if (Error == "")
        {
            // No validation errors, so populate the customer object
            AnCustomer.CustomerId = CustomerId;
            AnCustomer.FirstName = FirstName;
            AnCustomer.LastName = LastName;
            AnCustomer.Email = Email;
            AnCustomer.phoneno = Convert.ToInt32(phone);
            AnCustomer.Address = address;
            AnCustomer.Orderdate = Convert.ToDateTime(orderdate);
          //  AnCustomer.Gender = Convert.ToBoolean(Gender);

            // Create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            // If adding a new customer, add the record
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            // Otherwise, update the existing record
            else
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }

            // Redirect back to the customer list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // Display validation errors
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect back to the customer list page without saving
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the customer class
        ClsCustomer AnCustomer = new ClsCustomer();

        // Try to parse the customer ID entered by the user
        if (Int32.TryParse(TextBox1.Text, out CustomerId))
        {
            // Find the customer record
            if (AnCustomer.Find(CustomerId))
            {
                // Display the values of the properties in the form
                txtfname.Text = AnCustomer.FirstName;
                textlname.Text = AnCustomer.LastName;
                txtemail.Text = AnCustomer.Email;
                txtphone.Text = AnCustomer.phoneno.ToString();
                textaddress.Text = AnCustomer.Address;
                textorderdae.Text = AnCustomer.Orderdate.ToString("yyyy-MM-dd");

                // Set gender checkboxes
                chkfemale.Checked = AnCustomer.Gender;
                chkmale.Checked = !AnCustomer.Gender;
            }
            else
            {
                // Display an error message if the customer was not found
                lblError.Text = "Customer not found";
            }
        }
        else
        {
            // Display an error message if the customer ID is not valid
            lblError.Text = "Invalid Customer ID";
        }
    }
}
