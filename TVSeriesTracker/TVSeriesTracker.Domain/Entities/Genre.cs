using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class Genre : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public ICollection<Series> Series { get; set; }
    }
}