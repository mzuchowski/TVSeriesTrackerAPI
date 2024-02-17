using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;
using TVSeriesTracker.Domain.ValueObjects;

namespace TVSeriesTracker.Domain.Entities
{
    public class Series : AuditableEntity
    {
        public int Id { get; set; }

        public VideoProperties SeriesProperies { get; set; }

        public int FinalYear { get; set; }

        public ICollection<Season> Seasons { get; set; }

        public Director Director { get; set; }

        public Writer Writer { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ICollection<SeriesComment> SeriesComments { get; set; }

        public ICollection<TrackedSeries> Tracked { get; set; }

        public ExternalDataSourceDetail SeriesExternalDataSourceDetails { get; set; }
    }
}