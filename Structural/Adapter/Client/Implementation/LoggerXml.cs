using System;
using Adapter.Client.Interface;

namespace Adapter.Client.Implementation
{
    public class LoggerXml : ILoggerXml
    {
        public LoggerXml()
        {
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Log xml : {message}");
        }

        public void LogException(string exception)
        {
            Console.WriteLine($"Log xml : {exception}");
        }
    }
}
