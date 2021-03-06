using System;
using System.IO;
using ILikeTram.Model;
using Microsoft.EntityFrameworkCore;

namespace ILikeTram.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Tram> Trams { get; set; }

        public DbSet<TramStop> TramStops { get; set; }

        public DbSet<Route> TramRoutes { get; set; }

        public string DbPath { get; private set; }

        public DatabaseContext()
        {
            DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TramTable.db");
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedTrams();
        }
    }
}