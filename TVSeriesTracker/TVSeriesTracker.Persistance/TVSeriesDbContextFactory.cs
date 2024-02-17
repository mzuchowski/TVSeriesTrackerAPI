using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Persistance
{
    internal class TVSeriesDbContextFactory : DesignTimeDbContextFactoryBase<TVSeriesDbContext>
    {
        protected override TVSeriesDbContext CreateNewInstance(DbContextOptions<TVSeriesDbContext> options)
        {
            return new TVSeriesDbContext(options);
        }
    }
}