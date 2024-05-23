﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bttnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsReservation
        clsReservation Reservation = new clsReservation();
        //capture the name
        Reservation.Name = txtName.Text;
        Reservation.Phone = txtPhone.Text;
        Reservation.ReservationId = Convert.ToInt32(txtReservationId.Text);
        Reservation.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Reservation.TableNumber = Convert.ToInt32(txtTableNumber.Text);
        Reservation.DateAndTime = Convert.ToDateTime(DateTime.Now);
        Reservation.Age = chkAge.Checked;
        //store the name in the session object
        Session["Reservation"] = Reservation;
        //navigate to the view page//
        Response.Redirect("4ReservationViewer.aspx");
    }

    protected void txtReservationId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkAge_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsReservation Reservation = new clsReservation();
        Int32 ReservationId;
        Boolean Found = false;
        ReservationId = Convert.ToInt32(txtReservationId.Text);
        Found = Reservation.Find(ReservationId);
        if (Found == true)
        {
            txtCustomerId.Text = Reservation.CustomerId.ToString();
            txtName.Text = Reservation.Name;
            txtPhone.Text = Reservation.Phone;
            txtDateAndTime.Text = Reservation.DateAndTime.ToString();
            txtTableNumber.Text = Reservation.TableNumber.ToString();
            chkAge.Checked = Reservation.Age;
        }
    }
}