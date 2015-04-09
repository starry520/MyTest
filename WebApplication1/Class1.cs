using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication1
{
    public class Class1 
    {
        List<int> list = new List<int>();

        private void Getdata()
        {
            var v = (from s in list
                     where s > 0
                     select s).First();
        }

    }
}