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
        public List<Flug> GetAllFlights()
        {
            List<Flug> freie_fluege = new List<Flug>();
            Airline swiss = new Airline { Name = "Swiss" };
            Airline tui = new Airline { Name = "TUI" };
            Airline turkish = new Airline { Name = "Turkish" };
            DateTime swiss_abflugzeit = new DateTime(2018, 01, 01, 12, 00, 00, 00);
            DateTime tui_abflugzeit = new DateTime(2017, 01, 01, 12, 00, 00);
            DateTime turkish_abflugzeit = new DateTime(2016, 01, 01, 12, 00, 00);

            Flug zrh_ber = new Flug
            {
                Airline = swiss,
                Name = "LX1291",
                AbflugZeit = swiss_abflugzeit,
                StartOrt = "Zürich",
                ZielOrt = "Berlin",
            };

            Flug bsl_sfo = new Flug
            {
                Airline = tui,
                Name = "TU1234",
                AbflugZeit = tui_abflugzeit,
                StartOrt = "Basel",
                ZielOrt = "San Francisco",
            };

            Flug ist_bkk = new Flug
            {
                Airline = turkish,
                Name = "TK6666",
                AbflugZeit = turkish_abflugzeit,
                StartOrt = "Istanbul",
                ZielOrt = "Bangkok",
            };
        }
    }
}
