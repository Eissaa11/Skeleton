﻿using ClassLibrary;
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
        //crate a new instance of cLsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
        AnCustomer.LastName =TextBox3.Text;
        AnCustomer.Email =txtemail.Text;
        AnCustomer.phone = txtphoneno.Text;
        AnCustomer.Address = txtaddress.Text;
        AnCustomer.orderdate = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Gender = chkfemale.Checked;
        AnCustomer.Gender = chkmale.Checked;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("1CustomerViewer.aspx");


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //crate a new instance of cLsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
        AnCustomer.LastName = TextBox3.Text;
        AnCustomer.Email = txtemail.Text;
        AnCustomer.phone = txtphoneno.Text;
        AnCustomer.Address = txtaddress.Text;
        AnCustomer.orderdate = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Gender = chkfemale.Checked;
        AnCustomer.Gender = chkmale.Checked;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("1CustomerViewer.aspx");
    }
}