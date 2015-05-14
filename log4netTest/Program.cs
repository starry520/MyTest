using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.DOMConfigurator(ConfigFile = "log4net.config", ConfigFileExtension = "config", Watch = true)]

namespace log4netTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //将log4net.config 复制到bin下面
            ILog log = log4net.LogManager.GetLogger("MyLoggerTest");
            log.Error("error",new Exception(" error 信息 。。。"));
            log.Fatal("fatal", new Exception(" fatal 信息 。。。"));
            log.Info("info", new Exception(" info 信息 。。。"));
            log.Debug("debug", new Exception(" debug 信息 。。。"));
            log.Warn("warn", new Exception(" warn 信息 。。。"));
            Console.Read();
        
        }
    }
}
