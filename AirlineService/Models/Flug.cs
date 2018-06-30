using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AirlineService.Models
{
    [DataContract]
    public class Flug
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public Airline Airline { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string StartOrt { get; set; }
        [DataMember]
        public string ZielOrt { get; set; }
        [DataMember]
        public DateTime AbflugZeit { get; set; }

    }
}