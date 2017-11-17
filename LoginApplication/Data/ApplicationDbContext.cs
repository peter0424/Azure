using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LoginApplication.Models;

namespace LoginApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Booking> Booking { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Flight>().ToTable("Flight");
            builder.Entity<Passenger>().ToTable("Passenger");
            builder.Entity<Booking>().ToTable("Booking");
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Flight.Any())
            {
                return;   // DB has been seeded
            }

            var flights = new Flight[]
            {
                new Flight
                {
                    FlightNo = "AK1007",Origin="Kiev",Destination="Lviv",
                    Departure = DateTime.Parse("2017-11-02 11:00"),Arrival=DateTime.Parse("2017-11-02 13:30"),
                },
                new Flight
                {
                    FlightNo = "AK1010",Origin="Dnipro",Destination="Kiev",
                    Departure = DateTime.Parse("2017-11-02 13:00"),Arrival=DateTime.Parse("2017-11-02 15:30"),
                },
                new Flight
                {
                    FlightNo = "AK1011",Origin="Vinnytsia",Destination="Mariupol",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1011",Origin="London",Destination="Mariupol",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1011",Origin="Pais",Destination="Mariupol",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1011",Origin="Berlin",Destination="Mariupol",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1012",Origin="Kiev",Destination="Lviv",
                    Departure = DateTime.Parse("2017-11-02 11:00"),Arrival=DateTime.Parse("2017-11-02 13:30"),
                },
                new Flight
                {
                    FlightNo = "AK1008",Origin="Vienna",Destination="Odessa",
                    Departure = DateTime.Parse("2017-11-02 11:00"),Arrival=DateTime.Parse("2017-11-02 13:30"),
                },
                new Flight
                {
                    FlightNo = "AK1013",Origin="Riga",Destination="Odessa",
                    Departure = DateTime.Parse("2017-11-02 12:00"),Arrival=DateTime.Parse("2017-11-02 14:30"),
                },
                new Flight
                {
                    FlightNo = "AK1014",Origin="Stockholm",Destination="Odessa",
                    Departure = DateTime.Parse("2017-11-02 14:00"),Arrival=DateTime.Parse("2017-11-02 16:30"),
                },
                new Flight
                {
                    FlightNo = "AK1015",Origin="Amsterdam",Destination="Odessa",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1009",Origin="Kiev",Destination="Kharkiv",
                    Departure = DateTime.Parse("2017-11-02 11:00"),Arrival=DateTime.Parse("2017-11-02 13:30"),
                },
                new Flight
                {
                    FlightNo = "AK1016",Origin="Odessa",Destination="Kharkiv",
                    Departure = DateTime.Parse("2017-11-02 15:00"),Arrival=DateTime.Parse("2017-11-02 17:30"),
                },
                new Flight
                {
                    FlightNo = "AK1017",Origin="Vienna",Destination="Riga",
                    Departure = DateTime.Parse("2017-11-02 19:00"),Arrival=DateTime.Parse("2017-11-02 21:30"),
                },
                new Flight
                {
                    FlightNo = "AK1018",Origin="Kiev",Destination="Kharkiv",
                    Departure = DateTime.Parse("2017-11-02 20:00"),Arrival=DateTime.Parse("2017-11-02 22:30"),
                },
                new Flight
                {
                    FlightNo = "AK1101",Origin="Odessa",Destination="Kiev",
                    Departure = DateTime.Parse("2017-11-02 09:00"),Arrival=DateTime.Parse("2017-11-02 11:30"),
                },
                new Flight
                {
                    FlightNo = "AK1102",Origin="Lviv",Destination="Odessa",
                    Departure = DateTime.Parse("2017-11-02 10:00"),Arrival=DateTime.Parse("2017-11-02 12:30"),
                },
                new Flight
                {
                    FlightNo = "AK1103",Origin="Vilnius",Destination="Kiev",
                    Departure = DateTime.Parse("2017-11-02 12:00"),Arrival=DateTime.Parse("2017-11-02 14:30"),
                },
                new Flight
                {
                    FlightNo = "AK1104",Origin="Odessa",Destination="Vilnius",
                    Departure = DateTime.Parse("2017-11-02 13:00"),Arrival=DateTime.Parse("2017-11-02 15:30"),
                }
            };
            foreach (Flight f in flights)
            {
                context.Flight.Add(f);
            }
            context.SaveChanges();
        }
    }
}