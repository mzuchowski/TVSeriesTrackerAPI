using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.ValueObjects
{
    public class VideoProperties : ValueObject
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string CountryOfProduction { get; set; }

        public string Language { get; set; }

        public int PremiereYear { get; set; }

        public int Runtime { get; set; }

        public int? SourceId { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Title;
            yield return Description;
            yield return CountryOfProduction;
            yield return Language;
            yield return PremiereYear;
            yield return Runtime;
            yield return SourceId;
        }
    }
}