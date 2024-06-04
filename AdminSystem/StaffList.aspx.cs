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
        //if this is the first time the page is diplayed
        if (IsPostBack == false)
        {
            //update the list box
            Displaystaff();
        }
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
}