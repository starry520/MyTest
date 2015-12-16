using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZJS.Common;

namespace 加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string sss = string.Empty;
            sss = sss.ToUpper();
            Guid g = Guid.Empty;
            Guid st;
            Guid.TryParse("", out st);
            if (st==g)
            {                                   
                int d=100;
            }
            string dd = st.ToString();
            //  AddCookie:userid=1c5c92092f73437f8237f480cbff5c6f,SecretToken=451f7e73b80e4ab7b82d0391ca11c046
            string showText = "uhKre535fW3s%2BgrntACvHFAXvaELKiA6wuNk5z1q8sv%2FBQRg1%2FL88F8FfdmwgwK3";
            string uid2 = "1c5c92092f73437f8237f480cbff5c6f";

            string code = "451f7e73b80e4ab7b82d0391ca11c046";
            string ss = AESHelper.EncryptString(uid2, code);
            string uid = AESHelper.DecryptString(ss, code);
        }



    }
}
