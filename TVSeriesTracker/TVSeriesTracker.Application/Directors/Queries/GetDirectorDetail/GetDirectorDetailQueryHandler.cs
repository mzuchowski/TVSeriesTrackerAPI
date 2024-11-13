using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;

namespace TVSeriesTracker.Application.Directors.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQueryHandler : IRequestHandler<GetDirectorDetailQuery, DirectorDetailVm>
    {
        private readonly ITVSeriesDbContext _context;

        public GetDirectorDetailQueryHandler(ITVSeriesDbContext tvSeriesDbContext)
        {
            _context = tvSeriesDbContext;
        }

        public async Task<DirectorDetailVm> Handle(GetDirectorDetailQuery request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Where(p => p.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            if (director == null)
            {
                throw new Exception("Director not found");
            }

            var lastMovie = director.Movies.OrderByDescending(m => m.MovieProperties.PremiereYear).FirstOrDefault();

            var directorVm = new DirectorDetailVm()
            {
                FullName = director.DirectorName.ToString(),
                LastMovieName = lastMovie?.MovieProperties?.Title ?? string.Empty
            };

            return directorVm;
        }
    }
}