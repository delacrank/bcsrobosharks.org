<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a></strong></font></div>
        <asp:Panel ID="Panel1" runat="server" Height="198px" HorizontalAlign="Left" Width="392px">
            
            <asp:Label ID="Label1" runat="server" Text="First Name:" width="71px"></asp:Label>
            
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Must Enter a First Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
     
            <asp:Label ID="Label2" runat="server" height="19px" Text="Last Name:" width="71px"></asp:Label>
     
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Must Enter a Last Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
           
            <asp:Label ID="Label3" runat="server" height="19px" Text="Pay Rate:" width="71px"></asp:Label>
           
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Please Enter a Pay Rate" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
         
            <asp:Label ID="Label4" runat="server" height="19px" Text="Start Date:" width="71px"></asp:Label>
         
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Please Enter a Start Date" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />

            <asp:Label ID="Label5" runat="server" height="19px" Text="End Date:" width="71px"></asp:Label>

            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEndDate" ErrorMessage="Please Enter an End Date" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblErrorFname" runat="server"></asp:Label>
            <asp:Label ID="lblErrorLname" runat="server"></asp:Label>
            <asp:Label ID="lblErrorPay" runat="server"></asp:Label>
            <asp:Label ID="lblErrorSdate" runat="server"></asp:Label>
            <asp:Label ID="lblErrorEdate" runat="server"></asp:Label>
            <asp:Label ID="lblErrorSEdate" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
