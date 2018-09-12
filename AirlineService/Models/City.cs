using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AirlineService.Models
{
    [DataContract]
    public class City
    {
        [DataMember(IsRequired = true)]
        public int CityID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual City city { get; set; }
    }
}