using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.Entities
{
    public class ExternalDataSourceDetail : AuditableEntity
    {
        public int Id { get; set; }

        public int SourceId { get; set; }
    }
}