using Microsoft.EntityFrameworkCore;

namespace TVSeriesTracker.Persistance
{
    public class TVSeriesDbContext : DbContext
    {
        public TVSeriesDbContext(DbContextOptions<TVSeriesDbContext> options) : base(options)
        {
        }
    }
}