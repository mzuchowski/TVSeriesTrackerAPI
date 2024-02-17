using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TVSeriesTracker.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TVSeriesDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TVSeriesTrackerDatabase")));

            return services;
        }
    }
}