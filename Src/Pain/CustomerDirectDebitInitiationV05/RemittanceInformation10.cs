using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class RemittanceInformation10
    {
        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }

        [XmlElement("Strd")]
        public StructuredRemittanceInformation12[] Strd { get; set; }

    }



}

