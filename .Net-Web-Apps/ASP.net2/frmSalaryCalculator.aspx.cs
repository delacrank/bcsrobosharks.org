using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Declare variables
        Double x = 0.0;
        Double y = 0.0;
        Double z = 0.0;

        // Convert strings of hours and pay rate into integers
        x = Convert.ToDouble(txtAnnualHours.Text);
        y = Convert.ToDouble(txtRate.Text);

        // Calculate pay rate by the hour
        z = x * y;

        // Set label salary with the amount calculated by rate of pay and hours worked
        lblSalary.Text = z.ToString();
        lblSalary.Text = String.Format("{0:C}",z);
    }
}