using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Persistance.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.Title).HasColumnName("Tile").IsRequired();
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.Description).HasColumnName("Description").IsRequired();
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.PremiereYear).HasColumnName("PremiereYear").IsRequired();
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.SourceId).HasColumnName("SourceId");
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.Language).HasColumnName("Language");
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.CountryOfProduction).HasColumnName("CountryOfProduction");
            builder.OwnsOne(p => p.MovieProperties).Property(p => p.Runtime).HasColumnName("Runtime");
        }
    }
}