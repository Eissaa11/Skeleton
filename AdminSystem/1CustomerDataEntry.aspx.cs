using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtCustomerId { get; private set; }
    public object txtlname { get; private set; }
    public object textOrderdate { get; private set; }
    public object chkGender { get; private set; }
    public object txtphoneno { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //crate a new instance of cLsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
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
    protected void btnacncel_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }

}




    



