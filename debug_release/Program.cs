using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug_release
{
    class Program
    {
        static void Main(string[] args)
        {
           string salt= BCrypt.GenerateSalt();
           string pws = "123456";
           string hello= BCrypt.HashPassword(pws,salt);
            string s = "璁㈠崟鏀粯澶辫触锛岄€氳寮傚父[5098]";
            Encoding encoding = System.Text.Encoding.GetEncoding("GB2312");
            byte[] bytes = encoding.GetBytes(s);
            encoding = System.Text.Encoding.UTF8;
            string newOldHtml = encoding.GetString(bytes);
#if DEBUG
               Console.WriteLine("DEBUG");
#endif

            Console.WriteLine("完成");
            Console.ReadKey();
        }
    }
}
