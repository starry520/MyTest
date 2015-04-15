<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <script language="javascript" type="text/javascript">
        function ChangeValue() {
            alert(1);
            alert(obj.value);
        }
        function loadXMLDoc() {
            var xmlhttp;
            if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                xmlhttp = new XMLHttpRequest();
            }
            else {// code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    document.getElementById("myDiv").innerHTML = xmlhttp.responseText;
                }
            }
            xmlhttp.open("POST", "/WebForm2.aspx", true);
            xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xmlhttp.send("HUID=123");
        }

        function DisConGroupOn_Click() {

            try {
                var xmlhttp;
                if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                    xmlhttp = new XMLHttpRequest();
                }
                else {// code for IE6, IE5
                    xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xmlhttp.onreadystatechange = function () {
                    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                        alert(xmlhttp.responseText);
                    }
                }
                xmlhttp.open("POST", "/WebForm2.aspx", true);
                xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
                xmlhttp.send("huid=123");

            } catch (e) {

            }
        }
    </script>
</head>
<body>
       <a href="javascript:;" class="btn_nomore"  onclick="DisConGroupOn_Click()" >不再提示</a>
    <form id="form1" runat="server">
    <div>
    
    <input type="text" id="userName" onchange="ChangeValue(this)" onkeydown="ChangeValue(this)" />
    </div>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
        ontextchanged="DropDownList1_TextChanged">
        <asp:ListItem Selected="True">1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
    </asp:DropDownList>

     <select name="ctl00$DDL_Language" onchange="javascript:setTimeout(&#39;__doPostBack(\&#39;ctl00$DDL_Language\&#39;,\&#39;\&#39;)&#39;, 0)" id="ctl00_DDL_Language">
	<option selected="selected" value="CN">中文</option>
	<option value="EN">English</option>

</select>

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>

     </body>
</html>
