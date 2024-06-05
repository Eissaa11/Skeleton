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
        lstReservationList.DataValueField = "CustomerId";
        lstReservationList.DataValueField = "Name";
        lstReservationList.DataBind();
    }
}