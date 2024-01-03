﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.ValueObjects;

namespace TVSeriesTracker.Domain.Entities
{
    public class SeriesComment
    {
        public int Id { get; set; }

        public Series Series { get; set; }

        public Episode Episode { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public Comment Comment { get; set; }
    }
}