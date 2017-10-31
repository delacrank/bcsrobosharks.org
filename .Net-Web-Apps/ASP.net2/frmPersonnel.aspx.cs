using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SecurityLevel"].ToString() == "U")
        {
            Response.Redirect("frmMain.aspx");
        }
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/scripts/jquery-1.4.1.min.js",
            DebugPath = "~/scripts/jquery-1.4.1.js",
            CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js",
            CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js"
        });
        // If Session Security Level is equal to "A"
        if (Session["SecurityLevel"] == "A")
        {

            btnSubmit.Visible = true;

            //Set the btnsubmit.visible to true
        }
        else
        {

            btnSubmit.Visible = false;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Send information into the employee verification page
        lblErrorFname.Text = "";
        lblErrorLname.Text = "";
        lblErrorPay.Text = "";
        lblErrorSdate.Text = "";
        lblErrorEdate.Text = "";
        lblErrorSEdate.Text = "";

        Session["txtFirstName"] = "";
        Session["txtLastName"] = "";
        Session["txtPayRate"] = "";
        Session["txtStartDate"] = "";
        Session["txtEndDate"] = "";
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;

        bool anyError = false;

        // highlight unfilled fields
        if (txtFirstName.Text.Trim() == "")
        {
      
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            anyError = true;
        }
        // highlight unfilled fields
        if (txtLastName.Text.Trim() == "")
        {
    
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            anyError = true;
        }
        // highlight unfilled fields
        if (txtPayRate.Text.Trim() == "")
        {
            
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            anyError = true;
        }
        // highlight unfilled fields
        if (txtStartDate.Text.Trim() == "")
        {
           
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            anyError = true;
        }
        // highlight unfilled fields
        if (txtEndDate.Text.Trim() == "")
        {
            
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            anyError = true;
        }

        
        // create a validation for the date format 
        try
        {
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);
            if (!anyError)
            {
                if (DateTime.Compare(startDate, endDate) > 0)
                {
                    lblErrorSEdate.Text = "End date must be later than start date";
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    anyError = true;
                }
            }
        }
        // catch any exceptions and explain to the user the format necessary for the date
        catch (Exception ex)
        {
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            lblErrorEdate.Text = "Enter date in format mm/dd/yyy";
            anyError = true;
        }
       
        if (!anyError)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;
            Response.Redirect("frmPersonalVerified.aspx");
        }
    }
}