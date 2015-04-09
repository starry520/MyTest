using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Specialized;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string controlName = Request.Params.Get("__EVENTTARGET"); 

        Control control =  GetPostBackControl(this);
        //if (null != control)
        //{
        //    string controlName = control.ClientID;
        //}
    }


    private Control GetPostBackControl(Page page)
    {
        Control control = null;

        string postBackControlName = Request.Params.Get("__EVENTTARGET");

        string eventArgument = Request.Params.Get("__EVENTARGUMENT"); 
        if (postBackControlName != null && postBackControlName.Length > 0)
        {
            control = Page.FindControl(postBackControlName);
        }

        else
        {
            foreach (string str in Request.Form)
            {
                Control c = Page.FindControl(str);
                if (c is Button)
                {
                    control = c;
                    break; 
                }
            }
        }

        return control; 
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   
}
