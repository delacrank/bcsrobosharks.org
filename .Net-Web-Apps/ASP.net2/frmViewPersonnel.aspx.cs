using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            String searchTerm = Request["txtSearchName"];
            // Declare the DataSet
            dsPersonnel myDataSet = new dsPersonnel();

            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), searchTerm);

            // Sets the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            //Bind the DataGrid
            grdViewPersonnel.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         if (!Page.IsPostBack)
        {
            String searchTerm = Request["txtSearchName"];
            // Declare the DataSet
            dsPersonnel myDataSet = new dsPersonnel();

            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), searchTerm);

            // Sets the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            //Bind the DataGrid
            grdViewPersonnel.DataBind();
        }
    }
}
