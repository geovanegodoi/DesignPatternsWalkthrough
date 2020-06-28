using System;
namespace Adapter.Client.Interface
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
