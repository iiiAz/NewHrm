using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
namespace HRMUtility
{
    public class LogHelper
    {
        public static void WriteLog(Type t, Exception ex)
        {
            ILog log = LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        public static void WriteLog(Type t, string msg)
        {
            ILog log = LogManager.GetLogger(t);
            log.Error(msg);
        }
    }
}
