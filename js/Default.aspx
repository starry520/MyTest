<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="js._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script src="Scripts/jquery-1.4.1.js"></script>
<script>
    $(function () {

        $.ajax({
            url: "http://www.hanxinbank.com/wap/api/BrokerApi.ashx",
            data: { "method": "DownLoadContact", "Investrecordid": "4B92F9AD-F412-454A-8F04-2245721AD18C" },
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            dataType: "jsonp",
            error: function (json) {
                alert(JSON.stringify(json));
            },
            success: function (json) {
                //alert(JSON.stringify(decodeURI(json)));
                var ss = decodeURIComponent (json);
                $('#aaa').val(decodeURIComponent(json));//
                $('#aaa').attr('href', ss);
                $('#aaa').click();
              
                //var fileURL = window.open(json, "_blank", "height=0,width=0,toolbar=no,menubar=no,scrollbars=no,resizable=on,location=no,status=no");
                //fileURL.document.execCommand("SaveAs");
                //fileURL.window.close();
                //fileURL.close();
//                jQuery('<form action="http://' + ss + '"></form>')
//.appendTo('body').submit().remove();
                window.open(ss, "_blank");
            }
        });

    })
  
</script>
    <a id="aaa" href="http://www.hanxinbank.com/File/20160229/4B92F9AD-F412-454A-8F04-2245721AD18C.pdf">123</a>
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
            <input id="test" type="text" maxlength="4" onkeyup ="checkFieldLength('test',4)" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </p>
</asp:Content>
