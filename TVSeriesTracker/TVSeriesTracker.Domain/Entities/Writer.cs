using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.ValueObjects;

namespace TVSeriesTracker.Domain.Entities
{
    public class Writer
    {
        public int Id { get; set; }

        public PersonName WriterName { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public ICollection<Series> Series { get; set; }
    }
}