using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Add the proper libraries for clsDataLayer Class
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{

    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // define and intialize variables
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Define sqlConn and connect database 
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // define sqlDA which selects all items from table Personnel
        sqlDA = new OleDbDataAdapter("SELECT * from tblUserActivity", sqlConn);

        // defines DS which is database table Personnel
        DS = new dsUserActivity();

        // Using items selected from variable sqlDA and enters into table UserActivity
        sqlDA.Fill(DS.tblUserActivity);

        // Returns the value DS which is simply a table of information from the SQL database
        return DS;
    }
    
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Define conn, and strSQL in order to send values from IP4Address into the table User Activity
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
                    Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }
    // This function gets the user activity from the tblUserActivity
    public static dsPersonnel GetPersonnel(string Database, string searchTerm)
    {
        // define and intialize variables
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Define sqlConn and connect database 
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // check for blank search 

        if (searchTerm == "" || searchTerm == null)
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + searchTerm + "'", sqlConn);
        }

        // defines DS which is database table Personnel
        DS = new dsPersonnel();

        // Using items selected from variable sqlDA and enters into table Personnel
        sqlDA.Fill(DS.tblPersonnel);

        // Returns the value DS which is simply a table of information from the SQL database
        return DS;
    }
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
                                     string PayRate, string StartDate, string EndDate)
    {

        bool recordSaved;
        // define my transaction and intialize the value as null
        OleDbTransaction myTransaction = null;

        try
        {
            // Define conn and open a connection between the database and the program
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            // define my transaction, establish connection to database
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // Inserts employee values into the tbl Personnel
            strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";

            // Sets the vallue for command type to equal commandtype.text
            // and sets value for commandtype.text to equal strSQL
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // executes a command and returns number of rows in the table affected by the command
            command.ExecuteNonQuery();

            // Updates employee values into the tbl Peronnel
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";

            // Sets the vallue for command type to equal commandtype.text
            // and sets value for commandtype.text to equal strSQL
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // executes a command and returns number of rows in the table affected by the command
            command.ExecuteNonQuery();

            // Commit the data to the SQL database table
            myTransaction.Commit();
            
            // Closes the connection and sets the record saved bool variable to true
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
          // Rollback the information being sent to SQL database if format is incorrect
          myTransaction.Rollback();

            recordSaved = false;

        }

        return recordSaved;
    }
    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // Define and intialize data set user, sql Connection, sql Data Adpater
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Set Sql connection read Microsoft jet for for the data source to output tables in the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                      "Data Source=" + Database);

        // Set the sql Data Adpater read tables from user login
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                      "where UserName like '" + UserName + "' " +
                                      "and UserPassword like '" + UserPassword + "'", sqlConn);

        // define a new user
        DS = new dsUser();

        // Fill the Data Adpatber from tables in the user login
        sqlDA.Fill(DS.tblUserLogin);

        // return the DS variable, or the DS user
        return DS;

    }
    // This function saves the User data
    public static bool SaveUserLogin(string Database, string UserName, string UserPassword, string ddSecurityLevel)
    {
        bool recordSaved;

        try
        {
            // Define conn and open a connection between the database and the program
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            // Inserts employee values into the tbl Login User
            strSQL = "Insert into tblUserLogin " +
                     "(UserName, UserPassword, SecurityLevel) values ('" +
                     UserName + "', '" + UserPassword + "', '" + ddSecurityLevel + "')";

            // Sets the vallue for command type to equal commandtype.text
            // and sets value for commandtype.text to equal strSQL
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // executes a command and returns number of rows in the table affected by the command
            command.ExecuteNonQuery();

            // Closes the connection and sets the record saved bool variable to true
            conn.Close();
        }

        catch (Exception ex)
        {

            recordSaved = false;

        }
        recordSaved = true;

        return recordSaved;
    }
	public clsDataLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}