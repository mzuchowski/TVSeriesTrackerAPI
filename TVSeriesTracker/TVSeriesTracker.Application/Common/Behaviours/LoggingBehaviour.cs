using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger<TRequest> _logger;

        public LoggingBehaviour(ILogger<TRequest> logger)
        {
            _logger = logger;
        }

        public Task Process(TRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

            Console.WriteLine("TVSeriesTracker Request: {requestName} {@Request}", requestName, request);

            return Task.CompletedTask;
        }
    }
}