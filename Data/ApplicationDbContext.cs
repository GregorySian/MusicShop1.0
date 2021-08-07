using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicHub.Models;
using MusicHub.Models.Order;

namespace MusicHub.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet <Song> Songs { get; set; }
 
        public DbSet<Orders> Orders { get; set; }

        //modelBuilder.Entity<Album>()
        //    .HasRequired(e => e.Genre)
        //    .WithMany(d => d.Albums);
    }
}
