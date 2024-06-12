using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Persistance.Configuration
{
    public class TrackerMovieConfiguration : IEntityTypeConfiguration<TrackedMovie>
    {
        public void Configure(EntityTypeBuilder<TrackedMovie> builder)
        {
        }
    }
}