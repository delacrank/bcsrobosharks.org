<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="frmManageUsers" %>

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
    <div style="height: 352px" class="auto-style1">
    
        <div class="auto-style1">
    
        <font color="black" face="Arial" size="2"><strong><font color="blue" face="Comic Sans MS" size="4"><a href="frmMain.aspx">Cool</a></font><a href="frmMain.aspx"><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, Inc.</font></a></strong></font><br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="User Name: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Security Level : "></asp:Label>
            <asp:DropDownList ID="ddSecurityLevel" runat="server">
                <asp:ListItem>U</asp:ListItem>
                <asp:ListItem>A</asp:ListItem>
            </asp:DropDownList>
        <br />
        <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add User" OnClick="Button1_Click" />
        <br />
        </div>
        <asp:GridView ID="grdUserLogin" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="297px" DataKeyNames="UserID">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" SortExpression="UserID" ReadOnly="True" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
