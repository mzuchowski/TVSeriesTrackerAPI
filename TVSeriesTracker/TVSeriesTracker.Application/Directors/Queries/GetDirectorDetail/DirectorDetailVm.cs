using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Mappings;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Application.Directors.Queries.GetDirectorDetail
{
    public class DirectorDetailVm : IMapFrom<Director>
    {
        public string FullName { get; set; }
        public string LastMovieName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Director, DirectorDetailVm>()
                .ForMember(d => d.FullName, map => map.MapFrom(s => s.DirectorName.ToString()))
                .ForMember(d => d.LastMovieName, map => map.MapFrom<LastMovieNameResolver>());
        }

        private class LastMovieNameResolver : IValueResolver<Director, object, string>
        {
            public string Resolve(Director source, object destination, string destMember, ResolutionContext context)
            {
                if (source.Movies is not null && source.Movies.Any())
                {
                    var lastMovie = source.Movies.OrderByDescending(m => m.MovieProperties.PremiereYear).FirstOrDefault();
                    return lastMovie.MovieProperties.Title;
                }
                return string.Empty;
            }
        }
    }
}