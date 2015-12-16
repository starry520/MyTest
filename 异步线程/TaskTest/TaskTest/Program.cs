using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Uri> uris = new List<Uri>();

            uris.Add(new Uri("http://localhost:26936/QuickPage.aspx"));
            uris.Add(new Uri("http://localhost:26936/SlowPage.aspx"));
            uris.Add(new Uri("http://localhost:26936/VerySlowPage.aspx"));
            uris.Add(new Uri("http://localhost:26936/QuickPage.aspx"));
            uris.Add(new Uri("http://localhost:26936/SlowPage.aspx"));
            uris.Add(new Uri("http://localhost:26936/VerySlowPage.aspx"));
            AsyncDemo asyncDemo = new AsyncDemo();
            Console.WriteLine(DateTime.Now);
            int totalSize = asyncDemo.SumPageSizes(uris);
            Console.WriteLine(DateTime.Now);
            totalSize = asyncDemo.SumPageSizesAsync2(uris).Result;
            Console.WriteLine("TotalSize:{0}, Finished", totalSize);
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }


    public class AsyncDemo
    {
        public int SumPageSizes(IList<Uri> uris)
        {
            int total = 0;
            foreach (var uri in uris)
            {
                Console.WriteLine("Thread {0}:Found {1} bytes...{2}",
                    Thread.CurrentThread.ManagedThreadId, total, DateTime.Now);
                var data = new WebClient().DownloadData(uri);
                total += data.Length;
            }
            Console.WriteLine("{0}:Found {1} bytes total {2}",
                Thread.CurrentThread.ManagedThreadId, total, DateTime.Now);
            return total;
        }


        public async Task<int> SumPageSizesAsync2(IList<Uri> uris)
        {
            var tasks = uris.Select(uri => new WebClient().DownloadDataTaskAsync(uri));
            var data = await Task.WhenAll(tasks);
            return await Task.Run(() =>
            {
                return data.Sum(s => s.Length);
            });
        }
    }

    public class MyClass
    {
        public MyClass()
        {
            DisplayValue(); //这里不会阻塞
            System.Diagnostics.Debug.WriteLine("MyClass() End.");
        }
        public Task<double> GetValueAsync(double num1, double num2)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    num1 = num1 / num2;
                }
                return num1;
            });
        }
        public async void DisplayValue()
        {
            double result = await GetValueAsync(1234.5, 1.01);//此处会开新线程处理GetValueAsync任务，然后方法马上返回
            //这之后的所有代码都会被封装成委托，在GetValueAsync任务完成时调用
            System.Diagnostics.Debug.WriteLine("Value is : " + result);
        }
    }
}
