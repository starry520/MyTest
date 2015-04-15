<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="js继承._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <script>
        function Parent(username) {
            this.username = username;
            this.hello = function () {
                alert(this.username);
            }
        }

        function Child(username, password) {
            //通过以下3行实现将Parent的属性和方法追加到Child中，从而实现继承
            //第一步：this.method是作为一个临时的属性，并且指向Parent所指向的对象，
            //第二步：执行this.method方法，即执行Parent所指向的对象函数
            //第三步：销毁this.method属性，即此时Child就已经拥有了Parent的所有属性和方法
            this.method = Parent;
            this.method(username); //最关键的一行
            delete this.method;

            this.password = password;
            this.world = function () {
                alert(this.password);
            }
        }

        var parent = new Parent("zhangsan");
        var child = new Child("lisi", "123456");
        parent.hello();
        child.hello();
        child.world()    
    </script>
</asp:Content>
