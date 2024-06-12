using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TVSeriesTracker.Application.Interfaces;
using TVSeriesTracker.Domain.Common;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Persistance
{
    public class TVSeriesDbContext : DbContext
    {
        private readonly IDateTime _dateTime;

        public TVSeriesDbContext(DbContextOptions<TVSeriesDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<ExternalDataSourceDetail> ExternalDataSourceDetails { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieComment> MoviesComment { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Series> Seriess { get; set; }
        public DbSet<SeriesComment> SeriesComments { get; set; }
        public DbSet<TrackedMovie> TrackedMovies { get; set; }
        public DbSet<TrackedSeries> TrackedSeries { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<TrackingStatus> TrackingStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedDate(_dateTime);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;

                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}