using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Domain.Entities
{
    public class TrackedMovie
    {
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public TrackingStatus Status { get; set; }

        public int TrackerId { get; set; }

        public Tracker Tracker { get; set; }
    }
}