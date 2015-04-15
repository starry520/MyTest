<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="js._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<script>

//    var book = {
//        "title": "Professional JavaScript",
//        "authors": [
//"Nicholas C. Zakas","Starry"
//],
//        edition: 3,
//        year: 2011
//    };
//    var jsonText = JSON.stringify(book, function (key, value) {
//        switch (key) {
//            case "authors":
//                return value.join(",")
//            case "year":
//                return 5000;
//            case "edition":
//                return undefined;
//            default:
//                return value;
//        }
//    });

//    alert(jsonText);

//    for (var i = 0; i < 10; i++) {
//        doSomething(i);
//    }
//    alert(i); //10

//    function Class1() {
//        //self(self被附加到了对象上) self只对私有成员可见(能.点出来 i aa() .点不出来public_dd())
//        var self = this;
//        this.i = 1;
//        this.aa = function () {
//            this.i++;
//            alert(this.i);
//        }
//        var private_bb = function () {
//            alert(self.i);
//            //self.public_dd();//错误 self无法从外部访问,同时self也无法被这个对象的公共方法所访问
//            //aa();//错误  私有方法要通过self调用
//            public_dd(); //可以直接调用 不能用self.public_dd();
//            self.aa();
//        }
//        this.cc = function () {
//            private_bb(); //私有函数
//        }

//        //可以直接调用
//        //  对象的公共方法
//        function public_dd() {
//            self.aa();
//            alert("dd");
//        }
//    }

//    var o = new Class1(); //调用Class1构造函数不运行++(初始化没有调用不运行)
//    o.cc(); //运行++
//    document.write(o.i); //return 2

    //

    function checkFieldLength(fieldName, fieldLength) {
        var str = document.getElementById(fieldName).value;
        var theLen = 0;
        var teststr = '';
        for (i = 0; i < str.length; i++) {
            teststr = str.charAt(i);
            if (str.charCodeAt(i) > 255) {
                theLen = theLen + 2;
            }
            else {
                theLen = theLen + 1;
            }

            if (theLen > fieldLength) {
                document.getElementById(fieldName).value = str.substr(0, i);
                break;
            }
        }      
    }
</script>
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
