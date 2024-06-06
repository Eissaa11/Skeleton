using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _4ConfirmDelete : System.Web.UI.Page
{
    Int32 ReservationId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReservationId = Convert.ToInt32(Session["ReservationId"]);
    }
    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsReservationCollection ReservationBook = new clsReservationCollection();
        ReservationBook.ThisReservation.Find(ReservationId);
        ReservationBook.Delete();
        Response.Redirect("4ReservationList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("4ReservationList.aspx");
    }
}