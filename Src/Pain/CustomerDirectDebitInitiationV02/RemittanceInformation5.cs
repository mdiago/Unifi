using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class RemittanceInformation5
    {

        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }

        [XmlElement("Strd")]
        public StructuredRemittanceInformation7[] Strd { get; set; }

    }

}
