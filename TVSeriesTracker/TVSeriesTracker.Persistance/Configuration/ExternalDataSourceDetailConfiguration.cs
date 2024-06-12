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
    public class ExternalDataSourceDetailConfiguration : IEntityTypeConfiguration<ExternalDataSourceDetail>
    {
        public void Configure(EntityTypeBuilder<ExternalDataSourceDetail> builder)
        {
        }
    }
}