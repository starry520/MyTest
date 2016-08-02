using Dapper;
using System.Configuration;
using System.Data.SqlClient;

using System.Collections.Generic;
using Maticsoft.Model;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Threading;

namespace 爬虫
{
    class Program
    {
        public static string HJSIIConnectionString = ConfigurationManager.AppSettings["ConnectionStringForBroker"];
        static string temp1 = @" <tr>
                <td class=""td1"" >
                    {0}
                </td>
                <td class=""td2"">
                    {1}
                </td>
                <td>
                   {2}
                </td>
            </tr>             ";
        static string temp2 = @" 
<!DOCTYPE html>
<head><meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><title>

</title>
    <script src='Scripts/jquery-1.4.1.js'></script>
    <script src='Scripts/handlebars-v3.0.3.js'></script>
    <link href='Styles/bootstrap.min.css' rel='stylesheet' /><link href='Styles/demo.css' rel='stylesheet' /><link href='Styles/layout.css' rel='stylesheet' />	
 
</head>   
<body>
    <form>    
       <table  class='table table-bordered table-striped table-hover'>          
           {0}  
       </table>    
    </div>
    </form>
   </body>
</html>
  ";
        static string JSESSIONID = string.Empty;
        static void Main(string[] args)
        {

            //GetHtml("http://www.jjlwd.com/financeDetail.do?shoveDate1469608910381");
            //for (int i = 1800; i < 10000; i++)
            //{
            //    string name= GetHtml2("http://www.jjlwd.com/financeDetail.do?id="+i);
            //    if (string.IsNullOrEmpty(name))
            //    {
            //        continue;
            //    }

            //    AddProduct(i,name);
            //}

            #region 还款信息
            //List<long> ids = GetProductIds();
            //for (int i = 201; i < ids.Count; i++)
            //{
            //    bool flag = true;
            //    while (true)
            //    {
            //        try
            //        {
            //            var id = ids[i];
            //            if (id % 50 == 0 && id >= 50)
            //            {
            //                Thread.Sleep(1000);
            //            }
            //            Console.WriteLine(string.Format("添加到：{0}/{1}", i, ids.Count));

            //            string info = GetHtml("http://www.jjlwd.com/financeRepay.do?paramMap.id=" + id);
            //            UpdateProduct(id, info);
            //            break;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            flag = true;
            //        }
            //    }
            //} 
            #endregion

            #region 生成html
            step3();
            #endregion
        }

        private static void step3()
        {
          List<Products> list = GetProducts();
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(string.Format(temp1, item.Id, item.Name, item.RepayRemark));
            }

            temp2 = string.Format(temp2, sb.ToString());
            temp2=temp2.Replace("width=\"100%\"", "");
            using (StreamWriter sw=new StreamWriter("1.html"))
            {
                sw.WriteLine(temp2,false);
            }
        }

        public static List<Products> GetProducts()
        {
            List<Products> list = new List<Products>();
            using (var sqlConnection = new SqlConnection(HJSIIConnectionString))
            {
                list = sqlConnection.Query<Products>("select   * from Products  ").AsList();
            }

            return list;
        }
        /// <summary>
        /// 取Id和对应的还款信息
        /// </summary>
        /// <param name="url"></param>
        static string GetHtml(string url)
        {          
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.CookieContainer = GetCookie();

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            //若成功取得网页的内容，则以System.IO.Stream形式返回，若失败则产生ProtoclViolationException错 误。在此正确的做法应将以下的代码放到一个try块中处理。这里简单处理   
            Stream reader = webResponse.GetResponseStream();
            ///返回的内容是Stream形式的，所以可以利用StreamReader类获取GetResponseStream的内容，并以StreamReader类的Read方法依次读取网页源程序代码每一行的内容，直至行尾（读取的编码格式：UTF8）  
            StreamReader respStreamReader = new StreamReader(reader, Encoding.UTF8);

            ///分段，分批次获取网页源码  
            char[] cbuffer = new char[1024];
            string fbyteRead = respStreamReader.ReadToEnd();
            Console.WriteLine("添加结果：" + fbyteRead);
            return fbyteRead;
        }

