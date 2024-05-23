using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsReservation
        clsReservation Reservation = new clsReservation();
        //get the data from the session object
        Reservation = (clsReservation)Session["Reservation"];
        Response.Write("Reservation Id: " + Reservation.ReservationId + "<br />");
        Response.Write("Customer Id: " + Reservation.CustomerId + "<br />");
        //display the name for this entry
        Response.Write("Name: " + Reservation.Name + "<br />");
        Response.Write("Phone: " + Reservation.Phone + "<br />");
        Response.Write("Date And Time: " + Reservation.DateAndTime.ToShortDateString() + "<br />");
        Response.Write("Table Number: " + Reservation.TableNumber + "<br />");
        Response.Write("Age: " + Reservation.Age + "<br />");

    }
}