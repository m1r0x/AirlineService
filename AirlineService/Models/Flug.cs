using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AirlineService.Models
{
    [DataContract]
    public class Flug : Airline
    {
        private int _FlugID;
        private string _Name;
        private string _StartOrt;
        private string _ZielOrt;

        [DataMember]
        public int FlugID { get => _FlugID; set => _FlugID = value; }
        [DataMember]
        public string Name { get => _Name; set => _Name = value; }
        [DataMember]
        public string StartOrt { get => _StartOrt; set => _StartOrt = value; }
        [DataMember]
        public string ZielOrt { get => _ZielOrt; set => _ZielOrt = value; }

        public Flug() { }
        public Flug(string name, string StartOrt, string ZielOrt)
        {
            this.Name = name;
            this.StartOrt = StartOrt;
            this.ZielOrt = ZielOrt;
        }
    }
}