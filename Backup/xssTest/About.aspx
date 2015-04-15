<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" ValidateRequest="false"
    CodeBehind="About.aspx.cs" Inherits="xssTest.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        Put content here.
        <asp:Label ID="Label1" runat="server" Text="Label"  ClientIDMode="AutoID"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"  ClientIDMode="Inherit"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label"  ClientIDMode="Predictable"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label"  ClientIDMode="Static"></asp:Label>
    </p>
    <div id="body"><%=testString%></div>
</asp:Content>
