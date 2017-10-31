<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

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
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a></strong></font><br />
        <br />
        <br />
        <br />
   
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Annual Hours:"></asp:Label>
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <br />
        <asp:Label runat="server" Text="Rate:" height="19px" width="86px"></asp:Label>
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate Salary" />
        <br />
  
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
    </form>
</body>
</html>
