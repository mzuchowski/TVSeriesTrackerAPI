using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Persistance.Configuration
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.OwnsOne(p => p.DirectorName).Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
            builder.OwnsOne(p => p.DirectorName).Property(p => p.LastName).HasColumnName("LastName").IsRequired();
        }
    }
}