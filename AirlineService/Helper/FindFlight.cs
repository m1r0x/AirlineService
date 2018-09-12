using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirlineService.Models;

namespace AirlineService.Helper
{
    public class FindFlight
    {
        public static Dictionary<string, List<Flight>> Search(
                                                       List<Flight> flights,
                                                       DateTime DepartureTime,
                                                       DateTime LandingTime,
                                                       string destination,
                                                       int numberOfSeats)
        {
            Dictionary<string, List<Flight>> free_flights =
                new Dictionary<string, List<Flight>>();

            var flightsWithSeats = FindFlight
               .FlightsWithSeats(flights, numberOfSeats);
            var flightsTo = FindFlight
               .FlightsTo(flightsWithSeats, destination, DepartureTime);
            var flightsBack = FindFlight
               .FlightsBack(flightsWithSeats, flightsTo, LandingTime);

            free_flights.Add("To", flightsTo);
            free_flights.Add("From", flightsBack);
            return free_flights;
        }
        private static List<Flight> FlightsWithSeats(
           List<Flight> raw_flights,
           int numberOfSeats)
        {
            List<Flight> flights = new List<Flight>();
            flights = raw_flights.Where(f => (f.TotalSeats - f.ReservedSeats)
                                        > numberOfSeats).ToList();
            return flights;
        }
        private static List<Flight> FlightsTo(IEnumerable<Flight> raw_flights,
                                                    string destination,
                                                    DateTime startTime)
        {
            List<Flight> flights = new List<Flight>();
            flights = raw_flights.Where(f =>
                                        f.Destination.city.Name == destination
                                        & f.DepartureTime == startTime).ToList();
            return flights;
        }
        // Since this function searches for a flight back the arguments
        // destination and origin get used in reverse.
        private static List<Flight> FlightsBack(List<Flight> raw_flights,
                                                List<Flight> flightsTo,
                                                DateTime endTime)
        {
            List<Flight> flights = new List<Flight>();
            foreach (var flight in flightsTo)
            {
                flights.AddRange(raw_flights.Where(f =>
                                                 f.Destination.city.Name == flight.Origin.city.Name
                                                 & f.Origin.city.Name == flight.Destination.city.Name
                                                 & f.DepartureTime == endTime).ToList());
            }
            return flights;
        }
    }
}