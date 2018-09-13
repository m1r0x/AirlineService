using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AirlineService.Models
{
    [DataContract]
    public class Airline
    {
        [DataMember(IsRequired = true)]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}