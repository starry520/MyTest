
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yinpin.aspx.cs" Inherits="WebApplication1.yinpin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:Panel ID="plMusic" runat="server">

            <script language="javascript" type="text/javascript">
                var temp = '<bgsound  id="Player" src = "music/5.mp3" loop="true" autostart="true">';
                document.getElementById("Music").innerHTML = temp;  
            </script>
</asp:Panel>
<div id="Music">
</div>
       <%--chrome--%>
   <%--   <embed src="http://www.jrphp.com/test/mp3/qingchundeyanse.mp3" width="0" height="0" type="audio/mpeg" loop="true" autostart="true"></embed />

--%>
  
<%-- <object data="music/5.mp3" type="application/x-mplayer2" width="0" height="0">
  <param name="src" value="music/5.mp3"> </param>
  <param name="autostart" value="1"> </param>
  <param name="playcount" value="infinite">
  </param>
 </object>

  <object 
    	<param name="AutoStart" value="-1" />
        <param name="FileName" value="http://www.jrphp.com/test/mp3/qingchundeyanse.mp3" />
    </object>--%>

<%--<audio  src= "music/5.mp3" controls="controls">
</audio>--%>

<%--<audio controls="controls">  
  <source src="http://www.jrphp.com/test/mp3/qingchundeyanse.mp3" type="audio/mpeg" width="0" height="0"  loop="true" autoplay="true"> 

</audio>
--%>
</body>
</html>
