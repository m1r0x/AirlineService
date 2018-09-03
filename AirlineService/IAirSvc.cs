using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AirlineService.Models;

namespace AirlineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAirSvc" in both code and config file together.
    [ServiceContract]
    public interface IAirSvc
    {
        [OperationContract]
        Dictionary<string, List<Flight>> GetAllFlights(DateTime DepartureTime,
                                                       DateTime LandingTime,
                                                        string destination,
                                                        int numberOfSeats);
        [OperationContract]
        List<Flight> BookAFlight(Flight flight, int numberOfSeats);
    }
}
