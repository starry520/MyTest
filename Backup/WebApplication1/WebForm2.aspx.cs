using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();

            Response.Write("Hello");

            Response.End();
        }

        protected void GetData()
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location.href=window.location.href;</script>");        
       
        }
    }
}