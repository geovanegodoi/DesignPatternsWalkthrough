using System;
namespace Adapter.Client.Interface
{
    public interface ILoggerXml
    {
        void LogInfo(string message);
        void LogException(string exception);
    }
}
