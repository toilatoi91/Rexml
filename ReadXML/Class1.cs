using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadXML
{
    public class Location
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        public List<Building> Buildings { get; set; }
    }

    public class Building
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Room
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        public int Capacity { get; set; }
    }

    [XmlRoot("info")]
    public class Info
    {
        [XmlArray("locations")]
        [XmlArrayItem("location")]
        public List<Location> Locations { get; set; }
    }
}


