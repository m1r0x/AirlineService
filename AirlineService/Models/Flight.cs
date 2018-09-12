using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AirlineService.Models
{
    [DataContract]
    public class Flight
    {
        [DataMember(IsRequired = true)]
        public int ID { get; set; }
        [DataMember]
        public Airline Airline { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public City Origin { get; set; }
        [DataMember]
        public City Destination { get; set; }
        [DataMember]
        public DateTime DepartureTime { get; set; }
        [DataMember]
        public int TotalSeats { get; set; }
        [DataMember]
        public int ReservedSeats { get; set; }

    }
}