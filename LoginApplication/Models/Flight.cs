using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApplication.Models
{
    //public class FlightContext : DbContext
    //{
    //    public FlightContext(DbContextOptions<FlightContext> options)
    //        : base(options)
    //    { }
    //
    //    public DbSet<Flight> Flights { get; set; }
    //}
    public class Flight
    {
        public int FlightID { get; set; }
        [Display(Name = "Flight No")]
        public string FlightNo { get; set; }
        [Display(Name = "Flight Origin")]
        public string Origin { get; set; }
        [Display(Name = "Flight Destination")]
        public string Destination { get; set; }
        [Display(Name = "Flight Departure")]
        public DateTime Departure { get; set; }
        [Display(Name = "Flight Arrival")]
        public DateTime Arrival { get; set; }

        //public List<Flight> Flights { get; set; }
    }
}
