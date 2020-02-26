using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class RemittanceInformation1
    {


        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }


        [XmlElement("Strd")]
        public StructuredRemittanceInformation6[] Strd { get; set; }

    }
}
