using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class Tracker : AuditableEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public TrackedMovie TrackedMovies { get; set; }

        public TrackedSeries TrackedSeries { get; set; }

        public DateTime Created { get; set; }
    }
}