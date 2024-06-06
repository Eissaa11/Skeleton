using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed

        if (IsPostBack == false)
        {
            //update the list box
            Displaystaff();
        }
        clsStaffUser User = new clsStaffUser();
        User = (clsStaffUser)Session["User"];
        Response.Write("Logged in as: " + User.UserName);
    }
    void Displaystaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection staff = new clsStaffCollection();
        //set the data soure cto list of addresses in the collection
        lstStaffList.DataSource = staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select the record from the list to update";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select the record from the list to update";
        }
    }

    protected void btnApplyClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFirstName(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFirstName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}