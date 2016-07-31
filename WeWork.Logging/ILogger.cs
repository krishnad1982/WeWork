using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeWork.Logging
{
    public interface ILogger
    {
        void Error(string message,Exception ex);
        void Info(string message, Exception ex);
        void Warning(string message, Exception ex);
        void Fatal(string message, Exception ex);
        void Debug(string message, Exception ex);
    }
}
