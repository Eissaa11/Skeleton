using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                Displaystaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsstaff
        clsstaff staff = new clsstaff();
        //capyure the first name
        string FirstName = txtname.Text;
        string LastName = txtlastname.Text;
        string EmailId = txtemailid.Text;
        string DOB = txtdob.Text;
        string Phoneno = txtphonen.Text;
        string Position = txtposition.Text;
        string JOD = txtjod.Text;
        string Salary = txtsalary.Text;
        string Fulladdress = txtaddress.Text;
        //determine gender based on the selected checkbox
        string Gender;
        if (chkm.Checked)
        {
            Gender = "Male";
        }
        else if (Chkf.Checked)
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
        Error = staff.Valid(FirstName, LastName, Gender, DOB, Phoneno, EmailId, JOD, Position, Salary, Fulladdress);
        if (Error == "")
        {
            staff.StaffId = StaffId;
            //caputure the Firstname
            staff.FirstName = FirstName;
            staff.LastName = LastName;
            staff.Phoneno = Convert.ToInt32(Phoneno);
            staff.EmailId = EmailId;
            staff.Position = Position;
            staff.Salary = Convert.ToDecimal(Salary);
            staff.Fulladdress = Fulladdress;
            staff.DOB = Convert.ToDateTime(DOB);
            staff.JOD = Convert.ToDateTime(JOD);
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                StaffList.ThisStaff = staff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = staff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
    void Displaystaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffId);
        txtstaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtname.Text = StaffBook.ThisStaff.FirstName.ToString();
        txtlastname.Text = StaffBook.ThisStaff.LastName.ToString();
        txtdob.Text = StaffBook.ThisStaff.DOB.ToString();
        txtemailid.Text = StaffBook.ThisStaff.EmailId.ToString();
        txtjod.Text = StaffBook.ThisStaff.JOD.ToString();
        txtposition.Text = StaffBook.ThisStaff.Position.ToString();
        txtsalary.Text = StaffBook.ThisStaff.Salary.ToString();
        txtaddress.Text = StaffBook.ThisStaff.Fulladdress.ToString();
        chkm.Checked = StaffBook.ThisStaff.Gender;
        Chkf.Checked = StaffBook.ThisStaff.Gender;
    }
}