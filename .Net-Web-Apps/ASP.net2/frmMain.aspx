<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a></strong></font></div>
        <div class="auto-style2">
            <br />
            <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx" OnClick="LinkButton1_Click">Salary Calculator</asp:LinkButton>
            <asp:Image ID="imgbtnCalculator" runat="server" Height="41px" ImageUrl="~/Images/calculator.gif" Width="68px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx" OnClick="LinkButton2_Click" EnableViewState="False">Add New Employee</asp:LinkButton>
            <asp:Image ID="imgbtnNewEmployees" runat="server" Height="39px" ImageUrl="~/Images/New Employee.jpg" Width="55px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx" style="text-align: center" EnableViewState="False">User Activity</asp:LinkButton>
            <asp:Image ID="imgbtnViewUserActivity" runat="server" Height="39px" ImageUrl="~/Images/User Activity.jpg" Width="69px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <asp:Image ID="imgbtnViewPersonnel" runat="server" Height="43px" ImageUrl="~/Images/personnel.jpg" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <asp:Image ID="imgbtnSearch" runat="server" Height="43px" ImageUrl="~/Images/search.jpg" Width="67px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
            <asp:Image ID="imgbtnEditEmployees" runat="server" Height="41px" ImageUrl="~/Images/edit employees.jpg" Width="53px" />
            <br />
            <br />
            <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">ManageUsers</asp:LinkButton>
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="33px" ImageUrl="~/Images/manage users.jpg" Width="70px" />
        </div>
    </form>
</body>
</html>
