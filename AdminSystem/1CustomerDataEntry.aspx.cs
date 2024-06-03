using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data.SqlClient;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtCustomerId { get; private set; }
    public object txtlname { get; private set; }
    public object textOrderdate { get; private set; }
    public object chkGender { get; private set; }
    public object txtphoneno { get; private set; }
    public object txtDateAndTime { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //crate a new instance of cLsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
        //Capture the first name 
        String FirstName = txtfname.Text;
        String LastName = textlname.Text;
        String Email = txtemail.Text;
        String phone = txtphone.Text;
        String address = textaddress.Text;
        String orderdate = textorderdae.Text;
        //determine gender based on the selected checkbox
        string Gender;
        AnCustomer.Gender = chkfemale.Checked;
        AnCustomer.Gender = chkfemale.Checked;
        if (chkfemale.Checked)
        {
            Gender = "Male";
        }
        else if (chkmale.Checked)
        {
            Gender = "Female";
        }
        else
        {
            Gender = "";
        }
        //variable  to store any error message
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Gender, phone, Email, orderdate,address);
        if (Error == "")
        {
            AnCustomer.FirstName = txtfname.Text;
            AnCustomer.LastName = textlname.Text;
            AnCustomer.Email = txtemail.Text;
            AnCustomer.phoneno = Convert.ToInt32(txtphone.Text);
            AnCustomer.Address = textaddress.Text;
            AnCustomer.Orderdate = Convert.ToDateTime(DateTime.Now);
            AnCustomer.Gender = chkfemale.Checked;
            AnCustomer.Gender = chkmale.Checked;
            //store the address in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("1CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void btnacncel_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        ClsCustomer AnCustomer = new ClsCustomer();
        //create avariable to store the primary key
        Int32 CustomerId;
        //crate a variable to sotre the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(TextBox1.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        if (Found == true)
        {
            //display the Values of the properties in the form 
            txtfname.Text = AnCustomer.FirstName;
            textlname.Text = AnCustomer.LastName;
            txtemail.Text = AnCustomer.Email;
            txtphone.Text = AnCustomer.phoneno.ToString();
            textaddress.Text = AnCustomer.Address;
            textorderdae.Text = AnCustomer.DateAdded.ToString();

            // Assuming Gender is a boolean, true for female, false for male
            chkfemale.Checked = AnCustomer.Gender;
            chkmale.Checked = !AnCustomer.Gender;



        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        //create an instance of the address class
        ClsCustomer AnCustomer = new ClsCustomer();
        //create avariable to store the primary key
        Int32 CustomerId;
        //crate a variable to sotre the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(TextBox1.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        if (Found == true)
        {
            //display the Values of the properties in the form 
            txtfname.Text = AnCustomer.FirstName;
            textlname.Text = AnCustomer.LastName;
            txtemail.Text = AnCustomer.Email;
            txtphone.Text = AnCustomer.phoneno.ToString();
            textaddress.Text = AnCustomer.Address;
            textorderdae.Text = AnCustomer.Orderdate.ToString();

            // Assuming Gender is a boolean, true for female, false for male
            chkfemale.Checked = AnCustomer.Gender;
            chkmale.Checked = !AnCustomer.Gender;
        }
    }
}

    








