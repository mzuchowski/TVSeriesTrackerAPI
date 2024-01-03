using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.ValueObjects;

namespace TVSeriesTracker.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public VideoProperties MovieProperties { get; set; }

        public int? DirectorId { get; set; }

        public Director Director { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ExternalDataSourceDetail MovieExternalDataSourceDetails { get; set; }
    }
}