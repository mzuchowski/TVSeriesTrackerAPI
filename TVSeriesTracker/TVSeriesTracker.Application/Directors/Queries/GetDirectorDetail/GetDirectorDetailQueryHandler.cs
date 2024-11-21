using AutoMapper;
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
        private IMapper _mapper;

        public GetDirectorDetailQueryHandler(ITVSeriesDbContext tvSeriesDbContext, IMapper mapper)
        {
            _context = tvSeriesDbContext;
            _mapper = mapper;
        }

        public async Task<DirectorDetailVm> Handle(GetDirectorDetailQuery request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Include(p => p.Movies).Where(p => p.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            if (director == null)
            {
                throw new Exception("Director not found");
            }

            var directorVm = _mapper.Map<DirectorDetailVm>(director);

            return directorVm;
        }
    }
}