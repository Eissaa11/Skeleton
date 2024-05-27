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
        staff.LastName = txtlastname.Text;
        staff.EmailId = txtemailid.Text;
        staff.DOB = Convert.ToDateTime(DateTime.Now);
        staff.Phoneno = Convert.ToInt32(txtphonen.Text);
        staff.Position = txtposition.Text;
        staff.JOD = Convert.ToDateTime(DateTime.Now);
        staff.Salary = Convert.ToDecimal(txtsalary.Text);
        staff.Fulladdress = txtaddress.Text;
        staff.Gender = chkm.Checked;
        staff.Gender = Chkf.Checked;
        //store the address in the session object
        Session["staff"] = staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void txtname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnfind_Click(object sender, EventArgs e)
    {
        clsstaff staff = new clsstaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtstaffId.Text);
        Found = staff.Find(StaffId);
        if (Found == true)
        {
            txtname.Text = staff.FirstName;
            txtlastname.Text = staff.LastName;
            txtdob.Text = staff.DOB.ToString();
            txtphonen.Text = staff.Phoneno.ToString();
            txtemailid.Text = staff.EmailId;
            txtjod.Text = staff.JOD.ToString();
            txtposition.Text = staff.Position;
            txtsalary.Text = staff.Salary.ToString();
            txtaddress.Text = staff.Fulladdress;
            chkm.Checked = staff.Gender;
            Chkf.Checked = staff.Gender;
        }
    }
}