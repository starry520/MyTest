using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Web.Services;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                Response.Cookies.Remove("ebookinghotelcompany");     
                Request.Cookies["starry222"].Value = "2222";
                if (Request.Cookies["starry2"]==null)
                {
                    
                HttpCookie httpcookie1 = new HttpCookie("starry2");
                httpcookie1.Value = "33333";
                httpcookie1.Expires = DateTime.Now.AddYears(1);
              
                Request.Cookies.Add(httpcookie1);
                Response.Cookies["starry2"].Expires = DateTime.Now.AddYears(1);
                }
                object obj = Request.Cookies["starry"].Value;
                Request.Cookies["starry"].Value = "2222";
                HttpCookie httpcookie = new HttpCookie("starry");
                httpcookie.Value = "1233";
                httpcookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(httpcookie);
          

            }
            catch (Exception)
            {
               
            }
            

            //Response.Cookies["voicealert"].Expires = DateTime.Now.AddYears(1);

            //Response.Redirect(base.GetMyURL());
            if (IsPostBack)
            {
                
            }
        }
      
        public void NoExistUid(object sender, EventArgs e)
        {
            return;
        }
     
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}