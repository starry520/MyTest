<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" ValidateRequest="false"
    CodeBehind="Default.aspx.cs" Inherits="xssTest._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>

    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    <br />
    <table>
    <tbody>
        <tr>
            <td class="td1" ></td>
        </tr>
    </tbody>
        </table>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <br />
    <asp:Label ID="result" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <script>

        var result = "<script>alert('攻击成功')";
        //透过.html的方法会将内容输出成html，将有机会造成XSS攻击
        $(".td1").html(result);

</script>
</asp:Content>
