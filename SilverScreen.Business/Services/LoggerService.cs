using System;
using System.IO;

namespace SilverScreen.Business.Services
{
    public class LoggerService
    {
        private readonly string _logPath;

        public LoggerService()
        {
            _logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");
        }

        public void LogError(string message, Exception ex = null)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {message}\n";
            if (ex != null)
            {
                logEntry += $"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
                if (ex.InnerException != null)
                {
                    logEntry += $"InnerException: {ex.InnerException.Message}\n";
                }
            }
            logEntry += "--------------------------------------------------\n";

            try
            {
                File.AppendAllText(_logPath, logEntry);
            }
            catch
            {
                // Fallback to console if file logging fails
                Console.WriteLine("Logging to file failed.");
            }
        }

        public void LogInfo(string message)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] INFO: {message}\n";
            try
            {
                File.AppendAllText(_logPath, logEntry);
            }
            catch { }
        }
    }
}
