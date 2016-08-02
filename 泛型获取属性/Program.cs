using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
            string b = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            object g = a;
            object h = b;
            Console.WriteLine(g == h);
            Console.WriteLine(g.Equals(h));

            Person p1 = new Person("jia");
            Person p2 = new Person("jia");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));

            Person p3 = new Person("jia");
            Person p4 = p3;
            Console.WriteLine(p3 == p4);
            Console.WriteLine(p3.Equals(p4));

            Console.ReadLine();

            string url = @"http://iweb.hanxinbank.com/invest/investBorrowinfo.do?investAmount=1000&userId={0}&msgVerCode=123qaz&sourcetype=2&id=741&channel=2";

            List<string> userids = new List<string>();
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F2");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F3");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F4");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F5");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F6");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F7");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F8");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F9");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E210");
            userids.Add("B61E5541-86A0-489C-A6CB-B5E59CC7E2F1");  
            for (int i = 0; i < 2000; i++)
            {
                Console.WriteLine(i);
                url = string.Format(url, userids[i % 10]);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = 20000;
                httpWebRequest.BeginGetResponse(new AsyncCallback(responseCallback), httpWebRequest);
                //HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                //StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                //string responseContent = streamReader.ReadToEnd();
                //httpWebResponse.Close();
                //streamReader.Close();
            }
        }

        protected static void responseCallback(IAsyncResult ar)
        {
            HttpWebRequest req = ar.AsyncState as HttpWebRequest;

            if (req == null)

                return;

            HttpWebResponse httpWebResponse = req.EndGetResponse(ar) as HttpWebResponse;
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            httpWebResponse.Close();
            streamReader.Close();

        }

        public static Double calculate(Double rate, int month)
        {
            Double a = (((Math.Pow((1 + rate / 12), month)) * (rate / 12)) / (Math.Pow((1 + rate / 12), month) - 1));
         
            return a;
        }


        private void GetList<T>(T oldValue, T newValue)
        {
            T t = Activator.CreateInstance<T>();   

             foreach (System.Reflection.PropertyInfo info in typeof(T).GetProperties())
                {
                    object oldPropertyValue = info.GetValue(oldValue, null);
                    object newPropertyValue = info.GetValue(newValue, null);
                    if (oldPropertyValue != newPropertyValue)
                    {
                        DescriptionAttribute[] arrDesc = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if (arrDesc == null || arrDesc.Length == 0)
                        {
                            continue;
                        }                     
                    }
                }
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person(string name)
        {
            _name = name;
        }

    }
}
