using System;

namespace CSharp6.Logger
{
    public class ConsoleLogger
    {
        public string GetLogMessage(DateTime timestamp, LogLevel level, string message, string stackTrace)
        {
            if (stackTrace == null)
            {
                return string.Format("{0:yyyy-MM-dd HH:mm:ss.ffff} - {1}: {2}", timestamp, level, message);
            }
            return string.Format("{0:yyyy-MM-dd HH:mm:ss.ffff} - {1}: {2}\n{3}", timestamp, level, message, stackTrace);
        }

        public void Write(LogLevel level, string message)
        {
            DateTime timestamp = DateTime.Now;
            var logMessage = GetLogMessage(timestamp, level, message, null);
            Console.WriteLine(logMessage);
        }

        public void Write(LogLevel level, Exception ex)
        {
            string message = ex != null ? ex.Message : string.Empty;
            string stackTrace = ex != null ? ex.StackTrace : null;

            DateTime timestamp = DateTime.Now;
            var logMessage = GetLogMessage(timestamp, level, message, stackTrace);
            Console.WriteLine(logMessage);
        }
    }
}
