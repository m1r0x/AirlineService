using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AirlineService.Models
{
    public class Airline
    {
        private int _AirlineID;
        private string _Name;
        private string _Beschreibung;

        [DataMember]
        public int AirlineID { get => _AirlineID; set => _AirlineID = value; }
        [DataMember]
        public string Name { get => _Name; set => _Name = value; }
        [DataMember]
        public string Beschreibung { get => _Beschreibung; set => _Beschreibung = value; }

        public Airline() { }
        public Airline(string name, string beschreibung)
        {
            this.Name = name;
            this.Beschreibung = beschreibung;
        }
    }
}