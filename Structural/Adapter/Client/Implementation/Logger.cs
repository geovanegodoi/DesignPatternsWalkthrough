using System;
using Adapter.Client.Interface;

namespace Adapter.Client.Implementation
{
    public class Logger : ILogger
    {
        public Logger()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log default : {message}");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Log default : {exception.Message}");
        }
    }
}