<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PopDiv._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        #ele1
        {
            width: 83px;
        }
    </style>

<script language="javascript" type="text/javascript">
  
    </script>
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
    <input type="button" id="ele1" title="按钮" value="按钮" onclick="btnClick()" />
    <asp:LinkButton    ID="LinkButton1" runat="server"        onclick="LinkButton1_Click">测试链接</asp:LinkButton>



<script language="javascript" type="text/javascript">
   function btnClick()
   {
  
    document.getElementById('<%= LinkButton1.ClientID %>'.disabled = true;
   }
   
    function popup() {
     //   var $popupFilter = $("#popup_filter"),
//        ,
//					$popupWrapper = $("#popup"),
//					$popupClose = $popupWrapper.find("#btn_close"),
//                    $popupOK = $popupWrapper.find("#btn_OK"),
//                    $popupCancel = $popupWrapper.find("#btn_Cancel"),
					bodyWid = $("body").outerWidth(true),
					bodyHei = $("body").outerHeight(true),
//					scrollTop = $(window).scrollTop(),
//					w = $(window).width(),
//					h = $(window).height(),
//					popupWid = $popupWrapper.outerWidth(true),
//					popupHei = $popupWrapper.outerHeight(true);

//        if ($popupFilter.length === 0) {
//            $("body").append('<div id="popup_filter"></div>');
//        }

        $("#popup_filter").css({
            "position": "absolute",
            "top": 0,
            "left": 0,
            "z-index": 100,
            "width": bodyWid,
            "height": bodyHei,
            "background-color": "#000",
            "opacity": 0.7
        });

        $popupWrapper.animate({
            "opacity": "show"
        }, 500);

        $popupWrapper.css({
            "position": "absolute",
            "top": h / 2 - popupHei / 2 + scrollTop,
            "left": w / 2 - popupWid / 2,
            "z-index": 999
        });

        $popupClose.click(function (event) {
            $(this).closest($popupWrapper).animate({
                "opacity": "hide"
            }, 600);
            $("#popup_filter").remove();
        });
        $popupOK.click(function (event) {
            $(this).closest($popupWrapper).animate({
                "opacity": "hide"
            }, 600);
            $("#popup_filter").remove();
            location.href = "../Home.aspx";
        });
        $popupCancel.click(function (event) {
            $(this).closest($popupWrapper).animate({
                "opacity": "hide"
            }, 600);
            $("#popup_filter").remove();
        });

    };


        $("#ele1").click(function (ev) {
          popup();
    });


    //蒙版的尺寸
    function getViewportInfo() {
        var w = (window.innerWidth) ? window.innerWidth : (document.documentElement && document.documentElement.clientWidth) ? document.documentElement.clientWidth : document.body.offsetWidth;

        var h = (window.innerHeight) ? window.innerHeight : (document.documentElement && document.documentElement.clientHeight) ? document.documentElement.clientHeight : document.body.offsetHeight;
        return { w: w, h: h };
    }; 
 </script>
    
    </div>

</asp:Content>
