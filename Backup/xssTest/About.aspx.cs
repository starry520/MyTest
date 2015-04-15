using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.ctrip.sec.crypt.OrderIdInUrl;

namespace xssTest
{
    public partial class About : System.Web.UI.Page
    {
        public string testString = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            //string key =" ";
            //if (string.IsNullOrWhiteSpace(key))
            //{
            //    key = null;
               
            //}
            ////testString = Request.QueryString["id"].ToString();
            //string query = "C027A8339FED4773AC9D0B5B89FBFEAC59BD7A4E2688F5B41C61EF070BA7F3BFCC50E3C7FAC1F388735AC3FFD22E3FB0";
            //string query1 = OrderIdCrypt.Encrypt(string.Empty, query);
            //String cipher = OrderIdCrypt.Encrypt(null, "orderid=147258369");
            //Console.WriteLine(cipher);
            //String decrypt = OrderIdCrypt.Decrypt(string.Empty, cipher);

        }
    }
}
