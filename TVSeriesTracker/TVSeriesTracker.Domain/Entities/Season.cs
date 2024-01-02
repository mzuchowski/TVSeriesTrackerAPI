using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Domain.Entities
{
    public class Season
    {
        public int Id { get; set; }

        public int SeasonNumber { get; set; }

        public ICollection<Episode> Episodes { get; set; }

        public int SeriesId { get; set; }

        public Series Series { get; set; }
    }
}