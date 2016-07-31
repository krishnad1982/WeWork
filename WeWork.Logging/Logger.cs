using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace WeWork.Logging
{
    public class Logger: ILogger {
        private readonly ILog _log4NetAdapter;

        public Logger(string loggerName) {
            _log4NetAdapter = LogManager.GetLogger(loggerName);
        }

        public void Error(string message, Exception ex) {
            _log4NetAdapter.Error(message, ex);
        }

        public void Info(string message, Exception ex) {
            _log4NetAdapter.Info(message, ex);
        }

        public void Warning(string message, Exception ex) {
            _log4NetAdapter.Warn(message, ex);
        }

        public void Fatal(string message, Exception ex) {
            _log4NetAdapter.Fatal(message, ex);
        }

        public void Debug(string message, Exception ex) {
            _log4NetAdapter.Debug(message, ex);
        }
    }
}
