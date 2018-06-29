using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirlineService.Models;

namespace AirlineService.DB
{
    public class AirlineDB
    {
        public List<Airline> GetAllAirlines()
        {
            using (Context ctx = new Context())
            {
                return ctx.Airline.ToList();
            }
        }
    }
}