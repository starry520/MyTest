<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script src="Scripts/jquery-1.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem>Two</asp:ListItem>
        </asp:DropDownList><br />
        <br />
        <asp:Button ID="Button1" CommandArgument="Hello World" runat="server" OnClick="Button1_Click" Text="Do PostBack" />&nbsp;</div>
    
    
    <input type="button" id="Button2" value="Press me" onclick="DoPostBack()" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:ImageButton ID="ImageButton1" runat="server" />
    
    </form>
</body>
</html>

<script language="javascript" type="text/javascript">

function DoPostBack() 
{
   // __doPostBack('Button2','My Argument');     
}

</script>

