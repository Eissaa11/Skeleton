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
            DisplayCustomer();
        }
    }
    void DisplayCustomer()
    {
        //create an instance of the Staff collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        //set the data soure cto list of addresses in the collection
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field to display
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }
}
    
