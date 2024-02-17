﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }

        public string Nick { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<MovieComment> MovieComments { get; set; }

        public ICollection<SeriesComment> SeriesComments { get; set; }

        public ICollection<TrackedMovie> TrackedMovies { get; set; }

        public ICollection<TrackedSeries> TrackedSeries { get; set; }
    }
}