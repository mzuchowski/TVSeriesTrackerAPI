using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class TrackedSeries : AuditableEntity
    {
        public int SeriesId { get; set; }

        public Series Series { get; set; }

        public int EpisodeId { get; set; }

        public Episode Episode { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public TrackingStatus Status { get; set; }

        public int TrackerId { get; set; }

        public Tracker Tracker { get; set; }
    }
}