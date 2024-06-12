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
    public class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.OwnsOne(p => p.WriterName).Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
            builder.OwnsOne(p => p.WriterName).Property(p => p.LastName).HasColumnName("LastName").IsRequired();
        }
    }
}