using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class frmLogin : System.Web.UI.Page
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

    //    if (Session["SecurityLevel"].ToString() == "U")
    //    {
    //        Response.Redirect("frmMain.aspx");
    //    }

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        // define dsUser
        dsUser dsUserLogin;

        // define securitylevel as a string
        string SecurityLevel;

        // set dsUserLogin to verify the correct username and password for login1 via clsDataLayer
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"),
                         Login1.UserName, Login1.Password);

        // if more than 1 user is selected in the dsUserLogin statement then return a false value for authenticated
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            //validation code for failed login in, sends an email to the developer or manager of website
            if (clsBusinessLayer.SendEmail("jcarias86@gmail.com",
            "jcarias86@gmail.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {

                Login1.FailureText = Login1.FailureText +
" Your incorrect login information was sent to jcarias86@gmail.com";

            }
            return;
        }

        // set security level to equal the dsUserLogin as the first user in table userLogin
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        // Opens a switch where 3 cases can be accessed depending on the value of e.Authenticated boolean value.
        switch (SecurityLevel)
        {

            case "A":
                // If e.Authenticated value is equal to true then set session "SecurityLevel" to equal "A".
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                // If e.Authenticated value is equal to true then set session "SecurityLevel" to equal "U".
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}