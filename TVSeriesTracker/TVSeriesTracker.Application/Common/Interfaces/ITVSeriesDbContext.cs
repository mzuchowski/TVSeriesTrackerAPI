using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Application.Common.Interfaces
{
    public interface ITVSeriesDbContext
    {
        DbSet<Director> Directors { get; set; }
        DbSet<Episode> Episodes { get; set; }
        DbSet<ExternalDataSourceDetail> ExternalDataSourceDetails { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<MovieComment> MoviesComment { get; set; }
        DbSet<Season> Seasons { get; set; }
        DbSet<Series> Seriess { get; set; }
        DbSet<SeriesComment> SeriesComments { get; set; }
        DbSet<TrackedMovie> TrackedMovies { get; set; }
        DbSet<TrackedSeries> TrackedSeries { get; set; }
        DbSet<Tracker> Trackers { get; set; }
        DbSet<TrackingStatus> TrackingStatuses { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Writer> Writers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}