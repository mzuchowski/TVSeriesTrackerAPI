using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Application.Directors.Commands.CreateDirector
{
    public class CreateDirectorHandler : IRequestHandler<CreateDirectorCommand, int>
    {
        private readonly ITVSeriesDbContext _context;

        public CreateDirectorHandler(ITVSeriesDbContext tvSeriesDbContext)
        {
            _context = tvSeriesDbContext;
        }

        public async Task<int> Handle(CreateDirectorCommand request, CancellationToken cancellationToken)
        {
            Director director = new()
            {
                DirectorName = new Domain.ValueObjects.PersonName() { FirstName = request.FirstName, LastName = request.LastName }
            };

            _context.Directors.Add(director);

            DirectorBiography directorBiography = new()
            {
                DoB = request.DoB,
                PlaceOfBirth = request.PlaceOfBirth,
                DirectorId = director.Id
            };

            _context.DirectorBiographies.Add(directorBiography);

            await _context.SaveChangesAsync(cancellationToken);

            return director.Id;
        }
    }
}