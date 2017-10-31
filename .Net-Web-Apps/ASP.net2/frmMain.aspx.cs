using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Save information in the Database
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");

        // If Session Security Level is equal to "A"
        if (Session["SecurityLevel"] == "A")
        {
            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;
            //Set the linkbtnEditEmployees.visible, imgbtnEditEmployees.Visible to true
        }
        else
        {
            imgbtnEditEmployees.Visible = false;
            linkbtnEditEmployees.Visible = false;
        }
        // If Session Security Level is equal to "A"
        if (Session["SecurityLevel"] == "A")
        {
            imgbtnNewEmployees.Visible = true;
            linkbtnNewEmployee.Visible = true;
            //Set the linkbtnNewEmployee.visible, imgbtnNewEmployees.Visible to true
        }
        else
        {
            imgbtnNewEmployees.Visible = false;
            linkbtnNewEmployee.Visible = false;
        }
        // If Session Security Level is equal to "A"
        if (Session["SecurityLevel"] == "A")
        {
            imgbtnViewUserActivity.Visible = true;
            linkbtnViewUserActivity.Visible = true;
            //Set the linkbtnViewUserActivity.visible, imgbtnViewUserActivity.Visible to true
        }
        else
        {
            imgbtnViewUserActivity.Visible = false;
            linkbtnViewUserActivity.Visible = false;
        }
        // If Session Security Level is equal to "A"
        if (Session["SecurityLevel"] == "A")
        {
            imgbtnManageUsers.Visible = true;
            linkbtnManageUsers.Visible = true;
            //Set the linkbtnManageUsers.Visible, imgbtnManageUsers.Visible to true
        }
        else
        {
            imgbtnManageUsers.Visible = false;
            linkbtnManageUsers.Visible = false;
        }  
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // Send user to the Calculate Salary page
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        // Send user to the Personal Page
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
       // Send user to the User activity page
    }
}