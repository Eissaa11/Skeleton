using System;
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
        string Name = txtName.Text;
        string Phone = txtPhone.Text;
        string ReservationId = txtReservationId.Text;
        string CustomerId = txtCustomerId.Text;
        string TableNumber = txtTableNumber.Text;
        string DateAndTime = txtDateAndTime.Text;
        string Age = chkAge.Text;
        string Error = "";
        Error = Reservation.Valid(CustomerId, Name, Phone, DateAndTime, Age, TableNumber);
        if (Error == "")
        {
            Reservation.Name = Name;
            Reservation.Phone = Phone;
            Reservation.CustomerId = Convert.ToInt32(CustomerId);
            Reservation.TableNumber = Convert.ToInt32(TableNumber);
            Reservation.DateAndTime = Convert.ToDateTime(DateAndTime);
            Reservation.Age = chkAge.Checked;
            clsReservationCollection ReservationList = new clsReservationCollection();
            ReservationList.ThisReservation = Reservation;
            ReservationList.Add();
            //navigate to the list page/
            Response.Redirect("4ReservationList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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