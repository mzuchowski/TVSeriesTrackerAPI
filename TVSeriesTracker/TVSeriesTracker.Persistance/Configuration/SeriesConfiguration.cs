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
    public class SeriesConfiguration : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.FinalYear).HasDefaultValue(null);

            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.Title).HasColumnName("Tile").IsRequired();
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.Description).HasColumnName("Description").IsRequired();
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.PremiereYear).HasColumnName("PremiereYear").IsRequired();
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.SourceId).HasColumnName("SourceId");
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.Language).HasColumnName("Language");
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.CountryOfProduction).HasColumnName("CountryOfProduction");
            builder.OwnsOne(p => p.SeriesProperties).Property(p => p.Runtime).HasColumnName("Runtime");
        }
    }
}