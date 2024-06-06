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
        //if this is the first time page is displayed 
        if (IsPostBack == false)
        {
            DisplayReservation();
        }
    }
    void DisplayReservation()
    {
        clsReservationCollection Reservation = new clsReservationCollection();
        lstReservationList.DataSource = Reservation.ReservationList;
        lstReservationList.DataValueField = "ReservationId";
        lstReservationList.DataTextField = "Name";
        lstReservationList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["ReservationId"] = -1;
        //redirect to the data entry page
        Response.Redirect("4ReservationDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ReservationId;
        //if a record has been selected from the list
        if (lstReservationList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ReservationId = Convert.ToInt32(lstReservationList.SelectedValue);
            //store the data in session object
            Session["ReservationId"] = ReservationId;
            //redirect to the edit page
            Response.Redirect("4ReservationDataEntry.aspx");
        }
        else              //if no record has been selected
        {
            lblError.Text = "PLease select a record from the list to edit";
        }
    }

    protected void btnDeelete_Click(object sender, EventArgs e)
    {
        Int32 ReservationId;
        if (lstReservationList.SelectedIndex != -1)
        {
            ReservationId = Convert.ToInt32(lstReservationList.SelectedValue);
            Session["ReservationId"] = ReservationId;
            Response.Redirect("4ReservationConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsReservationCollection Reservation = new clsReservationCollection();
        Reservation.ReportByName(txtFilter.Text);
        lstReservationList.DataSource = Reservation.ReservationList;
        lstReservationList.DataValueField = "ReservationId";
        lstReservationList.DataTextField = "Name";
        lstReservationList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsReservationCollection Reservation = new clsReservationCollection();
        Reservation.ReportByName("");
        txtFilter.Text = "";
        lstReservationList.DataSource = Reservation.ReservationList;
        lstReservationList.DataValueField = "ReservationId";
        lstReservationList.DataTextField = "Name";
        lstReservationList.DataBind() ;
    }
}