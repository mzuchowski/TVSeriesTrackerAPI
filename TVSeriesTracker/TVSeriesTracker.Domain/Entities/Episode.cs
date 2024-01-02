using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Domain.Entities
{
    public class Episode
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Runtime { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }
    }
}