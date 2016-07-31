using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Logging
{
    public class LoggerWrapper
    {
        public static ILogger LogError(string loggerName)
        {
            return new Logger(loggerName);
        }
    }
}
