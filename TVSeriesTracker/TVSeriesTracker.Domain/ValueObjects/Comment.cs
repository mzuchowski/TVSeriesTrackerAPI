using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Common;

namespace TVSeriesTracker.Domain.ValueObjects
{
    public class Comment : ValueObject
    {
        public string CommentText { get; set; }

        public DateTime Added { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CommentText;
            yield return Added;
        }
    }
}