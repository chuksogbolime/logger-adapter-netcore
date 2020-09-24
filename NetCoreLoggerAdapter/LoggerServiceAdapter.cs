using System;
using Microsoft.Extensions.Logging;

namespace NetCoreLoggerAdapter
{
    public class LoggerServiceAdapter<T> : ILoggerServiceAdapter<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerServiceAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogError(Exception ex, string message, params object[] args)
        {
            _logger.LogError(ex, message, args);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
