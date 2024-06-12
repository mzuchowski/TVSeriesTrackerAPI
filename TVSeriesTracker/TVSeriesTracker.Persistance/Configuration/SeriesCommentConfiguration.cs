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
    public class SeriesCommentConfiguration : IEntityTypeConfiguration<SeriesComment>
    {
        public void Configure(EntityTypeBuilder<SeriesComment> builder)
        {
            builder.OwnsOne(p => p.CommentContent).Property(p => p.CommentText).HasColumnName("CommentContent");
            builder.OwnsOne(p => p.CommentContent).Property(p => p.Added).HasColumnName("Added").HasDefaultValue(DateTime.Now);
        }
    }
}