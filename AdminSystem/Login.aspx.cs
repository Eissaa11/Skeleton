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
        
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        clsStaffUser User = new clsStaffUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);  
        Password = Convert.ToString(txtPassword.Text);
        Found = User.FindUser(UserName, Password);
        Session["User"] = User;
        if(txtUserName.Text == "")
        {
            lblError.Text = "Please Enter the UserName";
        }
        else if (txtPassword.Text =="")
        {
            lblError.Text = "Please Enter The Password";
        }
        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false) 
        {
            lblError.Text = "Login Details are incorrect. Please try again ";
        }
    }
}