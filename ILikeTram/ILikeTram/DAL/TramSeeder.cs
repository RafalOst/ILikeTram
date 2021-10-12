using System;
using System.Collections.Generic;
using ILikeTram.Model;
using Microsoft.EntityFrameworkCore;

namespace ILikeTram.DAL
{
    public static class TramSeeder
    {
        public static void SeedTrams(this ModelBuilder builder)
        {
            List<Tram> Trams = new();
            Trams.Add(new Tram()
            {
                ID = 1,
                Name = "PartyTram",
                FirstRun = DateTime.Parse("1999-04-13")
            });

            Trams.Add(new Tram()
            {
                ID = 2,
                Name = "OldTram",
                FirstRun = DateTime.Parse("1980-02-16")
            });

            List<TramStop> TramStops = new();
            TramStops.Add(new TramStop()
            {
                ID = 1,
                Name = "Plac Inwalidow",
                Description = "Hello, are you there?",
                RouteId = 1
            });

            TramStops.Add(new TramStop()
            {
                ID = 2,
                Name = "Meksyk",
                Description = "Hi, are you reading this?",
                RouteId = 2
            });

            List<Route> Routs = new();
            Routs.Add(new Route()
            {
                Id = 1,
                Name = "Stare Miasto",
            });

            Routs.Add(new Route()
            {
                Id = 2,
                Name = "Nowa Huta",
            });

            builder.Entity<Tram>().HasData(Trams);
            builder.Entity<TramStop>().HasData(TramStops);
            builder.Entity<Route>().HasData(Routs);

        }
    }
}
