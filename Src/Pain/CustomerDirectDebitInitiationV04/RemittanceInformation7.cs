using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class RemittanceInformation7
    {
        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }


        [XmlElement("Strd")]
        public StructuredRemittanceInformation9[] Strd { get; set; }
    }


}

