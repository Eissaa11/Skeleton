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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsstaff
        clsstaff staff = new clsstaff();
        //capyure the first name
        staff.FirstName = txtname.Text;
        staff.LastName = TextBox2.Text;
        staff.EmailId = TextBox5.Text;
        staff.DOB = Convert.ToDateTime(DateTime.Now);
        staff.Phoneno = Convert.ToInt32(TextBox4.Text);
        staff.Position = TextBox7.Text;
        staff.joiningDate = Convert.ToDateTime(DateTime.Now);
        staff.Salary = Convert.ToDecimal(TextBox8.Text);
        staff.Fulladdress = TextBox9.Text;
        staff.Gender = chkm.Checked;
        staff.Gender = Chkf.Checked;
        //store the address in the session object
        Session["staff"] = staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnfind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsstaff staff = new clsstaff();
        //create a variable to store the primary key
        Int32 StaffID ;
        Boolean Found = false;  
        StaffID = Convert.ToInt32(txtstaffId.Text);
        Found = staff.Find(StaffID);
        if (Found == true)
        {
            //display the values of the proprties in the form
            txtname.Text = staff.FirstName;
            TextBox2.Text = staff.LastName;
            
            TextBox3.Text = staff.DOB.ToString();
            TextBox4.Text = staff.Phoneno.ToString();
            TextBox5.Text = staff.EmailId;
            TextBox6.Text = staff.joiningDate.ToString();
            TextBox7.Text = staff.Position;
            TextBox8.Text = staff.Salary.ToString();
            TextBox9.Text = staff.Fulladdress;
            chkm.Checked = staff.Gender;
            Chkf.Checked = staff.Gender;




        }
    }
}