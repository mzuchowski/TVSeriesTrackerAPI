using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;
using TVSeriesTracker.Application.Directors.Commands.CreateDirector;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Application.Directors.Commands.DeleteDirector
{
    public class DeleteDirectorCommandHandler : IRequestHandler<DeleteDirectorCommand>
    {
        private readonly ITVSeriesDbContext _context;

        public DeleteDirectorCommandHandler(ITVSeriesDbContext tvSeriesDbContext)
        {
            _context = tvSeriesDbContext;
        }

        public async Task Handle(DeleteDirectorCommand request, CancellationToken cancellationToken)
        {
            var director = await _context.Directors.Where(d => d.Id == request.DirectorId).FirstOrDefaultAsync(cancellationToken);

            _context.Directors.Remove(director);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}