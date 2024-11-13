using TVSeriesTracker.Application.Common.Interfaces;

namespace TVSeriesTracker.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}