using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/scripts/jquery-1.4.1.min.js",
            DebugPath = "~/scripts/jquery-1.4.1.js",
            CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js",
            CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js"
        });
        if (Session["SecurityLevel"].ToString() == "U")
        {
            Response.Redirect("frmMain.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //send information to the proper method and data bind the grid
        if(clsDataLayer.SaveUserLogin(Server.MapPath("PayrollSystem_DB.mdb"),
            txtUserName.Text, txtUserPassword.Text, ddSecurityLevel.SelectedValue))
        {
            lblErrorMessage.Text = "The user was successfully added";
            grdUserLogin.DataBind();
        }
        else
        {

            lblErrorMessage.Text = "The user was not added";
        }
    }
}