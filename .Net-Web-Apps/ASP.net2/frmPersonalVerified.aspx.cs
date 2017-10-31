using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonalVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // Text which will display information provided in the create new employee web form
        txtVerifiedInfo.Text = Session["txtFirstName"] +
            "\n" + Session["txtLastName"] +
            "\n" + Session["txtPayRate"] +
            "\n" + Session["txtStartDate"] +
            "\n" + Session["txtEndDate"];
        // check the method to see if the information was sent to the correct location, otherwise send error message
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"),
                               Session["txtFirstName"].ToString(),
        Session["txtLastName"].ToString(),
        Session["txtPayRate"].ToString(),
        Session["txtStartDate"].ToString(),
        Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                              "\nThe information was successfully saved!";

        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                                 "\nThe information was NOT saved.";
        }
    }
    protected void txtVerifiedInfo_TextChanged(object sender, EventArgs e)
    {

    }
}