using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Domain.Entities
{
    public class Series
    {
        private string Id { get; set; }

        public string Title { get; set; }

        public string CountryOfProduction { get; set; }

        public string Language { get; set; }

        public string Description { get; set; }

        public int PremiereYear { get; set; }

        public int FinalYear { get; set; }

        public ICollection<Season> Seasons { get; set; }

        public Director Director { get; set; }

        public int Runtime { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ExternalDataSourceDetail SeriesExternalDataSourceDetails { get; set; }

        public int SourceId { get; set; }
    }
}