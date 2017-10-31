<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 253px;
        }
    </style>
</head>
<body style="height: 251px">
    <form id="form1" runat="server">
        <div class="auto-style1">
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a></strong></font><br />
            <br />
            <asp:Label ID="Label1" runat="server" style="text-align: center" Text="View Personnel"></asp:Label>
            <asp:GridView ID="grdViewPersonnel" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
