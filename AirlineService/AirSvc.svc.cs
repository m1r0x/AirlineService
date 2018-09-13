using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AirlineService.Models;
using AirlineService.Helper;

namespace AirlineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AirSvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AirSvc.svc or AirSvc.svc.cs at the Solution Explorer and start debugging.

    public class AirSvc : IAirSvc
    {
        public List<Flight> flights = new List<Flight>();

        Flight IAirSvc.BookAFlight(Flight flight, int numberOfSeats)
        {
            Flight flightToBook = this.flights.Single(f => f == flight);
            if (flightToBook != null)
            {
                flightToBook.ReservedSeats += numberOfSeats;

                return flightToBook;
            }
            else
            {
                return flight;
            }
        }

        Dictionary<string, List<Flight>> IAirSvc.GetFlights(DateTime DepartureTime, DateTime LandingTime, string destination, int numberOfSeats)
        {
            Dictionary<string, List<Flight>> freeFlights = new Dictionary<string, List<Flight>>();

            freeFlights = FindFlight.Search(flights, DepartureTime, LandingTime, destination, numberOfSeats);

            return freeFlights;
        }


        public ICollection<Flight> GetAllFlight(DateTime DepartureTime, DateTime LandingTime, string destination, int numberOfSeats)
        {
            return flights;
        }

        public AirSvc()
        {
            List<Flight> flights = new List<Flight>();

            Airline swiss = new Airline { Name = "Swiss" };
            Airline tui = new Airline { Name = "TUI" };
            Airline turkish = new Airline { Name = "Turkish" };
            Airline lufthansa = new Airline { Name = "Lufthansa" };

            DateTime swiss_departure = new DateTime(2018, 01, 01, 12, 00, 00, 00);
            DateTime tui_departure = new DateTime(2017, 01, 01, 12, 00, 00);
            DateTime turkish_departure = new DateTime(2016, 01, 01, 12, 00, 00);
            DateTime lufthansa_departure = new DateTime(2018, 08, 14, 12, 00, 00, 00);

            City zurich = new City { Name = "Zurich" };
            City berlin = new City { Name = "Berlin" };
            City basel = new City { Name = "Basel" };
            City sanfrancisco = new City { Name = "San Francisco" };
            City istanbul = new City { Name = "Istanbul" };
            City bangkok = new City { Name = "Bangkok" };
            City lasvegas = new City { Name = "Las Vegas" };

            Flight zrh_ber = new Flight
            {
                Airline = swiss,
                Name = "LX1291",
                DepartureTime = swiss_departure,
                Origin = zurich,
                Destination = berlin,
                TotalSeats = 80,
                ReservedSeats = 0,

            };

            Flight bsl_sfo = new Flight
            {
                Airline = tui,
                Name = "TU1234",
                DepartureTime = tui_departure,
                Origin = basel,
                Destination = sanfrancisco,
                TotalSeats = 95,
                ReservedSeats = 0,
            };

            Flight ist_bkk = new Flight
            {
                Airline = turkish,
                Name = "TK6666",
                DepartureTime = turkish_departure,
                Origin = istanbul,
                Destination = bangkok,
                TotalSeats = 15,
                ReservedSeats = 0,
            };

            Flight zrh_las = new Flight
            {
                Airline = lufthansa,
                Name = "LH1337",
                DepartureTime = lufthansa_departure,
                Origin = zurich,
                Destination = lasvegas,
                TotalSeats = 280,
                ReservedSeats = 0,
            };

            flights.Add(ist_bkk);
            flights.Add(bsl_sfo);
            flights.Add(zrh_ber);
            flights.Add(zrh_las);

        }
    }
}
