using System;
namespace NetCoreLoggerAdapter
{
    public interface ILoggerServiceAdapter<T> 
    {
        void LogInformation(string message);

        void LogError(Exception ex, string message, params object[] args);
    }
}
