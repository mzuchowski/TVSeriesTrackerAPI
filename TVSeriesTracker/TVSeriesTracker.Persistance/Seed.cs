using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;
using TVSeriesTracker.Domain.Entities;

namespace TVSeriesTracker.Persistance
{
    public static class Seed
    {
        public static void SeedDate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>(d =>
            {
                d.HasData(new Director()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Michał Zuchowski"
                });
                d.OwnsOne(d => d.DirectorName).HasData(new { DirectorId = 1, FirstName = "Stanley", LastName = "Kubrick" }); //Because DirectorName (type: PersonName) is ValueObject
            }
            );

            modelBuilder.Entity<Movie>(d =>
            {
                d.HasData(new Movie()
                {
                    Id = 1,
                    DirectorId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Michał Zuchowski"
                });
                d.OwnsOne(d => d.MovieProperties)
                    .HasData(new
                    {
                        MovieId = 1,
                        Title = "The Shining",
                        Description = "Example description",
                        PremiereYear = 1980,
                        Language = "English",
                        CountryOfProduction = "USA",
                        Runtime = 146
                    }); //Because MovieProperties (type: VideoProperties) is ValueObject
            }
            );

            modelBuilder.Entity<Movie>(d =>
            {
                d.HasData(new Movie()
                {
                    Id = 2,
                    DirectorId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Michał Zuchowski"
                });
                d.OwnsOne(d => d.MovieProperties)
                    .HasData(new
                    {
                        MovieId = 2,
                        Title = "A Clockwork Orange",
                        Description = "Example description",
                        PremiereYear = 1971,
                        Language = "English",
                        CountryOfProduction = "USA",
                        Runtime = 136
                    }); //Because MovieProperties (type: VideoProperties) is ValueObject
            }
            );
        }
    }
}