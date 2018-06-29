using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirlineService.Models;

namespace AirlineService.DB
{
    public class Context : DbContext
    {
        public Context() : base("AirlineDB") { }
        public DbSet<Airline> Doctors { get; set; }
    }
}