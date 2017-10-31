using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Add the library
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{

public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
string Subject, string Body)
{
try {

// Define and intialize Mail Message as a method
MailMessage MyMailMessage = new MailMessage();

// Set Mail message.from to equal Mail address with attribute sender 
MyMailMessage.From = new MailAddress(Sender);

// Add a recipient to mail message
MyMailMessage.To.Add(new MailAddress(Recipient));

// if blind carbon copy does not equal null and blind carbon copy does not equal an empty string 
if (bcc != null && bcc != string.Empty) {
// Then set mail message.bcc to add a new mail address 
MyMailMessage.Bcc.Add(new MailAddress(bcc));
}

// if carbon copy does not equal null and carbon copy does not equal an empty string
if (cc != null && cc != string.Empty) {
// Then set mail message.cc to add a mail address
MyMailMessage.CC.Add(new MailAddress(cc));
}

// Set mail message subject equal to subject
MyMailMessage.Subject = Subject;

// Set mail message body equal to body
MyMailMessage.Body = Body;

// Set mail message is body html value to true
MyMailMessage.IsBodyHtml = true;

// Set mail message priority equal to normal
MyMailMessage.Priority = MailPriority.Normal;

// Define and set Simple mail transfer protocal to equal SMTPclient method
SmtpClient MySmtpClient = new SmtpClient();

// Define the smtp client and host port and ip address
MySmtpClient.Port = 25;
MySmtpClient.Host = "127.0.0.1";

// Use smtp client.send method to send message
MySmtpClient.Send(MyMailMessage);

// return the entire code as true for the boolean value
return true;
} catch (Exception ex) {

// if there is an error set the boolean value as false
return false;
}

}
	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}