        /// <summary>
        /// 取id和对应的名字
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        static string GetHtml2(string url)
        {
            string name = string.Empty;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.CookieContainer = GetCookie();
          
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            //若成功取得网页的内容，则以System.IO.Stream形式返回，若失败则产生ProtoclViolationException错 误。在此正确的做法应将以下的代码放到一个try块中处理。这里简单处理   
            Stream reader = webResponse.GetResponseStream();
            ///返回的内容是Stream形式的，所以可以利用StreamReader类获取GetResponseStream的内容，并以StreamReader类的Read方法依次读取网页源程序代码每一行的内容，直至行尾（读取的编码格式：UTF8）  
            StreamReader respStreamReader = new StreamReader(reader, Encoding.UTF8);

            ///分段，分批次获取网页源码  
            char[] cbuffer = new char[1024];
            string fbyteRead = respStreamReader.ReadToEnd();

            string s = "<p class=\"title\" data-type=\".*\"><span id=\"type_name\"></span><em>.*</em></p>";
            Regex reg = new Regex(s);
            MatchCollection mctable = Regex.Matches(fbyteRead, s, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            if (mctable.Count > 0)
            {
                string p = mctable[0].Value;
                MatchCollection mctable2 = Regex.Matches(p, "<em>.*</em>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                if (mctable2.Count > 0)
                {
                    name = mctable2[0].Value;
                    name = name.Replace("<em>", "");
                    name = name.Replace("</em>", "");
                }
            }

            return name;
        }

        public static List<long> GetProductIds()
        {
            List<long> ids = new List<long>();
             using (var sqlConnection = new SqlConnection(HJSIIConnectionString))
            {
                 ids = sqlConnection.Query<long>("select id from Products  ").AsList();               
            }

             return ids;
        }
        public static void AddProduct(int Id,string name)
        {
            Products product=null;
            using (var sqlConnection = new SqlConnection(HJSIIConnectionString))
            {
                var products = sqlConnection.Query<Products>("select * from Products  where id=@id", new { id = Id }).AsList();
               if (products!=null&&products.Count>0)
               {
                   product = products[0];
               }
               else
               {
                   sqlConnection.Execute(@"INSERT INTO products(id,name)VALUES(@id, @name)",
                    new { id = Id, name = name });
               }
            }    
        }

        public static void UpdateProduct(long id ,string info)
        {
        
            using (var sqlConnection = new SqlConnection(HJSIIConnectionString))
            {
                var count = sqlConnection.Execute("update  Products  set RepayRemark=@repayremark where id=@id", new
                {
                    id = id,
                    RepayRemark = info
                });
                Console.WriteLine("添加结果："+count.ToString());
            }
        }

        private static CookieContainer GetCookie()
        {
            CookieContainer cookieContainer = new CookieContainer();
            string ss = "pgv_pvi=4970192896; tencentSig=2238021632; IESESSION=alive; _qddamta_4006961133=3-0; pgv_si=s7862804480; _qdda=3-1.1; _qddab=3-pj0oek.ir4n49oc; JSESSIONID=CEF85C4815BA63BDAA8D29AD64D7BCF7; jjl_referrer=; CNZZDATA1256609135=2029111682-1461824432-null%7C1469604663; Hm_lvt_cae01139f76d0f2a6ba3764b44a74340=1469605025,1469606649,1469608097,1469608772; Hm_lpvt_cae01139f76d0f2a6ba3764b44a74340=1469608899";
            string[] strs = ss.Split(new char[] { ';' },System.StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in strs)
            {
                if (item.Contains("Hm_lvt_cae01139f76d0f2a6ba3764b44a74340"))
                {
                    continue;
                }

                string[] vs = item.Split(new char[] { '=' }, System.StringSplitOptions.RemoveEmptyEntries);
                if (vs.Length==1)
                {
                      continue;
                }

                Cookie ck = new Cookie(vs[0].Trim(), vs[1].Trim(), "/", ".jjlwd.com");
                cookieContainer.Add(ck);
            }

            return cookieContainer;
        }
    }
}
