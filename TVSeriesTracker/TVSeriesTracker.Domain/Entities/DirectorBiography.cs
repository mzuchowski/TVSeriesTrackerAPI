using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class DirectorBiography : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime DoB { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}