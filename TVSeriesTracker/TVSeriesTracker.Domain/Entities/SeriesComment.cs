using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;
using TVSeriesTracker.Domain.ValueObjects;

namespace TVSeriesTracker.Domain.Entities
{
    public class SeriesComment : AuditableEntity
    {
        public int Id { get; set; }

        public Series Series { get; set; }

        public Episode Episode { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public Comment CommentContent { get; set; }
    }
}