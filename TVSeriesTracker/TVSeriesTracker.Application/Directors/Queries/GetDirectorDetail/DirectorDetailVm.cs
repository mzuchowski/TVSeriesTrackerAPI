using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Application.Directors.Queries.GetDirectorDetail
{
    public class DirectorDetailVm
    {
        public string FullName { get; set; }
        public string LastMovieName { get; set; }
    }
}