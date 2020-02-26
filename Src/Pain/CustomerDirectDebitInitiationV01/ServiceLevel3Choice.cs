using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class ServiceLevel3Choice
    {


        [XmlElement("Cd", typeof(ServiceLevel2Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
