<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hanwen.aspx.cs" Inherits="WebApplication1.hanwen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <%-- [^\a-\z\A-\Z0-9\u4E00-\u9FA5]--%>
        <input id="LoginNameNew"  runat="server" type="text" name="username" maxlength="20"  class="in-text"
         onkeyup="value=value.replace(/[^\u4E00-\u9FA5\w]/g,'')"
          onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\u4E00-\u9FA5\w]/g,''))"/>
    </div>
    </form>
</body>
</html>
