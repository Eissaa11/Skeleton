using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        clsCustomerUser User = new clsCustomerUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found  = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = User.FindUser (UserName, Password);
        Session["User"] = User;
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter  a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter  a password";
        }
        else if(Found == true)
        {
            Response.Redirect("HomePage.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login DEtails are incorrect. Try Again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}