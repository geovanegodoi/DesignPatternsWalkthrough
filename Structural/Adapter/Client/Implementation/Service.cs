using System;
using Adapter.Client.Interface;

namespace Adapter.Client.Implementation
{
    public class Service
    {
        private readonly ILogger _logger;

        public Service(ILogger logger)
        {
            _logger = logger;
        }


        public void DoTransaction()
        {
            _logger.Log(message: "Transaction realized successfully");
            _logger.LogError(exception: new Exception("Exception generated"));
        }
    }
}
