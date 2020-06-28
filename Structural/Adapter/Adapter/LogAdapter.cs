using System;
using Adapter.Client.Interface;

namespace Adapter.Adapter
{
    public class LogAdapter : ILogger
    {
        private readonly ILoggerXml _loggerXml;

        public LogAdapter(ILoggerXml loggerXml)
        {
            _loggerXml = loggerXml;
        }

        public void Log(string message)
        {
            _loggerXml.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _loggerXml.LogException(exception.Message);
        }
    }
}
