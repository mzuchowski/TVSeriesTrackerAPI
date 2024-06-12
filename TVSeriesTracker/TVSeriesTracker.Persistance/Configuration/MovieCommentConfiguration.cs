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
    public class MovieCommentConfiguration : IEntityTypeConfiguration<MovieComment>
    {
        public void Configure(EntityTypeBuilder<MovieComment> builder)
        {
            builder.OwnsOne(p => p.CommentContent).Property(p => p.CommentText).HasColumnName("CommentContent");
            builder.OwnsOne(p => p.CommentContent).Property(p => p.Added).HasColumnName("Added").HasDefaultValue(DateTime.Now);
        }
    }
}