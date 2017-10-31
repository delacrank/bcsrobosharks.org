<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonalVerified.aspx.cs" Inherits="frmPersonalVerified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #form1 {
            height: 227px;
        }
    </style>
</head>
<body style="height: 231px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a><font face="Comic Sans MS" size="4"><br />
        <br />
        <br />
        </font></strong></font>
       
    </div>
        <asp:Label ID="Label1" runat="server" Text="Information to submit"></asp:Label>
        <br />
        <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px" OnTextChanged="txtVerifiedInfo_TextChanged"></asp:TextBox>
    
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Text="ViewPersonnel" />
    
    </form>
</body>
</html>
