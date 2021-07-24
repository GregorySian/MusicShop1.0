using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using MusicHub.Data;
using System.Linq;
using MusicHub.Models;
using System;

namespace MusicHub.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider)
        {
            ApplicationDbContext context = new ApplicationDbContext (serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            { 
            if (context.Albums.Any())
            {
                return;
            }
                context.Albums.AddRange(
                    new Album
                    {
                        Id = 1,
                        Title = "Hate Crew Deathroll",
                        Artist = "Children Of Bodom",
                        Genre = "Extreme Metal",
                        ImageUrl = "http://metalstorm.net/images/albums/4/484.jpg",
                        Year = 2003,
                        Price = 11,
                        Description = null
                    },
                    new Album
                    {
                        Id = 2,
                        Title = "What the Dead Men Say",
                        Artist = "Trivium",
                        Genre = "Metal",
                        ImageUrl = "http://metalstorm.net/images/albums/1/108622.jpg",
                        Price = 15,
                        Year = 2020,
                        Description = null
                    },
                    new Album
                    {
                        Id = 3,
                        Title = "The Book of Souls",
                        Artist = "Iron Maiden",
                        Genre = "Heavy Metal",
                        ImageUrl = "http://metalstorm.net/images/albums/8/83391.jpg",
                        Price = 13,
                        Year = 2015,
                        Description = null
                    },
                     new Album
                     {
                         Id = 4,
                         Title = "Metropolis Pt. 2: Scenes From A Memory ",
                         Artist = "Dream Theater",
                         Genre = "Progressive metal",
                         ImageUrl = "http://metalstorm.net/images/albums/6/608.jpg",
                         Price = 10,
                         Year = 1999,
                         Description = null
                     },
                        new Album
                        {
                            Id = 5,
                            Title = "Master of Puppets ",
                            Artist = "Metallica",
                            Genre = "Thrash metal",
                            ImageUrl = "http://metalstorm.net/images/albums/1/1221.jpg",
                            Price = 9,
                            Year = 1986,
                            Description = null
                        },
                         new Album
                         {
                             Id = 6,
                             Title = "Hellfire Club ",
                             Artist = "Edguy",
                             Genre = "Power Metal",
                             ImageUrl = "http://metalstorm.net/images/albums/1/1986.jpg",
                             Price = 11,
                             Year = 2004,
                             Description = null
                         }
              );
                context.SaveChanges();
            }
        }
    }
}