using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;
using TVSeriesTracker.Infrastructure.ExternalAPI.OMDB;
using TVSeriesTracker.Infrastructure.FileStore;
using TVSeriesTracker.Infrastructure.Services;

namespace TVSeriesTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("OmdbClient", options =>
            {
                options.BaseAddress = new Uri(configuration["Omdb:BaseUrl"]);
                options.Timeout = new TimeSpan(0, 0, 10);
                options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

            services.AddScoped<IOmdbClient, OmdbClient>();

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IFileWrapper, FileWrapper>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
            return services;
        }
    }
}