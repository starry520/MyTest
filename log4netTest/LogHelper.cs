using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netTest
{
    public class LogHelper
    {
        public static readonly log4net.ILog myLogger = log4net.LogManager.GetLogger("loginfo");
  
        public static void LogInfo(string info)
        {
            if (myLogger.IsInfoEnabled)
            {
                myLogger.Info(info);
            }
        }

        public static void LogError(string info, Exception ex)
        {
            if (myLogger.IsErrorEnabled)
            {
                myLogger.Error(info, ex);
            }
        }
    }
}
