using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Text;

namespace js
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //筛选出需要删除点评数据的酒店ID
            List<int> allHotelInCom = new List<int> { 1,2,3,4,5};
        
            List<int> resultHotelIDs = allHotelInCom;

            List<int> ratingHotelIDs = new List<int> { 2,3,4,5,6,7,8,9};
            var  resourceToDelete = ((from c in ratingHotelIDs
                                 select c).Except(
                                 from r in resultHotelIDs
                                 select r
                                 )).Distinct().ToList();
        }

        
        private void add(int a)
        {
            a++;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"D:\Users\zjliu\Documents\Visual Studio 2010\Projects\DIVTest\js\Default.aspx#starry=liu&&starry=wang");
        }
    }


}
