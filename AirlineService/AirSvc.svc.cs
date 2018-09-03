using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AirlineService.Models;

namespace AirlineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AirSvc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AirSvc.svc or AirSvc.svc.cs at the Solution Explorer and start debugging.
    public class AirSvc : IAirSvc
    {
        public List<Flight> flights = new List<Flight>();

        public Flight BookAFlight(Flight flight,
                                    int numberOfSeats)
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

        public Dictionary<string, List<Flight>> GetAllFlights(DateTime DepartureTime,
                                                                DateTime LandingTime, string Destination, int numberOfSeats)
        {
        
            public Dictionary<string, List<Flight>> freeFlights = new Dictionary<string, List<Flight>>();


            freeFlights = FindFlight.Search(this.flights, DepartureTime,
                                        LandingTime, string Destination, int numberOfSeats);

            return freeFlights;
        }




        public AirlineService()
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

            Flight zrh_ber = new Flight
            {
                Airline = swiss,
                Name = "LX1291",
                DepartureTime = swiss_departure,
                Origin = "Zürich",
                Destination = "Berlin",
                TotalSeats = 80,
                ReservedSeats = 0,

            };

            Flight bsl_sfo = new Flight
            {
                Airline = tui,
                Name = "TU1234",
                DepartureTime = tui_departure,
                Origin = "Basel",
                Destination = "San Francisco",
                TotalSeats = 95,
                ReservedSeats = 0,
            };

            Flight ist_bkk = new Flight
            {
                Airline = turkish,
                Name = "TK6666",
                DepartureTime = turkish_departure,
                Origin = "Istanbul",
                Destination = "Bangkok",
                TotalSeats = 15,
                ReservedSeats = 0,
            };

            Flight zrh_las = new Flight
            {
                Airline = lufthansa,
                Name = "LH1337",
                DepartureTime = lufthansa_departure,
                Origin = "Zürich",
                Destination = "Las Vegas",
                TotalSeats = 280,
                ReservedSeats = 0,
            };

            this.flights.Add(ist_bkk);
            this.flights.Add(bsl_sfo);
            this.flights.Add(zrh_ber);
            this.flights.Add(zrh_las);

        }

        
    }
}
