using LibDemo.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibDemo.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Library> Libraries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibraryFeature>().HasKey(lf => new { lf.FeatureId, lf.LibraryId });
        }
    }
}
